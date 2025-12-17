using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Music
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public bool IsAvailable { get; set; }
    }
}
