using Subscriber.Models;
using Subscriber.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subscriber
{
    public class ConsoleApplication
    {
        private readonly IDBService _dbService;
        public ConsoleApplication(IDBService dbService)
        {
            _dbService = dbService;
        }

        public void Run()
        {
            var car = new Car();

            _dbService.InsertSingleRecord(car);
        }
    }
}
