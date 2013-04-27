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
            FrontMotorraum fM = new FrontMotorraum();
            fM.ShowDialog();
        }

        //Aktionen -------- Anfang -----------
        private void tBl_blLiAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_blLiDran.Visibility = Visibility.Collapsed;
            rec_blLiDrMenü.Visibility = Visibility.Collapsed;
            img_blLiRaus.Visibility = Visibility.Visible;
            rec_blLiRaMenü.Visibility = Visibility.Visible;
        }

        private void tBl_blLiGlLaOK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tBl_blLiSpPr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tBl_blLiGlLaAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tBl_blLiGlLaEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tBl_blLiBlEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_blLiRaus.Visibility = Visibility.Collapsed;
            rec_blLiRaMenü.Visibility = Visibility.Collapsed;
            img_blLiDran.Visibility = Visibility.Visible;
            rec_blLiDrMenü.Visibility = Visibility.Visible;
        }

        private void tBl_blReAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_blReRaus.Visibility = Visibility.Visible;
            rec_blReRaMenü.Visibility = Visibility.Visible;
            img_blReDran.Visibility = Visibility.Collapsed;
            rec_blReDrMenü.Visibility = Visibility.Collapsed;
        }

        private void tBl_blReGlLaOK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tBl_blReSpPr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tBl_blReGlLaAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tBl_blReGlLaEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void tBl_blReBlEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_blReRaus.Visibility = Visibility.Collapsed;
            rec_blReRaMenü.Visibility = Visibility.Collapsed;
            img_blReDran.Visibility = Visibility.Visible;
            rec_blReDrMenü.Visibility = Visibility.Visible;
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
