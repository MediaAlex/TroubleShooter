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
using System.Linq;

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
            List<string> prot = new List<string>();
            List<string> optArbSchr = new List<string>();

            foreach (var item in App.prot)
            {
                protokoll += (item.prüfschritt + "\n");
                prot.Add(item.prüfschritt);
            }
            foreach (var item in App._arbSchritteOptimal)
            {
                ASOpt += (item.prüfschritt + "\n");
                optArbSchr.Add(item.prüfschritt);
            }

            MessageBox.Show("Vorgehen des Spielers: " + "\n" + protokoll + "\n\n" + "Optimales Vorgehen: " + "\n" + ASOpt);

            var objs = (from a in prot from b in optArbSchr where a.CompareTo(b) == 0 select new { a, b }).Distinct();

            string ausgabe = "";
            foreach (var obj in objs)
            {
                ausgabe += (obj.a + " = " + obj.b + "\n");
            }
            MessageBox.Show(ausgabe);
        }

        private void image_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(App._situation[0].textAuftrag);
        }

        private void menschen_biz_mannlich_smile_clip_art_425060_jpg_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.nav.Add("werkstatt");
            App.currentDialog = "1";

            Servicetechniker st2 = new Servicetechniker();
            st2.ShowDialog();
            //st.InitializeComponent();
            //st.Window_Loaded(st, e);
            this.Close();
        }
	}
}