using System;
using System.Collections.Generic;
using System.Text;

namespace Subscriber.Settings.Implementation
{
    public class DBSettings : IDBSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
