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
            int rndIndex = rnd.Next(0, 6);

            Autoteile alleAutoteile = new Autoteile();
            Situation aktAuftrag = new Situation();
            ArbeitsschritteBlinkerLi asBlLi = new ArbeitsschritteBlinkerLi();

            _ArbeitsschritteFestlegen();

            App._teileBli.Add(alleAutoteile);

            aktAuftrag.defekt = App._teileBli[0].alleTeile()[rndIndex].bezeichnung;
            aktAuftrag.textAuftrag = "Blinker links ohne Funktion.";
            aktAuftrag.prüfFolge = App._arbSchritteBliLi;
            App._situation.Add(aktAuftrag);
        }

        private void _ArbeitsschritteFestlegen()
        {
            ArbeitsschritteBlinkerLi alleSchritte = new ArbeitsschritteBlinkerLi();
            App._arbSchritteBliLi = alleSchritte._ASBlLi();
        }
	}
}