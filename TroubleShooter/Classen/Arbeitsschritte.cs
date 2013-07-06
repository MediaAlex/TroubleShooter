using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TroubleShooter
{
    public class Arbeitsschritte    
    {
        public static List<IArbeitsschritte> schritte { get; set; }
        public static List<IArbeitsschritte> zuPrüfen()
        //0,6,8,10,17,22,23,33,30,36,39,41,42,43,44,06,08,40,37
        {
            schritte = new List<IArbeitsschritte>();
            schritte.Add(new IArbeitsschritte { prüfschritt = "In Fahrerraum eingestiegen", prüfschrittID = "FahrrEinst" });//00
            schritte.Add(new IArbeitsschritte { prüfschritt = "Zur Fahrzeugfront gegangen", prüfschrittID = "frontGehn" });//01
            schritte.Add(new IArbeitsschritte { prüfschritt = "Motorhaube aufgemacht", prüfschrittID = "motHaubAuf" });//02
            schritte.Add(new IArbeitsschritte { prüfschritt = "Motorhaube zugemacht", prüfschrittID = "motHaubZu" });//03
            schritte.Add(new IArbeitsschritte { prüfschritt = "Aus Fahrzeug ausgestiegen", prüfschrittID = "ausFahrz" });//04
            schritte.Add(new IArbeitsschritte { prüfschritt = "Zur Fahrzeugseite gegangen", prüfschrittID = "SeiteGehn" });//05
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinker links betätigt", prüfschrittID = "blLiEin" });//06
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinker links ausgeschaltet", prüfschrittID = "blLiAus" });//07
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinker rechts betätigt", prüfschrittID = "blReEin" });//08
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinker rechts ausgeschaltet", prüfschrittID = "blReAus" });//09
            schritte.Add(new IArbeitsschritte { prüfschritt = "Licht eingeschaltet", prüfschrittID = "liEin" });//10
            schritte.Add(new IArbeitsschritte { prüfschritt = "Licht ausgeschaltet", prüfschrittID = "liAus" });//11
            schritte.Add(new IArbeitsschritte { prüfschritt = "Batteriespannung geprüft", prüfschrittID = "batSpanPrüf" });//12
            schritte.Add(new IArbeitsschritte { prüfschritt = "Batterie abgeklemmt", prüfschrittID = "batAbkl" });//13
            schritte.Add(new IArbeitsschritte { prüfschritt = "Batterie angeklemmt", prüfschrittID = "batAnkl" });//14
            schritte.Add(new IArbeitsschritte { prüfschritt = "Batterie ausgebaut", prüfschrittID = "batAusb" });//15
            schritte.Add(new IArbeitsschritte { prüfschritt = "Batterie eingebaut", prüfschrittID = "batEinb" });//16
            schritte.Add(new IArbeitsschritte { prüfschritt = "Sicherung geprüft", prüfschrittID = "sichPrüf" });//17
            schritte.Add(new IArbeitsschritte { prüfschritt = "Sicherung ausgebaut", prüfschrittID = "sichAusb" });//18
            schritte.Add(new IArbeitsschritte { prüfschritt = "Sicherung eingebaut", prüfschrittID = "sichEinb" });//19
            schritte.Add(new IArbeitsschritte { prüfschritt = "In Sicherungskasten geschaut", prüfschrittID = "sichKastSchau" });//20
            schritte.Add(new IArbeitsschritte { prüfschritt = "In Relaiskasten geschaut", prüfschrittID = "relKastSchau" });//21
            schritte.Add(new IArbeitsschritte { prüfschritt = "Reilais Eingang geprüft", prüfschrittID = "relEingPrüf" });//22
            schritte.Add(new IArbeitsschritte { prüfschritt = "Reilais Ausgang geprüft", prüfschrittID = "relAusgPrüf" });//23
            schritte.Add(new IArbeitsschritte { prüfschritt = "Reilais ausgebaut", prüfschrittID = "relAusb" });//24
            schritte.Add(new IArbeitsschritte { prüfschritt = "Reilais eingebaut", prüfschrittID = "relEinb" });//25
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinker vorne rechts ausgebaut", prüfschrittID = "blinkVReAusb" });//26
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinker vorne rechts eingebaut", prüfschrittID = "blinkVReEinb" });//27
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinker vorne links ausgebaut", prüfschrittID = "blinkVLiAusb" });//28
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinker vorne links eingebaut", prüfschrittID = "blinkVLiEinb" });//29
            schritte.Add(new IArbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne rechts geprüft", prüfschrittID = "glLaBlinkVRePrüf" });//30
            schritte.Add(new IArbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne rechts ausgebaut", prüfschrittID = "glLaBlinkVReAusb" });//31
            schritte.Add(new IArbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne rechts eingebaut", prüfschrittID = "glLaBlinkVReEinb" });//32
            schritte.Add(new IArbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne links geprüft", prüfschrittID = "glLaBlinkVLiPrüf" });//33
            schritte.Add(new IArbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne links ausgebaut", prüfschrittID = "glLaBlinkVLiAusb" });//34
            schritte.Add(new IArbeitsschritte { prüfschritt = "Glühlampe von Blinker vorne links eingebaut", prüfschrittID = "glLaBlinkVLiEinb" });//35
            schritte.Add(new IArbeitsschritte { prüfschritt = "Hupe ausgebaut", prüfschrittID = "hupeAusb" });//36
            schritte.Add(new IArbeitsschritte { prüfschritt = "Hupe eingebaut", prüfschrittID = "hupeEinb" });//37
            schritte.Add(new IArbeitsschritte { prüfschritt = "Hupe betätigt", prüfschrittID = "hupen" });//38
            schritte.Add(new IArbeitsschritte { prüfschritt = "Lenkrad ausgebaut", prüfschrittID = "LenkrAusb" });//39
            schritte.Add(new IArbeitsschritte { prüfschritt = "Lenkrad eingebaut", prüfschrittID = "LenkrEinb" });//40
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinkerschalter Spannung Eingang geprüft", prüfschrittID = "blinkSpanEingPrüf" });//41
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinkerschalter Spannung Ausgang geprüft", prüfschrittID = "blinkSpanAusgPrüf" });//42
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinkerschalter ausgebaut", prüfschrittID = "blinkSchAusb" });//43
            schritte.Add(new IArbeitsschritte { prüfschritt = "Blinkerschalter eingebaut", prüfschrittID = "blinkSchEinb" });//44
            schritte.Add(new IArbeitsschritte { prüfschritt = "Batterie geladen", prüfschrittID = "BatLaden" });//45

            return schritte;
        }
    }
}
