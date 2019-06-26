using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vardagsliv.Models
{
    public class Jobbschema : Schema
    {
        public string Namn { get; set; }
        public DateTime Starttid { get; set; }
        public TimeSpan Jobbtid { get; set; }
        public DateTime Sluttid => Starttid + Jobbtid;
        public TimeSpan Resväg { get; set; }
        public TimeSpan Lunch { get; set; }
        public string Color { get; set; }

    }
}
