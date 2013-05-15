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
using System.Windows.Media.Animation;

namespace TroubleShooter
{
	public partial class FahrzeugFahrerraum
	{
		public FahrzeugFahrerraum()
		{
			this.InitializeComponent();

			// Fügen Sie Code, der bei der Objekterstellung erforderlich ist, unter diesem Punkt ein.
		}

        bool blAn = false;
        SolidColorBrush scbBlLi = new SolidColorBrush();
        ColorAnimation caBlLi = new ColorAnimation();
        SolidColorBrush scbBlRe = new SolidColorBrush();
        ColorAnimation caBlRe = new ColorAnimation();
        List<string> abhTeile = new List<string>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            caBlLi.From = Colors.Transparent;
            caBlLi.To = Color.FromRgb(226, 181, 101);
            caBlLi.AutoReverse = true;
            caBlLi.RepeatBehavior = RepeatBehavior.Forever;
            caBlLi.Duration = new Duration(TimeSpan.FromSeconds(1));

            caBlRe.From = Colors.Transparent;
            caBlRe.To = Color.FromRgb(226, 181, 101);
            caBlRe.AutoReverse = true;
            caBlRe.RepeatBehavior = RepeatBehavior.Forever;
            caBlRe.Duration = new Duration(TimeSpan.FromSeconds(1));

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

        private void tBl_sichRelPr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
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

        private void blinkglühlLi_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            bool oF = false;
            TextBlock objekt = (sender as TextBlock);
            string objName = objekt.Name;

            foreach (var x in App.ohneFunktion)
            {
                if (x.gbLi == objName)
                {
                    oF = true;
                    break;
                }
            }

            if (!oF)
            {
                if (blAn)
                {
                    blAn = false;
                    scbBlLi.BeginAnimation(SolidColorBrush.ColorProperty, null);
                    blinkglühlRe.Visibility = Visibility.Visible;
                    objekt.Text = "Blinker Links an";
                }
                else
                {
                    blAn = true;
                    scbBlLi.BeginAnimation(SolidColorBrush.ColorProperty, caBlLi);
                    App.prot.Add(new Protokoll { prüfschritt = App.alleAS[6].prüfschritt, prüfschrittID = App.alleAS[6].prüfschrittID });
                    blinkglühlRe.Visibility = Visibility.Collapsed;
                    objekt.Text = "Blinker Links aus";
                    el_blLicLi.Fill = scbBlLi;
                }
            }
        }

        private void blinkglühlRe_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            bool oF = false;
            TextBlock objekt = (sender as TextBlock);
            string objName = objekt.Name;

            foreach (var x in App.ohneFunktion)
            {
                if (x.gbRe == objName)
                {
                    oF = true;
                    break;
                }
            }

            if (!oF)
            {
                if (blAn)
                {
                    blAn = false;
                    scbBlRe.BeginAnimation(SolidColorBrush.ColorProperty, null);
                    blinkglühlLi.Visibility = Visibility.Visible;
                    objekt.Text = "Blinker Links an";
                }
                else
                {
                    blAn = true;
                    scbBlRe.BeginAnimation(SolidColorBrush.ColorProperty, caBlRe);
                    App.prot.Add(new Protokoll { prüfschritt = App.alleAS[8].prüfschritt, prüfschrittID = App.alleAS[8].prüfschrittID });
                    blinkglühlLi.Visibility = Visibility.Collapsed;
                    objekt.Text = "Blinker Links aus";
                    el_blLicRe.Fill = scbBlRe;
                }
            }
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

        private void tBl_licht_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            bool oF = false;
            TextBlock objekt = (sender as TextBlock);
            string objName = objekt.Name;

            foreach (var x in App.ohneFunktion)
            {
                if (x.licht == objName)
                {
                    oF = true;
                    break;
                }
            }

            if (!oF)
            {
                if (licht.Text == "Licht an")
                {
                    licht.Text = "Licht aus";
                    rec_licht.Fill = Brushes.Yellow;
                }

                else
                {
                    licht.Text = "Licht an";
                    rec_licht.Fill = null;
                }
            }
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


        private void el_licht_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            stPan_menuLicht.Visibility = Visibility.Visible;
        }
        //Aktionsmenüs öffnen ---- Ende ------
	}
}