using System;
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
            initDialog();
		}

        List<DialogElement> alleDialoge = new List<DialogElement>();
        String currentDialog = "";
        Random random = new Random();
        Button von;
        Button bis;
        DialogElement zwischenFrageDialog = new DialogElement();

        List<string> abhTeile = new List<string>();
        List<AbhängigkeitBlinker> ohneFunktion = new List<AbhängigkeitBlinker>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.abhängigkeiten.Add(new AbhängigkeitBlinker { fehl = "Blinker Rechts", gb = "blinkglühlRe", re = "blinkRel", schal = "blinkSch", si = "sichBlink", ba = "bat" });
            App.abhängigkeiten.Add(new AbhängigkeitBlinker { fehl = "Blinker Links", gb = "blinkglühlLi", re = "blinkRel", schal = "blinkSch", si = "sichBlink", ba = "bat" });
            _Auftrag();
            getDialog("", currentDialog);
        }

        private void but_weiter_Click(object sender, RoutedEventArgs e)
        {
            SeiteFahrzeug sF = new SeiteFahrzeug();
            sF.ShowDialog();
        }

        private void _Auftrag()
        {
            Random rnd = new Random();

            Autoteile alleAutoteile = new Autoteile();
            Situation aktAuftrag = new Situation();

            int rndNr = rnd.Next(0, 6);
            App._autoTeile.Add(alleAutoteile);
            aktAuftrag.defekt = App._autoTeile[0].alleTeile()[rndNr].bezeichnung;
            aktAuftrag.defektID = App._autoTeile[0].alleTeile()[rndNr].bezID;

            ohneFunktion = (from a in App.abhängigkeiten
                            where
                                a.ba == aktAuftrag.defektID || a.gb == aktAuftrag.defektID || a.re == aktAuftrag.defektID ||
                                a.schal == aktAuftrag.defektID || a.si == aktAuftrag.defektID
                            select a).ToList();

            _ArbeitsschritteFestlegen(aktAuftrag.defektID);

            foreach (var x in ohneFunktion)
            {
                abhTeile.Add(x.fehl);
            }

            foreach (var item in abhTeile)
            {
                aktAuftrag.textAuftrag += item + " funktioniert nicht.\n";
            }

            aktAuftrag.prüfFolge = App._arbSchritteOptimal;
            App._situation.Add(aktAuftrag);
            ohneFunktion.Clear();
            App.abhängigkeiten.Clear();
        }

        private void _ArbeitsschritteFestlegen(string defekt)
        {
            ArbSchrBlinksysOptimal alleSchritte = new ArbSchrBlinksysOptimal();
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
        private void initDialog()
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
            d2.dialogText = "Hallo. Ich habe gerade meinen letzten Auftrag fertig. Haben Sie noch etwas anderes für mich?";
            d2.antwortenIDs.Add("8");

            DialogElement d3 = new DialogElement();
            d3.dialogID = "3";
            d3.dialogText = "Hallo. Ich habe gerade erst meine Schicht begonnen. Haben Sie einen Auftrag für mich?";
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
            d6.dialogText = "Ok. Wenn sie wieder da sind, kommen sie zu mir. Ich habe da was für Sie";

            DialogElement d7 = new DialogElement();
            d7.dialogID = "7";
            d7.dialogText = "Oh, das tut mir aber sehr leid. Ich habe natürlich Verständniss. Sie können für immer nach Hause gehn!";

            DialogElement d8 = new DialogElement();
            d8.dialogID = "8";
            d8.dialogText = "Ja, Ich habe da was, hier. Lesen Sie den Auftrag durch und begeben sie sich zum Fahrzeug. Es wurde schon in die Werkstatt gefahren.";
            
            alleDialoge.Add(d1);
            alleDialoge.Add(d2);
            alleDialoge.Add(d3);
            alleDialoge.Add(d4);
            alleDialoge.Add(d5);
            alleDialoge.Add(d6);
            alleDialoge.Add(d7);
            alleDialoge.Add(d8);

            currentDialog = "1";
        }

        private void getDialog(string preis, string dialogID)
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

            if (dialog[0].dialogArt != null && dialog[0].dialogArt.Equals("C"))
            {
                lb_antworten.Visibility = Visibility.Hidden;
                cv_orte.Visibility = Visibility.Visible;
            }
            else
            {
                cv_orte.Visibility = Visibility.Hidden;
            }

            if (preis != "")
            {
                dialog[0].dialogText = dialog[0].dialogText.Replace("???", preis);
            }
            if (dialog[0].dialogArt != null && dialog[0].dialogArt.Equals("Frage"))
            {
                tBl_servTechn.Text = "Fragen Sie!";
            }
            else
            {
                tBl_servTechn.Text = dialog[0].dialogText;
                dialogHelp.Add(zwischenFrageDialog);
            }


            lb_antworten.ItemsSource = dialogHelp;
        }

        private void lb_antworten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lb_antworten.SelectedItem != null)
            {
                DialogElement tempDialog = ((DialogElement)lb_antworten.SelectedItem);
                if (tempDialog.antwortenIDs.Count == 0) return;

                if (tempDialog.dialogArt == "Frage")
                {

                    getDialog("", "9");

                }
                else
                {

                    int rand = random.Next(tempDialog.antwortenIDs.Count);
                    currentDialog = tempDialog.antwortenIDs[rand];
                    getDialog("", currentDialog);
                }


            }
        }
	}
}