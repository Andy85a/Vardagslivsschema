using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vardagsliv.Models
{
    public class Socialtschema : Schema
    {
        public string Namn { get; set; }
        public DateTime Starttid { get; set; }
        public TimeSpan Socialtid { get; set; }
        public DateTime Sluttid => Starttid + Socialtid;
        public TimeSpan Resväg { get; set; }
        public string Color { get; set; }
    }
}
