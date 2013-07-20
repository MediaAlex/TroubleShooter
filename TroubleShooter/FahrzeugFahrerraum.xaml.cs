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

            foreach (string img in App.collapsImgs)
            {
                try
                {
                    Image a = gr_oberfl.FindName(img) as Image;
                    a.Visibility = Visibility.Collapsed;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            foreach (TextBlock tbl in App.collapsTBls)
            {
                string a = tbl.GetValue(TextBlock.NameProperty).ToString();
                (gr_oberfl.FindName(a) as TextBlock).Visibility = Visibility.Collapsed;
            }

            foreach (TextBlock tbl in App.visTBls)
            {
                string a = tbl.GetValue(TextBlock.NameProperty).ToString();
                (gr_oberfl.FindName(a) as TextBlock).Visibility = Visibility.Visible;
            }
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
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[36].prüfschritt, prüfschrittID = App.alleAS[36].prüfschrittID });
            img_hupe.Visibility = Visibility.Collapsed;
            App.collapsImgs.Add(img_hupe.Name);
            //MessageBox.Show(App.collapsImgs.Count + "images ausbau");

            tBl_lenkrHupeEinb.Visibility = Visibility.Visible;
            App.collapsTBls.Remove(tBl_lenkrHupeEinb);
            App.visTBls.Add(tBl_lenkrHupeEinb);
        }

        private void tBl_sichRelRein_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[20].prüfschritt, prüfschrittID = App.alleAS[20].prüfschrittID });
            img_sichRel.Visibility = Visibility.Visible;
            but_imgSichRelClose.Visibility = Visibility.Visible;
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
            App.collapsImgs.Add(img_lenkr.Name);
            tBl_lenkrEinb.Visibility = Visibility.Visible;
            //MessageBox.Show(App.collapsImgs.Count + "images ausbau");
            tBl_blAusb.Visibility = Visibility.Visible;
            App.collapsTBls.Remove(tBl_lenkrEinb);
            App.collapsTBls.Remove(tBl_blAusb);
            App.visTBls.Add(tBl_lenkrEinb);
            App.visTBls.Add(tBl_blAusb);
        }

        private void tBl_hupEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[37].prüfschritt, prüfschrittID = App.alleAS[37].prüfschrittID });
            img_hupe.Visibility = Visibility.Visible;
            App.collapsImgs.Remove(img_hupe.Name);
            //MessageBox.Show(App.collapsImgs.Count + "images Hup einbau");

            tBl_lenkrHupeEinb.Visibility = Visibility.Collapsed;
            tBl_blAusb.Visibility = Visibility.Collapsed;
            App.collapsTBls.Add(tBl_lenkrHupeEinb);
            App.collapsTBls.Add(tBl_blAusb);
            App.visTBls.Remove(tBl_lenkrHupeEinb);
            App.visTBls.Remove(tBl_blAusb);
        }

        private void blinkglühlLi_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            bool oF = false;
            TextBlock objekt = (sender as TextBlock);
            string objName = objekt.Name;

            foreach (Abhängigkeit x in App.ohneFunktion)
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
            bool ohneFunkt = false;
            TextBlock objekt = (sender as TextBlock);
            string objName = objekt.Name;

            foreach (var x in App.ohneFunktion)
                if (x.gbRe == objName)
                {
                    ohneFunkt = true;
                    break;
                }

            if (!ohneFunkt)
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
            App.collapsImgs.Add(img_blSchW.Name);
        }

        private void tBl_eingPruf_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[41].prüfschritt, prüfschrittID = App.alleAS[41].prüfschrittID });
            if (App.ohneFunktion[0].schal == "blinkSch")
                MessageBox.Show("4V");
            else
                MessageBox.Show("12,4V");
        }

        private void tBl_ausgPruf_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[42].prüfschritt, prüfschrittID = App.alleAS[42].prüfschrittID });
            if (App.ohneFunktion[0].def == "blinkSch")
                MessageBox.Show("0V");
            else
            {
                if (App.ohneFunktion[0].schal == "blinkSch")
                    MessageBox.Show("4V");
                else
                    MessageBox.Show("12,4V");
            }
        }

        private void tBl_lenkrEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[40].prüfschritt, prüfschrittID = App.alleAS[40].prüfschrittID });
            img_lenkr.Visibility = Visibility.Visible;
            //MessageBox.Show(App.collapsImgs.Count + "images einbau");
            tBl_lenkrEinb.Visibility = Visibility.Collapsed;
            try
            {
              App.collapsImgs.Remove(img_lenkr.Name);

            }
            catch (Exception)
            {
                
                throw;
            }
            App.collapsTBls.Add(tBl_lenkrEinb);
            App.visTBls.Remove(tBl_lenkrEinb);
            //MessageBox.Show(App.collapsImgs.Count + "images einbau");
        }

        private void tBl_blEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[44].prüfschritt, prüfschrittID = App.alleAS[44].prüfschrittID });
            img_blSchW.Visibility = Visibility.Visible;

            if (App.ohneFunktion[0].def == "blinkSch")
                App.ohneFunktion.RemoveAt(0);

            App.collapsImgs.Remove(img_blSchW.Name);
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
            stPan_menuBlinker.Visibility = Visibility.Visible;
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

        private void but_imgSichRelClose_Click(object sender, RoutedEventArgs e)
        {
            but_imgSichRelClose.Visibility = Visibility.Collapsed;
            img_sichRel.Visibility = Visibility.Collapsed;
        }

        private void tBl_siPr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[17].prüfschritt, prüfschrittID = App.alleAS[17].prüfschrittID });
            if (App.ohneFunktion[0].def == "sichBlink")
                MessageBox.Show("Sicherung defekt");
            else
                MessageBox.Show("Sicherung in Ordnung");
        }

        private void tBl_sichAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[18].prüfschritt, prüfschrittID = App.alleAS[18].prüfschrittID });
            rec_sichBl.SetValue(Rectangle.FillProperty, new Color() { A = 255, R = 232, G = 231, B = 237 });
            tBl_siAusb.Visibility = Visibility.Collapsed;
            tBl_siPr.Visibility = Visibility.Collapsed;
            tBl_siEinb.Visibility = Visibility.Visible;
            App.collapsTBls.Add(tBl_siAusb);
            App.collapsTBls.Add(tBl_siPr);
            App.collapsTBls.Remove(tBl_siEinb);
        }

        private void tBl_sichEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[19].prüfschritt, prüfschrittID = App.alleAS[19].prüfschrittID });
            rec_sichBl.SetValue(Rectangle.FillProperty, new Color() { A = 0, R = 232, G = 231, B = 237 });
            if (App.ohneFunktion[0].def == "sichBlink")
                App.ohneFunktion.RemoveAt(0);
            tBl_siAusb.Visibility = Visibility.Visible;
            tBl_siPr.Visibility = Visibility.Visible;
            tBl_siEinb.Visibility = Visibility.Collapsed;
            App.collapsTBls.Remove(tBl_siAusb);
            App.collapsTBls.Remove(tBl_siPr);
            App.collapsTBls.Add(tBl_siEinb);
        }

        private void tBl_RelEingPrüf_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[23].prüfschritt, prüfschrittID = App.alleAS[23].prüfschrittID });
            if (App.ohneFunktion[0].re == "blinkRel")
                MessageBox.Show("0V");
            else
            {
                if (blAn)
                    MessageBox.Show("12,4V");
                else
                    MessageBox.Show("0V");
            }
        }

        private void tBl_relAusgPrüf_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[22].prüfschritt, prüfschrittID = App.alleAS[22].prüfschrittID });
            if (App.ohneFunktion[0].def == "blinkRel")
                MessageBox.Show("0V");
            else if (App.ohneFunktion[0].re == "blinkRel")
                MessageBox.Show("0V");
            else
            {
                if (blAn)
                    MessageBox.Show("12,4V");
                else
                    MessageBox.Show("0V");
            }
        }

        private void tBl_relAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[24].prüfschritt, prüfschrittID = App.alleAS[24].prüfschrittID });
            rec_sichBl.SetValue(Rectangle.FillProperty, new Color() { A = 255, R = 232, G = 231, B = 237 });
            tBl_relEinb.Visibility = Visibility.Visible;
            tBl_relAusb.Visibility = Visibility.Collapsed;
            tBl_relEingPrüf.Visibility = Visibility.Collapsed;
            tBl_relAusgPrüf.Visibility = Visibility.Collapsed;
            App.collapsTBls.Add(tBl_relAusb);
            App.collapsTBls.Add(tBl_relEingPrüf);
            App.collapsTBls.Add(tBl_relAusgPrüf);
            App.collapsTBls.Remove(tBl_siEinb);
        }

        private void tBl_relEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[25].prüfschritt, prüfschrittID = App.alleAS[25].prüfschrittID });
            rec_sichBl.SetValue(Rectangle.FillProperty, new Color() { A = 0, R = 232, G = 231, B = 237 });
            tBl_relEinb.Visibility = Visibility.Collapsed;
            tBl_relAusb.Visibility = Visibility.Visible;
            tBl_relEingPrüf.Visibility = Visibility.Visible;
            tBl_relAusgPrüf.Visibility = Visibility.Visible;
            if (App.ohneFunktion[0].def == "blinkRel")
                App.ohneFunktion.RemoveAt(0);
            App.collapsTBls.Remove(tBl_relAusb);
            App.collapsTBls.Remove(tBl_relEingPrüf);
            App.collapsTBls.Remove(tBl_relAusgPrüf);
            App.collapsTBls.Add(tBl_relEinb);
        }

        private void rec_sichBl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            stPan_menuSich.Visibility = Visibility.Visible;
        }

        private void rec_relBl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            stPan_menuRel.Visibility = Visibility.Visible;
        }

        //Aktionsmenüs öffnen ---- Ende ------
	}
}