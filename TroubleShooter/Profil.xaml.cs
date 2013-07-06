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
	public partial class Profil
	{
		public Profil()
		{
			this.InitializeComponent();

			// Fügen Sie Code, der bei der Objekterstellung erforderlich ist, unter diesem Punkt ein.
		}

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            App.nav.Add("profil");
            Servicetechniker sT = new Servicetechniker();
            sT.ShowDialog();
        }
	}
}