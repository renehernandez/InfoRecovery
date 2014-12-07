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
using System.Windows.Navigation;
using System.Windows.Shapes;
using InfoRecovery.Core;
using Microsoft.Win32;
using InfoRecovery.Visual.Commands;
using Ookii.Dialogs.Wpf;
using InfoRecovery.Visual.Windows;
using System.Diagnostics;
using Xceed.Wpf.Toolkit;

namespace InfoRecovery.Visual
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            SetBindings();
            InitializeStructure();
        }

        public void InitializeStructure()
        {
            InfoRecoveryManager.BuildConfigurations();
            InfoRecoveryManager.CreateJson();
        }

        public void SetBindings()
        {
            var binding = new CommandBinding(ApplicationCommands.Open);
            binding.Executed += OpenFolderHandler;
            CommandBindings.Add(binding);

            binding = new CommandBinding(FindCommand.Requery);
            binding.Executed += FindHandler;
            CommandBindings.Add(binding);

            binding = new CommandBinding(EditCommand.Requery);
            binding.Executed += EditHandler;
            CommandBindings.Add(binding);

        }

        private void OpenFolderHandler(object sender, RoutedEventArgs e)
        {
             var dialog = new VistaFolderBrowserDialog();
            //dialog.Filter = "Diffuse File (*.dfl)|*.dfl|Show All Files (*.*)|*.*";
            dialog.Description = "Open Folder";
            if ((bool)dialog.ShowDialog())
            {
                var path = dialog.SelectedPath;
                var mod = InfoRecoveryManager.ModuleElements.First(m => m.Name == "Model");
                Process.Start(mod.Path);
            }

        }

        private void FindHandler(object sender, RoutedEventArgs e)
        {
            
        }

        private void EditHandler(object sender, RoutedEventArgs e)
        {
            var window = new Configuration();
            if ((bool)window.ShowDialog())
            {

            }
        }

    }
}
