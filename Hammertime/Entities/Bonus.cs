using System;
using System.Collections.Generic;
using System.Text;

namespace Hammertime.Core.Entities
{
    public class Bonus
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Version => "1.0";
    }
}
