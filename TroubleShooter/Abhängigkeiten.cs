using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TroubleShooter
{
    public class Abhängigkeiten
    {
        public Abhängigkeiten()
        {
            Fakt f1 = new Fakt();
            f1.bezeichnung = "bat";
            Fakt f2 = new Fakt();
            f2.bezeichnung = "sichBlink";
            Fakt f3 = new Fakt();
            f3.bezeichnung = "blinkRel";
            Fakt f4 = new Fakt();
            f4.bezeichnung = "blinkSch";
            Fakt f5 = new Fakt();
            f5.bezeichnung = "blinkglühlLi";
            Fakt f6 = new Fakt();
            f6.bezeichnung = "blinkglühlRe";

            Regel blinker = new Regel();
            blinker.bezeichnung = "Blinker";

            Regel blinkerLi = new Regel();
            blinkerLi.bezeichnung = "Blinker links";

            Regel blinkerRe = new Regel();
            blinkerRe.bezeichnung = "Blinker rechts";

            Regel abblendlicht = new Regel();
            abblendlicht.bezeichnung = "Abblendlicht";

            Regel warnBlinker = new Regel();
            warnBlinker.bezeichnung = "Warnblinker";

            blinker.voraussetzungen.Add(f1);
            blinker.voraussetzungen.Add(f2);
            blinker.voraussetzungen.Add(f3);
            blinker.voraussetzungen.Add(f4);

            blinkerLi.voraussetzungen.Add(f1);
            blinkerLi.voraussetzungen.Add(f2);
            blinkerLi.voraussetzungen.Add(f3);
            blinkerLi.voraussetzungen.Add(f4);
            blinkerLi.voraussetzungen.Add(f5);

            blinkerRe.voraussetzungen.Add(f1);
            blinkerRe.voraussetzungen.Add(f2);
            blinkerRe.voraussetzungen.Add(f3);
            blinkerRe.voraussetzungen.Add(f4);
            blinkerRe.voraussetzungen.Add(f6);

            warnBlinker.voraussetzungen.Add(f1);
            warnBlinker.voraussetzungen.Add(f2);
            warnBlinker.voraussetzungen.Add(f3);

            abblendlicht.voraussetzungen.Add(f1);

            App._fakten.Add(f1);
            App._fakten.Add(f2);
            App._fakten.Add(f3);
            App._fakten.Add(f4);
            App._fakten.Add(f5);
            App._fakten.Add(f6);

            //App._ziele.Add(blinker);
            //App._ziele.Add(blinkerRe);
            App._ziele.Add(blinkerLi);

            while (App._ziele.Count > 0)
            {
                IRegel current = App._ziele[0];
                App._ziele.Remove(current);
                foreach (IRegel r in current.voraussetzungen)
                {
                    if (!App._fakten.Contains(r))
                    {
                        App._ziele.Insert(0, r);

                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
