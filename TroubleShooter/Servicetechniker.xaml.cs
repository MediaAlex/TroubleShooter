﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;
using TroubleShooter.Classen;

namespace TroubleShooter
{
    public partial class Servicetechniker
    {
        public Servicetechniker()
        {
            this.InitializeComponent();
        }

        List<DialogElement> alleDialoge;

        List<string> abhTeile;

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (App.nav.Last() == "profil")
            {
                SetzeAbhängigkeiten();
                _Auftrag();
            } 
            
            if (App.collapsTBls == null)
            {
                App.collapsTBls = new List<TextBlock>();
                FülleColTBls();
            }

            if (App.collapsImgs == null)
                App.collapsImgs = new List<string>();

            if (App.visTBls == null)
                App.visTBls = new List<TextBlock>();
            
            if (alleDialoge == null)
                alleDialoge = new List<DialogElement>();
            else
            {
                alleDialoge = null;
                alleDialoge = new List<DialogElement>();
            }
            InitDialog();
            GetDialog(App.currentDialog);
        }

        private void SetzeAbhängigkeiten()
        {
            App.abhängigkeiten.Add(new Abhängigkeit
            {
                fehl = "Blinker Rechts",
                gbRe = "blinkglühlRe",
                def = "blinkglühlRe"
            });
            App.abhängigkeiten.Add(new Abhängigkeit
            {
                fehl = "Blinker Links",
                gbLi = "blinkglühlLi",
                def = "blinkglühlLi"
            });
            App.abhängigkeiten.Add(new Abhängigkeit
            {
                fehl = "Blinker",
                gbLi = "blinkglühlLi",
                gbRe = "blinkglühlRe",
                licht = "licht",
                re = "blinkRel",
                schal = "blinkSch",
                si = "sichBlink",
                def = "bat"
            });
            App.abhängigkeiten.Add(new Abhängigkeit
            {
                fehl = "Blinker",
                gbRe = "blinkglühlRe",
                gbLi = "blinkglühlLi",
                re = "blinkRel",
                schal = "blinkSch",
                def = "sichBlink"
            });
            App.abhängigkeiten.Add(new Abhängigkeit
            {
                fehl = "Blinker",
                gbRe = "blinkglühlRe",
                gbLi = "blinkglühlLi",
                re = "blinkRel",
                def = "blinkSch"
            });
            App.abhängigkeiten.Add(new Abhängigkeit
            {
                fehl = "Blinker",
                gbRe = "blinkglühlRe",
                gbLi = "blinkglühlLi",
                def = "blinkRel"
            });
        }

        private void FülleColTBls()
        {
            FahrzeugFahrerraum ff = new FahrzeugFahrerraum();
            FahrzeugFront ffr = new FahrzeugFront();
            App.collapsTBls.Add(ff.tBl_blAusb);
            App.collapsTBls.Add(ff.tBl_eingPruf);
            App.collapsTBls.Add(ff.tBl_ausgPruf);
            App.collapsTBls.Add(ff.tBl_lenkrEinb);
            App.collapsTBls.Add(ff.tBl_wrnEingPr);
            App.collapsTBls.Add(ff.tBl_wrnAusgpr);
            App.collapsTBls.Add(ff.tBl_relEinb);
            App.collapsTBls.Add(ff.tBl_siEinb);
            App.collapsTBls.Add(ffr.tBl_blReGlLaEinb);
            App.collapsTBls.Add(ffr.tBl_blLiGlLaEinb);
        }

        private void but_weiter_Click(object sender, RoutedEventArgs e)
        {
            SeiteFahrzeug sF = new SeiteFahrzeug();
            sF.ShowDialog();
        }

        private void _Auftrag()
        {
            abhTeile = new List<string>();
            Random rnd = new Random();

            Autoteile alleAutoteile = new Autoteile();
            Situation aktAuftrag = new Situation();

            int rndNr = rnd.Next(0, 6);
            App._autoTeile.Add(alleAutoteile);
            aktAuftrag.defekt = App._autoTeile[0].alleTeile()[rndNr].bezeichnung;
            aktAuftrag.defektID = App._autoTeile[0].alleTeile()[rndNr].bezID;

            App.ohneFunktion = (from a in App.abhängigkeiten where a.def == aktAuftrag.defektID select a).ToList();

            _ArbeitsschritteFestlegen(aktAuftrag.defektID);

            foreach (var x in App.ohneFunktion)
            {
                abhTeile.Add(x.fehl);
            }

            foreach (var item in abhTeile)
            {
                aktAuftrag.textAuftrag += item + " funktioniert nicht.\n";
            }

            aktAuftrag.prüfFolge = App._arbSchritteOptimal;
            App._situation.Add(aktAuftrag);
            App.abhängigkeiten.Clear();
        }

        private void _ArbeitsschritteFestlegen(string defekt)
        {
            ArbeitsschriteOptimal alleSchritte = new ArbeitsschriteOptimal();
            switch (defekt)
            {
                case "bat":
                    App._arbSchritteOptimal = alleSchritte._defBat();
                    break;

                case "sichBlink":
                    App._arbSchritteOptimal = alleSchritte._defSich();
                    break;

                case "blinkRel":
                    App._arbSchritteOptimal = alleSchritte._defRel();
                    break;

                case "blinkSch":
                    App._arbSchritteOptimal = alleSchritte._defBlSch();
                    break;

                case "blinkglühlLi":
                    App._arbSchritteOptimal = alleSchritte._defGlLampLi();
                    break;

                case "blinkglühlRe":
                    App._arbSchritteOptimal = alleSchritte._defGlLampRe();
                    break;
            }
        }
        private void InitDialog()
        {
            if (App.nav.Last() == "profil")
            {
                DialogElement d1 = new DialogElement();
                d1.dialogID = "1";
                d1.dialogText = "Hallo, was kann ich für Sie tun?";
                d1.antwortenIDs.Add("2");
                d1.antwortenIDs.Add("3");
                d1.antwortenIDs.Add("4");
                d1.antwortenIDs.Add("5");

                DialogElement d2 = new DialogElement();
                d2.dialogID = "2";
                d2.dialogText = "Hallo. Ich habe gerade erst meine Schicht begonnen. Haben Sie einen Auftrag für mich?";
                d2.antwortenIDs.Add("8");

                DialogElement d3 = new DialogElement();
                d3.dialogID = "3";
                d3.dialogText = "Hallo. Haben Sie einen Auftrag für mich?";
                d3.antwortenIDs.Add("8");

                DialogElement d4 = new DialogElement();
                d4.dialogID = "4";
                d4.dialogText = "Ich bin mit meiner Schicht fertig und habe Feierabend.";
                d4.antwortenIDs.Add("6");

                DialogElement d5 = new DialogElement();
                d5.dialogID = "5";
                d5.dialogText = "Ich habe keine Lust mehr!";
                d5.antwortenIDs.Add("7");

                DialogElement d6 = new DialogElement();
                d6.dialogID = "6";
                d6.dialogText = "Ok. Wenn sie morgen wieder da sind, kommen sie zu mir. Ich habe da was für Sie";
                d6.antwortenIDs.Add("11");

                DialogElement d7 = new DialogElement();
                d7.dialogID = "7";
                d7.dialogText = "Oh, das tut mir aber sehr leid. Ich habe natürlich sowas von Verständniss! Bye Bye";
                d7.antwortenIDs.Add("11");

                DialogElement d8 = new DialogElement();
                d8.dialogID = "8";
                d8.dialogText = "Ja, Ich habe da was, hier. Lesen Sie den Auftrag durch und begeben sie sich zum Fahrzeug. Es wurde schon in die Werkstatt gefahren.";
                d8.antwortenIDs.Add("9");
                d8.antwortenIDs.Add("10");

                DialogElement d9 = new DialogElement();
                d9.dialogID = "9";
                d9.dialogText = "Ok. Ich mach mich sofort an die Arbeit.";

                DialogElement d10 = new DialogElement();
                d10.dialogID = "10";
                d10.dialogText = "Oh, es tut mir leid. Ich merke gerade, dass ich zur Pause muss.";

                DialogElement d11 = new DialogElement();
                d11.dialogID = "11";
                d11.dialogText = "OK";

                alleDialoge.Add(d1);
                alleDialoge.Add(d2);
                alleDialoge.Add(d3);
                alleDialoge.Add(d4);
                alleDialoge.Add(d5);
                alleDialoge.Add(d6);
                alleDialoge.Add(d7);
                alleDialoge.Add(d8);
                alleDialoge.Add(d9);
                alleDialoge.Add(d10);
                alleDialoge.Add(d11);

                App.currentDialog = "1";
            }

            if (App.nav.Last() == "werkstatt")
            {
                DialogElement d1 = new DialogElement();
                d1.dialogID = "1";
                d1.dialogText = "Hallo, was kann ich für Sie tun?";
                d1.antwortenIDs.Add("2");
                d1.antwortenIDs.Add("3");
                d1.antwortenIDs.Add("4");
                d1.antwortenIDs.Add("5");

                DialogElement d2 = new DialogElement();
                d2.dialogID = "2";
                d2.dialogText = "Hallo. Ich habe gerade das Fahrzeug repariert.";
                d2.antwortenIDs.Add("8");

                DialogElement d3 = new DialogElement();
                d3.dialogID = "3";
                d3.dialogText = "Hallo. Ich habe etwas vergessen. Ich komme später nochmal wieder.";

                DialogElement d4 = new DialogElement();
                d4.dialogID = "4";
                d4.dialogText = "Ich bin mit meiner Schicht fertig und habe Feierabend.";
                d4.antwortenIDs.Add("6");

                DialogElement d5 = new DialogElement();
                d5.dialogID = "5";
                d5.dialogText = "Ich habe keine Lust mehr!";
                d5.antwortenIDs.Add("7");

                DialogElement d6 = new DialogElement();
                d6.dialogID = "6";
                d6.dialogText = "Ok. Wenn sie morgen wieder da sind, kommen sie zu mir. Ich habe da was für Sie";
                d6.antwortenIDs.Add("11");

                DialogElement d7 = new DialogElement();
                d7.dialogID = "7";
                d7.dialogText = "Oh, das tut mir aber sehr leid. Ich habe natürlich volles großes Verständniss! Bye Bye";
                d7.antwortenIDs.Add("11");

                DialogElement d8 = new DialogElement();
                d8.dialogID = "8";
                d8.dialogText = "OK. Schauen wir es uns mal an.";
                d8.antwortenIDs.Add("9");
                d8.antwortenIDs.Add("12");

                DialogElement d9 = new DialogElement();
                d9.dialogID = "9";
                d9.dialogText = "Oh, es tut mir leid. Ich merke gerade, dass ich noch was vergessen habe.";

                DialogElement d11 = new DialogElement();
                d11.dialogID = "11";
                d11.dialogText = "OK";

                DialogElement d12 = new DialogElement();
                d12.dialogID = "12";
                d12.dialogText = "Hier der Auftag und mein Arbeitsbericht.";
                d12.antwortenIDs.Add("13");
                d12.antwortenIDs.Add("14");
                d12.antwortenIDs.Add("15");

                DialogElement d13 = new DialogElement();
                d13.dialogID = "13";
                d13.dialogText = "Du hast deine Arbeit sehr gut gemacht.";
                d13.antwortenIDs.Add("11");

                DialogElement d14 = new DialogElement();
                d14.dialogID = "14";
                d14.dialogText = "Du hast deine Arbeit sehr gut gemacht. Du hast weniger Arbeitsschritte gebraucht, als erwartet.";
                d14.antwortenIDs.Add("11");

                DialogElement d15 = new DialogElement();
                d15.dialogID = "15";
                d15.dialogText = "Du hast leider zu viel Arbeitsschritte gebraucht.";
                d15.antwortenIDs.Add("11");


                alleDialoge.Add(d1);
                alleDialoge.Add(d2);
                alleDialoge.Add(d3);
                alleDialoge.Add(d4);
                alleDialoge.Add(d5);
                alleDialoge.Add(d6);
                alleDialoge.Add(d7);
                alleDialoge.Add(d8);
                alleDialoge.Add(d9);
                //alleDialoge.Add(d10);
                alleDialoge.Add(d11);
                alleDialoge.Add(d12);
                alleDialoge.Add(d13);
                alleDialoge.Add(d14);
                alleDialoge.Add(d15);

                App.currentDialog = "1";
            }
        }

        private void GetDialog(string dialogID)
        {
            var dialog = (from node in alleDialoge
                          where node.dialogID == dialogID
                          select node).ToList();

            List<DialogElement> dialogHelp = new List<DialogElement>();
            foreach (String id in dialog[0].antwortenIDs)
            {
                var res = (from node in alleDialoge
                           where node.dialogID == id
                           select node).ToList();
                dialogHelp.Add(res[0]);
            }

            tBl_servTechn.Text = dialog[0].dialogText;

            lb_antworten.ItemsSource = dialogHelp;
        }

        private void lb_antworten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lb_antworten.SelectedItem != null)
            {
                DialogElement tempDialog = ((DialogElement)lb_antworten.SelectedItem);

                if (tempDialog.dialogID == "9")
                {
                    SeiteFahrzeug sF = new SeiteFahrzeug();
                    sF.ShowDialog();
                    this.Close();
                }

                if (tempDialog.dialogID == "10")
                    this.Close();

                if (tempDialog.dialogID == "11")
                    this.Close();

                else
                {
                    if (tempDialog.dialogID == "12")
                    {
                        string protokoll = "";
                        string ASOpt = "";
                        List<string> prot = new List<string>();
                        List<string> optArbSchr = new List<string>();

                        foreach (var item in App.prot)
                        {
                            protokoll += (item.prüfschritt + "\n");
                            prot.Add(item.prüfschritt);
                        }
                        foreach (var item in App._arbSchritteOptimal)
                        {
                            ASOpt += (item.prüfschritt + "\n");
                            optArbSchr.Add(item.prüfschritt);
                        }

                        MessageBox.Show("Vorgehen des Spielers: " + "\n" + protokoll + "\n\n" + "Optimales Vorgehen: " + "\n" + ASOpt);

                        var objs = (from a in prot from b in optArbSchr where a.CompareTo(b) == 0 select new { a, b }).Distinct();

                        string ausgabe = "";
                        int gleicheAS = 0;
                        foreach (var obj in objs)
                        {
                            gleicheAS ++;
                            ausgabe += (obj.a + " = " + obj.b + "\n");
                        }
                        MessageBox.Show(ausgabe);

                        if (App.prot.Count == App._arbSchritteOptimal.Count)
                        {
                            App.currentDialog = tempDialog.antwortenIDs[0];
                            GetDialog(App.currentDialog);
                        }

                        if (App.prot.Count < App._arbSchritteOptimal.Count)
                        {
                            App.currentDialog = tempDialog.antwortenIDs[1];
                            GetDialog(App.currentDialog);
                        }

                        if (App.prot.Count > App._arbSchritteOptimal.Count)
                        {
                            App.currentDialog = tempDialog.antwortenIDs[2];
                            GetDialog(App.currentDialog);
                        }
                    }

                    if (tempDialog.antwortenIDs.Count == 0) return;
                    else
                    {
                        App.currentDialog = tempDialog.antwortenIDs[0];
                        GetDialog(App.currentDialog);
                    }
                }
            }
        }
    }
}