using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
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
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DisplayLoginScreen()
        {
            //Login frm = new Login();

            //frm.Owner = this;
            //frm.ShowDialog();
            //if (frm.DialogResult.HasValue && frm.DialogResult.Value)
            //    MessageBox.Show("User Logged In");
            //else
            //    this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _setArbeitsschritte();
        }

        private void _setArbeitsschritte()
        {
            _blinkerLinks();
        }

        private void _blinkerLinks()
        {
            Arbeitsschritte alleArbeitsschritte = new Arbeitsschritte();
        }

        Ausbilder ausbilder = new Ausbilder();
        Gruppe gruppe = new Gruppe();

        private void but_anmelden_Click(object sender, RoutedEventArgs e)
        {
            if (tb_name.Text.Length == 0)
            {
                error.Text = "Bitte Nutzernamen eingeben.";
                tb_name.Focus();
            }
            else if (tb_passwort.Text.Length == 0)
            {
                error.Text = "Bitte Passwort eingeben.";
                tb_passwort.Focus();
            }
            else
            {
                string name = tb_name.Text;
                string password = tb_passwort.Text;

                ausführen(name, password);
                if (ausbilder.berechtigt)
                {
                    popU_login.IsOpen = false;
                    popU_gruppenWahl.IsOpen = true;
                }
                else
                    error.Text = "Benutzername oder Passwort falsch";
            }
        }

        public void ausführen(string n, string p)
        {
            ausbilder.AnmeldungPruefen(n, p);
            error.Text = ausbilder.anmeldung;
        }

        private void but_gruppWahl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            gruppe.gruppe = cB_gruppe.SelectedItem.ToString();
            popU_gruppenWahl.IsOpen = false;
        }

        private void but_weiter_Click(object sender, RoutedEventArgs e)
        {
            Profil profil = new Profil();
            profil.ShowDialog();
        }
    }
}
