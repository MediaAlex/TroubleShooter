using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace TroubleShooter
{
    public class Abhängigkeiten
    {
        List<IRegel> helpList = new List<IRegel>();

        public Abhängigkeiten()
        {
            Fakt f1 = new Fakt();
            f1.bezeichnung = "bat";

            Fakt f2 = new Fakt();
            f1.bezeichnung = "Blinker Schalter";

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

            Regel blinkSich = new Regel();
            blinker.bezeichnung = "Sicherung Blinker";

            Regel blinkRel = new Regel();
            blinker.bezeichnung = "Relais Blinker";

            Regel glBlLiV = new Regel();
            blinker.bezeichnung = "Glühlampe Blinker Links vorne";

            Regel glBlReV = new Regel();
            blinker.bezeichnung = "Glühlampe Blinker Rechts vorne";

            blinkSich.voraussetzungen.Add(f1);

            blinkRel.voraussetzungen.Add(blinkSich);

            blinkRel.voraussetzungen.Add(f2);

            glBlLiV.voraussetzungen.Add(f1);
            glBlLiV.voraussetzungen.Add(blinkRel);

            glBlReV.voraussetzungen.Add(f1);
            glBlReV.voraussetzungen.Add(blinkRel);

            blinker.voraussetzungen.Add(blinkRel);

            blinkerLi.voraussetzungen.Add(blinker);
            blinkerLi.voraussetzungen.Add(glBlLiV);

            blinkerRe.voraussetzungen.Add(blinker);
            blinkerRe.voraussetzungen.Add(glBlLiV);

            warnBlinker.voraussetzungen.Add(f1);
            warnBlinker.voraussetzungen.Add(blinkRel);

            abblendlicht.voraussetzungen.Add(f1);

            App._fakten.Add(f1);
            App._fakten.Add(f2);

            App._ziele.Add(blinker);

            while (App._ziele.Count > 0)
            {
                IRegel current = App._ziele[0];
                App._ziele.Remove(current);
                foreach (IRegel r in current.voraussetzungen)
                {
                    if (!App._fakten.Contains(r))
                    {
                        App._ziele.Insert(0, r);
                        if (!helpList.Contains(r))
                        {
                            helpList.Add(r);
                        }
                    }
                    else
                    {

                    }
                }
                List<int> zuLoeschendeIndizes = new List<int>();
                for(int i=0;i<helpList.Count;i++)
                {
                    bool isFact = true;
                    foreach (IRegel r in helpList[i].voraussetzungen)
                    {
                        if (!App._fakten.Contains(r))
                        {
                            isFact = false;
                        }
                    }
                    if (isFact)
                    {

                        App._fakten.Add((Fakt)helpList[i]);
                        zuLoeschendeIndizes.Add(i);
                        //helpList.RemoveAt(i);
                    } 
                }
                foreach (int j in zuLoeschendeIndizes)
                {
                    helpList.RemoveAt(j);
                }
            }

    

            String bla = "";
            foreach (IRegel f in App._fakten)
            {
                bla += f.bezeichnung + ";";
            }

            bool zielErreicht = true;
            foreach (var regel in blinker.voraussetzungen)
            {
                if (!App._fakten.Contains(regel))
                {
                    zielErreicht = false;
                    break;
                }
            }


            MessageBox.Show("Voraussetzungen: "+bla);
            if (zielErreicht)
            {
                MessageBox.Show("Jup, alles erreicht!");
            }
            else
            {
                MessageBox.Show("Njjjet");
            }
        }
    }
}
