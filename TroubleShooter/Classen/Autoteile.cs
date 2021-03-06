﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TroubleShooter
{
    public class Autoteile
    {
        public string bezeichnung { get; set; }
        public string bezID { get; set; }

        public List<Autoteile> alleTeile()
        {
            List<Autoteile> teileList = new List<Autoteile>();
            teileList.Add(new Autoteile { bezeichnung = "Batterie", bezID = "bat" });
            teileList.Add(new Autoteile { bezeichnung = "Sicherung Blinker", bezID = "sichBlink" });
            teileList.Add(new Autoteile { bezeichnung = "Blinker Relais", bezID = "blinkRel" });
            teileList.Add(new Autoteile { bezeichnung = "Blinkerschalter", bezID = "blinkSch" });
            teileList.Add(new Autoteile { bezeichnung = "Glühlampe Blinker links", bezID = "blinkglühlLi" });
            teileList.Add(new Autoteile { bezeichnung = "Glühlampe Blinker rechts", bezID = "blinkglühlRe" });
            teileList.Add(new Autoteile { bezeichnung = "Abblendlicht", bezID = "licht" });

            return teileList;
        }
    }
}
