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
            binding.Executed += RunHandler;
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
            }

        }

        private void RunHandler(object sender, RoutedEventArgs e)
        {

        }

        private void EditHandler(object sender, RoutedEventArgs e)
        {

        }

    }
}
