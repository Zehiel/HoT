using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureIoTHub.Models
{
    public class Device
    {
        public int ID { get; set; }
        public bool Connected { get; set; }
        public bool Ready { get; set; }
        public Sensor[] Sensors { get; set;}
    }
}
