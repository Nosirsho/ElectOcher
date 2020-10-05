using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectrOcher.Models {
    public class Talon {
        
        public int Id { get; set; }
        public string NomerPP { get; set; }
        public DateTime TalonTime { get; set; }
        public DateTime AcceptTime { get; set; }
        public bool AcceptFlag { get; set; }
        public string Operator { get; set; }
    }
}
