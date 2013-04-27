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

        }

        private void tBl_batKabAbkl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_kab.Visibility = Visibility.Collapsed;
        }

        private void tBl_batAusb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_batt.Visibility = Visibility.Collapsed;
        }

        private void tBl_batKabAnkl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_kab.Visibility = Visibility.Visible;
        }

        private void tBl_batEinb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_batt.Visibility = Visibility.Visible;
        }
	}
}