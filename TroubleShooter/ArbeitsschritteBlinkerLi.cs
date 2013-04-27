using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace TroubleShooter
{
    public class ArbeitsschritteBlinkerLi
    {
        public List<Arbeitsschritte> _ASBlLi()
        {//0,6,8,10,17,22,23,33,30,36,39,41,42,43,44,06,08,40,37
            Arbeitsschritte schritt = new Arbeitsschritte();
            List<Arbeitsschritte> alle = new List<Arbeitsschritte>();
            alle.Add(schritt.zuPrüfen()[0]);
            alle.Add(schritt.zuPrüfen()[6]);
            alle.Add(schritt.zuPrüfen()[8]);
            alle.Add(schritt.zuPrüfen()[10]);
            alle.Add(schritt.zuPrüfen()[17]);
            alle.Add(schritt.zuPrüfen()[22]);
            alle.Add(schritt.zuPrüfen()[23]);
            alle.Add(schritt.zuPrüfen()[33]);
            alle.Add(schritt.zuPrüfen()[30]);
            alle.Add(schritt.zuPrüfen()[36]);
            alle.Add(schritt.zuPrüfen()[39]);
            alle.Add(schritt.zuPrüfen()[41]);
            alle.Add(schritt.zuPrüfen()[42]);
            alle.Add(schritt.zuPrüfen()[43]);
            alle.Add(schritt.zuPrüfen()[44]);
            alle.Add(schritt.zuPrüfen()[6]);
            alle.Add(schritt.zuPrüfen()[8]);
            alle.Add(schritt.zuPrüfen()[40]);
            alle.Add(schritt.zuPrüfen()[37]);

            return alle;
        }
    }
}
