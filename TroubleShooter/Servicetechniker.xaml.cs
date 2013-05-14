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

namespace TroubleShooter
{
	public partial class Servicetechniker
	{
		public Servicetechniker()
		{
			this.InitializeComponent();

		}

        List<string> abhTeile = new List<string>();
        List<AbhängigkeitBlinker> ohneFunktion = new List<AbhängigkeitBlinker>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.abhängigkeiten.Add(new AbhängigkeitBlinker { fehl = "Blinker Rechts", gb = "blinkglühlRe", re = "blinkRel", schal = "blinkSch", si = "sichBlink", ba = "bat" });
            App.abhängigkeiten.Add(new AbhängigkeitBlinker { fehl = "Blinker Links", gb = "blinkglühlLi", re = "blinkRel", schal = "blinkSch", si = "sichBlink", ba = "bat" });
            _Auftrag();
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
	}
}