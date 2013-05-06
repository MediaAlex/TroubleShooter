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

namespace TroubleShooter
{
	public partial class FahrzeugFahrerraum
	{
		public FahrzeugFahrerraum()
		{
			this.InitializeComponent();

			// Fügen Sie Code, der bei der Objekterstellung erforderlich ist, unter diesem Punkt ein.
		}

        private void stPan_menue_MouseEnter(object sender, MouseEventArgs e)
        {
            stPan_menue.Visibility = Visibility.Visible;
        }

        private void stPan_menue_MouseLeave(object sender, MouseEventArgs e)
        {
            stPan_menue.Visibility = Visibility.Collapsed;
        }

        private void el_raus_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }


        //Aktionen -------- Anfang -----------

        private void tBl_hupHupen_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[38].prüfschritt, prüfschrittID = App.alleAS[38].prüfschrittID });
        }

        private void tBl_hupAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[38].prüfschritt, prüfschrittID = App.alleAS[38].prüfschrittID });
            img_hupe.Visibility = Visibility.Collapsed;
            tBl_lenkrHupeEinb.Visibility = Visibility.Visible;
        }

        private void tBl_sichPr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[36].prüfschritt, prüfschrittID = App.alleAS[36].prüfschrittID });
        }

        private void tBl_relPr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[22].prüfschritt, prüfschrittID = App.alleAS[22].prüfschrittID }); //UNVOLLSTÄNDIG!!!
        }

        private void tBl_wblAn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //App.prot.Add(App.alleAS[36]);
        }

        private void tBl_wblEingPruf_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //App.prot.Add(App.alleAS[36]);
        }

        private void tBl_WblAusgPruf_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //App.prot.Add(App.alleAS[36]);
        }

        private void tBl_lenkrAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[39].prüfschritt, prüfschrittID = App.alleAS[39].prüfschrittID });
            img_lenkr.Visibility = Visibility.Collapsed;
            tBl_lenkrEinb.Visibility = Visibility.Visible;
            tBl_blAusb.Visibility = Visibility.Visible;
        }

        private void tBl_hupEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[37].prüfschritt, prüfschrittID = App.alleAS[37].prüfschrittID });
            img_hupe.Visibility = Visibility.Visible;
            tBl_lenkrHupeEinb.Visibility = Visibility.Collapsed;
            tBl_blAusb.Visibility = Visibility.Collapsed;
        }

        private void tBl_blLi_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[6].prüfschritt, prüfschrittID = App.alleAS[6].prüfschrittID });
        }

        private void tBl_blRe_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[8].prüfschritt, prüfschrittID = App.alleAS[8].prüfschrittID });
        }

        private void tBl_liHu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //App.prot.Add(App.alleAS[]);
        }

        private void tBl_blAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[43].prüfschritt, prüfschrittID = App.alleAS[43].prüfschrittID });
            img_blSchW.Visibility = Visibility.Collapsed;
        }

        private void tBl_eingPruf_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[41].prüfschritt, prüfschrittID = App.alleAS[41].prüfschrittID });
        }

        private void tBl_ausgPruf_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[42].prüfschritt, prüfschrittID = App.alleAS[42].prüfschrittID });
        }

        private void tBl_lenkrEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[40].prüfschritt, prüfschrittID = App.alleAS[40].prüfschrittID });
            img_lenkr.Visibility = Visibility.Visible;
            tBl_lenkrEinb.Visibility = Visibility.Collapsed;
        }

        private void tBl_blEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[44].prüfschritt, prüfschrittID = App.alleAS[44].prüfschrittID });
            img_blSchW.Visibility = Visibility.Visible;
        }
        
        //Aktionen -------- Ende -----------

        //Aktionsmenüs öffnen ---- Anfang ------
        private void visibCol_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as StackPanel).Visibility = Visibility.Collapsed;
        }

        private void img_SchW_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void img_wrnBl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            stPan_menuWarnBlinker.Visibility = Visibility.Visible;
        }

        private void img_blinker_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            stPan_menuBlinker.Visibility = Visibility.Visible;
        }

        private void img_sichRel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            stPan_menuSichRel.Visibility = Visibility.Visible;
        }

        private void hupe_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            stPan_menuHupe.Visibility = Visibility.Visible;
        }

        private void lnkRad_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            stPan_menuLenkr.Visibility = Visibility.Visible;
        }

        private void MenüBlinkerEinbauen(object sender, MouseButtonEventArgs e)
        {
            stPan_menuBlEinb.Visibility = Visibility.Visible;
        }
        //Aktionsmenüs öffnen ---- Ende ------
	}
}