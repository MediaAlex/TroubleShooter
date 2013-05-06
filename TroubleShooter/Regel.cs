using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TroubleShooter
{
    public class Regel : IRegel
    {
        public Regel()
        {
            voraussetzungen = new List<IRegel>();
        }
    }
}
