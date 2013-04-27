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
using System.Xml.Serialization;
using System.IO;

namespace TroubleShooter
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        Ausbilder ausbilder = new Ausbilder();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

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
    }
}

