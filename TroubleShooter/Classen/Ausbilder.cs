using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Windows;

namespace TroubleShooter
{
    class Ausbilder
    {
        public string name { get; set; }
        public string passwort { get; set; }
        public string[] gruppe { get; set; }
        public bool berechtigt = false;
        public string anmeldung;

        List<Ausbilder> ausbilderDaten = new List<Ausbilder>();

        private List<Ausbilder> inhalteLaden()
        {
            List<Ausbilder> lst = new List<Ausbilder>();
            try
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Ausbilder>));
                TextReader trd = new StreamReader("Benutzerkonten.xml");
                lst = (List<Ausbilder>)xmlser.Deserialize(trd);
                trd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return lst;
        }

        public void AnmeldungPruefen(string user, string passw)
        {
            ausbilderDaten = inhalteLaden();
            if (name == user && passwort == passw)
            {
                berechtigt = true;
                anmeldung = "Anmeldung erfolgreich";
                berechtigt = true;
            }
            else
                anmeldung = "Benutzername und/oder Passwort falsch";
        }
    }
}
