using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vardagsliv.Models
{
    public class Träningsschema : Schema
    {
        public string Namn { get; set; }
        public DateTime Starttid { get; set; }
        public TimeSpan Träningstid { get; set; }
        public DateTime Sluttid => Starttid + Träningstid;
        public TimeSpan Ombytestid { get; set; }
        public TimeSpan Resväg { get; set; }
        public string Color { get; set; }
    }
}
