using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TroubleShooter
{
    public class Arbeitsschritte
    {
        public string prüfschritt { get; set; }
        public string prüfschrittID { get; set; }

        public static List<Arbeitsschritte> zuPrüfen()
        {
            List<Arbeitsschritte> schritte = new List<Arbeitsschritte>();
            schritte.Add(new Arbeitsschritte { prüfschritt = "In Fahrerraum eingestiegen", prüfschrittID = "FahrrEinst" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Zur Fahrzeugfront gegangen", prüfschrittID = "frontGehn" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Motorhaube aufgemacht", prüfschrittID = "motHaubAuf" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Motorhaube zugemacht", prüfschrittID = "motHaubZu" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Aus Fahrzeug ausgestiegen", prüfschrittID = "ausFahrz" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Zur Fahrzeugseite gegangen", prüfschrittID = "SeiteGehn" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Blinker links betätigt", prüfschrittID = "blLiEin" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Blinker links ausgeschaltet", prüfschrittID = "blLiAus" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Blinker rechts betätigt", prüfschrittID = "blReEin" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Blinker rechts ausgeschaltet", prüfschrittID = "blReAus" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Licht eingeschaltet", prüfschrittID = "liEin" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Licht ausgeschaltet", prüfschrittID = "liAus" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Batteriespannung geprüft", prüfschrittID = "batSpanPrüf" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Batterie abgeklemmt", prüfschrittID = "batAbkl" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Batterie angeklemmt", prüfschrittID = "batAnkl" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Batterie ausgebaut", prüfschrittID = "batAusb" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Batterie eingebaut", prüfschrittID = "batEinb" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Sicherung geprüft", prüfschrittID = "sichPrüf" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Sicherung ausgebaut", prüfschrittID = "sichAusb" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Sicherung eingebaut", prüfschrittID = "sichEinb" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "In Sicherungskasten geschaut", prüfschrittID = "sichKastSchau" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "In Relaiskasten geschaut", prüfschrittID = "relKastSchau" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Reilais Eingang geprüft", prüfschrittID = "relEingPrüf" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Reilais Ausgang geprüft", prüfschrittID = "relAusgPrüf" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Reilais ausgebaut", prüfschrittID = "relAusb" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Reilais eingebaut", prüfschrittID = "relEinb" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Blinker vorne rechts ausgebaut", prüfschrittID = "blinkVReAus" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Blinker vorne rechts eingebaut", prüfschrittID = "blinkVReEin" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne rechts geprüft", prüfschrittID = "glLaBlinkVRePrüf" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne rechts ausgebaut", prüfschrittID = "glLaBlinkVReAus" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne rechts eingebaut", prüfschrittID = "glLaBlinkVReEin" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne links geprüft", prüfschrittID = "glLaBlinkVLiPrüf" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne links ausgebaut", prüfschrittID = "glLaBlinkVLiAus" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne links eingebaut", prüfschrittID = "glLaBlinkVLiEin" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Hupe ausgebaut", prüfschrittID = "hupeAusb" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Hupe eingebaut", prüfschrittID = "hupeEinb" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Hupe betätigt", prüfschrittID = "hupen" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Lenkrad ausgebaut", prüfschrittID = "LenkrAusb" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Lenkrad eingebaut", prüfschrittID = "LenkrEinb" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Blinkerschalter Spannung Eingang geprüft", prüfschrittID = "blinkSpanEingPrüf" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Blinkerschalter Spannung Ausgang geprüft", prüfschrittID = "blinkSpanAusgPrüf" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Blinkerschalter ausgebaut", prüfschrittID = "blinkAusg" });
            schritte.Add(new Arbeitsschritte { prüfschritt = "Blinkerschalter eingebaut", prüfschrittID = "blinkEing" });

            return schritte;
        }
        
    }
}
