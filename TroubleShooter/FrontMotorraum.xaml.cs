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
	public partial class FrontMotorraum
	{
		public FrontMotorraum()
		{
			this.InitializeComponent();

			// Fügen Sie Code, der bei der Objekterstellung erforderlich ist, unter diesem Punkt ein.
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
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
        }

        private void stPan_menue_MouseEnter(object sender, MouseEventArgs e)
        {
            stPan_menue.Visibility = Visibility.Visible;
        }

        private void stPan_menue_MouseLeave(object sender, MouseEventArgs e)
        {
            stPan_menue.Visibility = Visibility.Collapsed;
        }

        private void ZurFahrzeugFront(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        //Aktions-Menüs auf
        private void img_batt_menu(object sender, MouseButtonEventArgs e)
        {
            stPan_menuBatEing.Visibility = Visibility.Visible;
        }

        private void img_kab_menü(object sender, MouseButtonEventArgs e)
        {
            stPan_menuKab.Visibility = Visibility.Visible;
        }

        private void rec_batEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            stPan_menuBatAusg.Visibility = Visibility.Visible;
        }

        private void visibCol_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as StackPanel).Visibility = Visibility.Collapsed;
        }

        //Aktionen
        private void tBl_batSpanPr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[12].prüfschritt, prüfschrittID = App.alleAS[12].prüfschrittID });
            if (App.ohneFunktion[0].def == "bat")
                MessageBox.Show("5V");
            else
                MessageBox.Show("12,4V");
        }

        private void tBl_batKabAbkl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[13].prüfschritt, prüfschrittID = App.alleAS[13].prüfschrittID });
            img_kab.Visibility = Visibility.Collapsed;
            App.collapsImgs.Add(img_kab.Name);
        }

        private void tBl_batAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[15].prüfschritt, prüfschrittID = App.alleAS[15].prüfschrittID });
            img_batt.Visibility = Visibility.Collapsed;
            App.collapsImgs.Add(img_batt.Name);
        }

        private void tBl_batKabAnkl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[14].prüfschritt, prüfschrittID = App.alleAS[14].prüfschrittID });
            img_kab.Visibility = Visibility.Visible;
            App.collapsImgs.Remove(img_kab.Name);
        }

        private void tBl_batEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[16].prüfschritt, prüfschrittID = App.alleAS[16].prüfschrittID });
            img_batt.Visibility = Visibility.Visible;
            App.collapsImgs.Remove(img_batt.Name);
            foreach (var item in App.ohneFunktion)
            {
                if (item.def == "bat")
                {
                    App.ohneFunktion.RemoveAt(0);
                }
            }
        }
	}
}