using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace TroubleShooter
{
    
    public class ArbSchrBlinksysOptimal
    {
        public List<IArbeitsschritte> _defBlSch()
        {//0,6,8,10,17,22,23,33,30,36,39,41,42,43,44,06,08,40,37
            Arbeitsschritte schritt = new Arbeitsschritte();
            List<IArbeitsschritte> alle = new List<IArbeitsschritte>();
            alle.Add(App.alleAS[0]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[8]);
            alle.Add(App.alleAS[10]);
            alle.Add(App.alleAS[20]);
            alle.Add(App.alleAS[17]);
            alle.Add(App.alleAS[22]);
            alle.Add(App.alleAS[36]);
            alle.Add(App.alleAS[39]);
            alle.Add(App.alleAS[41]);
            alle.Add(App.alleAS[42]);
            alle.Add(App.alleAS[43]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[8]);
            alle.Add(App.alleAS[44]);
            alle.Add(App.alleAS[40]);
            alle.Add(App.alleAS[37]);

            return alle;
        }

        public List<IArbeitsschritte> _defBat()
        {//0,6,8,10,17,22,23,33,30,36,39,41,42,43,44,06,08,40,37
            Arbeitsschritte schritt = new Arbeitsschritte();
            List<IArbeitsschritte> alle = new List<IArbeitsschritte>();
            alle.Add(App.alleAS[0]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[8]);
            alle.Add(App.alleAS[10]);
            alle.Add(App.alleAS[1]);
            alle.Add(App.alleAS[2]);
            alle.Add(App.alleAS[12]);
            alle.Add(App.alleAS[45]);
            alle.Add(App.alleAS[1]);
            alle.Add(App.alleAS[2]);
            alle.Add(App.alleAS[12]);
            alle.Add(App.alleAS[0]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[8]);
            alle.Add(App.alleAS[10]);

            return alle;
        }
        public List<IArbeitsschritte> _defSich()
        {//0,6,8,10,17,22,23,33,30,36,39,41,42,43,44,06,08,40,37
            Arbeitsschritte schritt = new Arbeitsschritte();
            List<IArbeitsschritte> alle = new List<IArbeitsschritte>();
            alle.Add(App.alleAS[0]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[8]);
            alle.Add(App.alleAS[10]);
            alle.Add(App.alleAS[20]);
            alle.Add(App.alleAS[17]);
            alle.Add(App.alleAS[18]);
            alle.Add(App.alleAS[19]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[8]);

            return alle;
        }
        public List<IArbeitsschritte> _defRel()
        {
            Arbeitsschritte schritt = new Arbeitsschritte();
            List<IArbeitsschritte> alle = new List<IArbeitsschritte>();
            alle.Add(App.alleAS[0]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[8]);
            alle.Add(App.alleAS[10]);
            alle.Add(App.alleAS[20]);
            alle.Add(App.alleAS[17]);
            alle.Add(App.alleAS[22]);
            alle.Add(App.alleAS[23]);
            alle.Add(App.alleAS[24]);
            alle.Add(App.alleAS[25]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[8]);

            return alle;
        }
        public List<IArbeitsschritte> _defGlLampRe()
        {
            Arbeitsschritte schritt = new Arbeitsschritte();
            List<IArbeitsschritte> alle = new List<IArbeitsschritte>();
            alle.Add(App.alleAS[0]);
            alle.Add(App.alleAS[8]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[1]);
            alle.Add(App.alleAS[26]);
            alle.Add(App.alleAS[30]);
            alle.Add(App.alleAS[31]);
            alle.Add(App.alleAS[32]);
            alle.Add(App.alleAS[27]);
            alle.Add(App.alleAS[0]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[8]);

            return alle;
        }
        public List<IArbeitsschritte> _defGlLampLi()
        {
            Arbeitsschritte schritt = new Arbeitsschritte();
            List<IArbeitsschritte> alle = new List<IArbeitsschritte>();
            alle.Add(App.alleAS[0]);
            alle.Add(App.alleAS[8]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[1]);
            alle.Add(App.alleAS[28]);
            alle.Add(App.alleAS[33]);
            alle.Add(App.alleAS[34]);
            alle.Add(App.alleAS[35]);
            alle.Add(App.alleAS[29]);
            alle.Add(App.alleAS[0]);
            alle.Add(App.alleAS[6]);
            alle.Add(App.alleAS[8]);

            return alle;
        }
    }
}
