using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace App.Services.Implementation
{
    public class MessageService
    {
        private string Hostame = "localhost:9092";
        private string Topic = "test";
        private string ConsumerGroup = "test-consumer-group";

        public bool PublishMessage(string Message)
        {
            var config = new ProducerConfig { BootstrapServers = Hostame };

            Action<DeliveryReport<Null, string>> handler = r =>
                Console.WriteLine(!r.Error.IsError
                ? $"Delivered message to {r.TopicPartitionOffset}"
                : $"Delivery Error: {r.Error.Reason}");

            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                producer.ProduceAsync(topic: Topic, new Message<Null, string> { Value = Message }); ;

                producer.Flush(timeout: TimeSpan.FromSeconds(10));

            }

            return true;
        }
    }   
}