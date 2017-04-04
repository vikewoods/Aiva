﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlackBoxBot.Views {
	/// <summary>
	/// Interaktionslogik für ucSettings.xaml
	/// </summary>
	public partial class SettingsView : MahApps.Metro.Controls.MetroContentControl {
		public SettingsView() {
            this.DataContext = new ViewModels.SettingsViewModel();
			InitializeComponent();
			cbLanguage.Items.Add("german");
		}
	}
}
