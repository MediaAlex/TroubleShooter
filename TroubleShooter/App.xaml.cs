﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace TroubleShooter
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public static List<Arbeitsschritte> _arbSchritteBliLi = new List<Arbeitsschritte>();
        
        Situation situation = new Situation();
    }
}
