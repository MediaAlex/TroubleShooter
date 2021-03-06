﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace TroubleShooter
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        //Defekt, Arbeitsschritte, Auftrrag, Protokoll
        public static List<IArbeitsschritte> _arbSchritteOptimal = new List<IArbeitsschritte>();
        public static ObservableCollection<Autoteile> _autoTeile = new ObservableCollection<Autoteile>();
        public static ObservableCollection<Situation> _situation = new ObservableCollection<Situation>();
        public static List<Abhängigkeit> ohneFunktion = new List<Abhängigkeit>();
        public static List<Protokoll> prot = new List<Protokoll>();
        public static List<IArbeitsschritte> alleAS = Arbeitsschritte.zuPrüfen(); //new List<Arbeitsschritte>();

        public static List<Abhängigkeit> abhängigkeiten = new List<Abhängigkeit>();
        public static List<string> collapsImgs;
        public static List<TextBlock> visTBls;
        public static List<TextBlock> collapsTBls;
        public static List<string> nav = new List<string>();

        public static String currentDialog = "";

        //Inferenzmaschine
        //public static List<String> _zutaten = new List<string>();
        //public static List<string> _geraete = new List<string>();
        //public static List<Fakt> _fakten = new List<Fakt>();
        //public static List<IRegel> _ziele = new List<IRegel>();
        
        //Start der Anwendung
        public void Application_Startup(object sender, StartupEventArgs e)
        {

        }
    }
}
