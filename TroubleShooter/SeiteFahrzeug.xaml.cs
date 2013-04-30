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
            FahrzeugFront faFr = new FahrzeugFront();
            faFr.ShowDialog();
        }

        private void ellipse1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FahrzeugFahrerraum fF = new FahrzeugFahrerraum();
            fF.ShowDialog();
        }
	}
}