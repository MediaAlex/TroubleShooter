using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Collections.ObjectModel;

namespace TroubleShooter
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public static List<Arbeitsschritte> _arbSchritteBliLi = new List<Arbeitsschritte>();
        public static ObservableCollection<Autoteile> _teileBli = new ObservableCollection<Autoteile>();
        public static ObservableCollection<Situation> _situation = new ObservableCollection<Situation>();
        public static List<Protokoll> prot = new List<Protokoll>();
        //public 
        
        Situation situation = new Situation();
    }
}
