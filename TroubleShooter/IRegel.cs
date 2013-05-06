using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TroubleShooter
{
    public abstract class IRegel
    {
        public string bezeichnung { get; set; }
        public List<IRegel> voraussetzungen { get; set; }
    }
}
