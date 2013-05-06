using System;
using System.Collections.Generic;
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

        //NavigationService navi;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
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
            //App._ziele.Add(blinker);
            //App._ziele.Add(blinkerRe);
            //App._ziele.Add(blinkerLi);

            //aktAuftrag.textAuftrag = App._ziele[rnd.Next(0, 3)].bezeichnung + " funktioniert nicht.";

            int rndNr = rnd.Next(0, 6);
            App._teileBli.Add(alleAutoteile);
            aktAuftrag.defekt = App._teileBli[0].alleTeile()[rndNr].bezeichnung;
            aktAuftrag.defektID = App._teileBli[0].alleTeile()[rndNr].bezID;

            _ArbeitsschritteFestlegen(aktAuftrag.defektID);

            aktAuftrag.textAuftrag = "Blinker funktioniert nicht";
            aktAuftrag.prüfFolge = App._arbSchritteOptimal;
            App._situation.Add(aktAuftrag);

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