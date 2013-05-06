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
    public partial class SeiteFahrzeug : Window
	{
		public SeiteFahrzeug()
		{
			InitializeComponent();
		}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void stPan_menue_MouseEnter(object sender, MouseEventArgs e)
        {
            stPan_menue.Visibility = Visibility.Visible;
        }

        private void stPan_menue_MouseLeave(object sender, MouseEventArgs e)
        {
            stPan_menue.Visibility = Visibility.Collapsed;
        }

        private void rec_motorraum_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[1].prüfschritt, prüfschrittID = App.alleAS[1].prüfschrittID });
            FahrzeugFront faFr = new FahrzeugFront();
            faFr.ShowDialog();
        }

        private void ellipse1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.prot.Add(new Protokoll { prüfschritt = App.alleAS[0].prüfschritt, prüfschrittID = App.alleAS[0].prüfschrittID });
            FahrzeugFahrerraum fF = new FahrzeugFahrerraum();
            fF.ShowDialog();
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string protokoll = "";
            string ASOpt = "";
            foreach (var item in App.prot)
            {
                protokoll += (item.prüfschritt + "\n");
            }
            foreach (var item in App._arbSchritteOptimal)
            {
                ASOpt += (item.prüfschritt + "\n");
            }

            MessageBox.Show("Vorgehen des Spielers: " + "\n" + protokoll + "\n\n" + "Optimales Vorgehen: " + "\n" + ASOpt);
        }
	}
}