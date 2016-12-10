using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureIoTHub.Models
{
    public class Sensor
    {
        public int ID { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}
