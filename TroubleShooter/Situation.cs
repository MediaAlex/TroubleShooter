using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TroubleShooter
{
    public class Situation
    {
        public string textAuftrag { get; set; }
        public string defekt { get; set; }
        public List<Arbeitsschritte> prüfFolge { get; set; }
    }
}
