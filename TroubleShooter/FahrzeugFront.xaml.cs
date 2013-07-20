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

namespace TroubleShooter
{
    /// <summary>
    /// Interaktionslogik für FahrzeugFront.xaml
    /// </summary>
    public partial class FahrzeugFront : Window
    {
        public FahrzeugFront()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string a in App.collapsImgs)
            {
                try
                {
                    Image img = gr_oberfl.FindName(a) as Image;
                    img.Visibility = Visibility.Collapsed;

                    if (img.Name == "img_blLiDran")
                        img_blLiRaus.Visibility = Visibility.Visible;
                    if (img.Name == "img_blReDran")
                        img_blReRaus.Visibility = Visibility.Visible;
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

        private void ZumMotorraum(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[2].prüfschritt, prüfschrittID = App.alleAS[2].prüfschrittID });
            FrontMotorraum fM = new FrontMotorraum();
            fM.ShowDialog();
        }

        //Aktionen -------- Anfang -----------
        private void tBl_blLiAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[28].prüfschritt, prüfschrittID = App.alleAS[28].prüfschrittID });
            img_blLiDran.Visibility = Visibility.Collapsed;
            App.collapsImgs.Add(img_blLiDran.Name);

            rec_blLiDrMenü.Visibility = Visibility.Collapsed;
            img_blLiRaus.Visibility = Visibility.Visible;
            rec_blLiRaMenü.Visibility = Visibility.Visible;
        }

        private void tBl_blLiGlLaOK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[33].prüfschritt, prüfschrittID = App.alleAS[33].prüfschrittID });
            if (App.ohneFunktion[0].def == "blinkglühlLi")
                MessageBox.Show("Der Glühdraht scheint durchgeschmort zu sein.");
            else
                MessageBox.Show("Die Glühlampe scheint in Ordnung zu sein.");
        }

        private void tBl_blLiSpPr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (App.ohneFunktion[0].gbLi == "blinkglühlLi")
                MessageBox.Show("4V");
            else
                MessageBox.Show("12,4V");
        }

        private void tBl_blLiGlLaAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[34].prüfschritt, prüfschrittID = App.alleAS[34].prüfschrittID });
            tBl_blReGlLaEinb.Visibility = Visibility.Visible;
            tBl_blReGlLaAusb.Visibility = Visibility.Collapsed;

            App.collapsTBls.Add(tBl_blReGlLaAusb);
            App.collapsTBls.Remove(tBl_blReGlLaEinb);
            App.visTBls.Add(tBl_blReGlLaEinb);
        }

        private void tBl_blLiGlLaEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[35].prüfschritt, prüfschrittID = App.alleAS[35].prüfschrittID });
            if (App.ohneFunktion[0].def == "blinkglühlLi")
                App.ohneFunktion.RemoveAt(0);
            tBl_blReGlLaEinb.Visibility = Visibility.Collapsed;
            tBl_blReGlLaAusb.Visibility = Visibility.Visible;

            App.collapsTBls.Add(tBl_blReGlLaEinb);
            App.collapsTBls.Remove(tBl_blReGlLaAusb);
            App.visTBls.Remove(tBl_blReGlLaEinb);

        }

        private void tBl_blLiBlEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[29].prüfschritt, prüfschrittID = App.alleAS[29].prüfschrittID });
            img_blLiRaus.Visibility = Visibility.Collapsed;
            rec_blLiRaMenü.Visibility = Visibility.Collapsed;
            img_blLiDran.Visibility = Visibility.Visible;
            rec_blLiDrMenü.Visibility = Visibility.Visible;
            App.collapsImgs.Remove(img_blLiDran.Name);
        }

        private void tBl_blReAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[26].prüfschritt, prüfschrittID = App.alleAS[26].prüfschrittID });
            img_blReRaus.Visibility = Visibility.Visible;
            rec_blReRaMenü.Visibility = Visibility.Visible;
            img_blReDran.Visibility = Visibility.Collapsed;
            rec_blReDrMenü.Visibility = Visibility.Collapsed;
            App.collapsImgs.Add(img_blReDran.Name);
        }

        private void tBl_blReGlLaOK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[30].prüfschritt, prüfschrittID = App.alleAS[30].prüfschrittID });
            if (App.ohneFunktion[0].def == "blinkglühlRe")
                MessageBox.Show("Der Glühdraht scheint durchgeschmort zu sein.");
            else
                MessageBox.Show("Die Glühlampe scheint in Ordnung zu sein.");
        }

        private void tBl_blReSpPr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (App.ohneFunktion[0].gbLi == "blinkglühlRe")
                MessageBox.Show("4V");
            else
                MessageBox.Show("12,4V");
        }

        private void tBl_blReGlLaAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[31].prüfschritt, prüfschrittID = App.alleAS[31].prüfschrittID });
            tBl_blReGlLaEinb.Visibility = Visibility.Visible;
            tBl_blReGlLaAusb.Visibility = Visibility.Collapsed;

            App.collapsTBls.Add(tBl_blReGlLaAusb);
            App.collapsTBls.Remove(tBl_blReGlLaEinb);
            App.visTBls.Add(tBl_blReGlLaEinb);
        }

        private void tBl_blReGlLaEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[32].prüfschritt, prüfschrittID = App.alleAS[32].prüfschrittID });
            if (App.ohneFunktion[0].def == "blinkglühlRe")
                App.ohneFunktion.RemoveAt(0);
            tBl_blReGlLaEinb.Visibility = Visibility.Collapsed;
            tBl_blReGlLaAusb.Visibility = Visibility.Visible;

            App.collapsTBls.Add(tBl_blReGlLaEinb);
            App.collapsTBls.Remove(tBl_blReGlLaAusb);
            App.visTBls.Remove(tBl_blReGlLaEinb);
        }

        private void tBl_blReBlEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[27].prüfschritt, prüfschrittID = App.alleAS[27].prüfschrittID });
            img_blReRaus.Visibility = Visibility.Collapsed;
            rec_blReRaMenü.Visibility = Visibility.Collapsed;
            img_blReDran.Visibility = Visibility.Visible;
            rec_blReDrMenü.Visibility = Visibility.Visible;
            App.collapsImgs.Remove(img_blReDran.Name);
        }
        //Aktionen -------- Ende -----------

        //Aktionsmenüs öffnen ---- Anfang ------

        private void visibCol_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as StackPanel).Visibility = Visibility.Collapsed;
        }

        private void BlinkerRechtsRausMenü(object sender, MouseButtonEventArgs e)
        {
            stPan_menuBlinkerRechtsAus.Visibility = Visibility.Visible;
        }

        private void BlinkerRechtsDranMenü(object sender, MouseButtonEventArgs e)
        {
            stPan_menuBlinkerRechts.Visibility = Visibility.Visible;
        }

        private void BlinkerlinksRausMenü(object sender, MouseButtonEventArgs e)
        {
            stPan_menuBlinkerLinksAus.Visibility = Visibility.Visible;
        }

        private void BlinkerlinksDranMenü(object sender, MouseButtonEventArgs e)
        {
            stPan_menuBlinkerLinks.Visibility = Visibility.Visible;
        }
        //Aktionsmenüs öffnen ---- Ende ------

        private void ZurSeiteFahrzeug(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

    }
}
