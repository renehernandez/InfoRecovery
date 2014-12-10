using InfoRecovery.Core;
using InfoRecovery.Visual.Commands;
using InfoRecovery.Visual.ViewModels;
using Microsoft.Win32;
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

namespace InfoRecovery.Visual.Windows
{
    /// <summary>
    /// Interaction logic for Configuration.xaml
    /// </summary>
    public partial class Configuration : Window
    {

        ConfigurationViewModel config;

        public Configuration()
        {
            InitializeComponent();
            SetBindings();
            SetViewModels();
        }

        public void SetBindings()
        {
            var binding = new CommandBinding(ModelEditionCommand.Requery);
            binding.Executed += OpenModelHandler;
            CommandBindings.Add(binding);

            binding = new CommandBinding(IndexEditionCommand.Requery);
            binding.Executed += OpenIndexHandler;
            CommandBindings.Add(binding);

            binding = new CommandBinding(ApplicationCommands.Save);
            binding.Executed += SaveHandler;
            CommandBindings.Add(binding);

            binding = new CommandBinding(ApplicationCommands.Close);
            binding.Executed += CloseHandler;
            CommandBindings.Add(binding);


        }

        public void SetViewModels()
        {
            config = new ConfigurationViewModel()
            {
                ModelPath = InfoRecoveryManager.ModuleElements.First(mod => mod.Name == "Model").Path,
                IndexPath = InfoRecoveryManager.ModuleElements.First(mod => mod.Name == "Index").Path,
            };

            this.DataContext = config;
        }

        private void OpenModelHandler(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                Title = "Select new Model Module",
                Filter = "EXE File (*.exe)|*.exe"
            };
            if ((bool)dialog.ShowDialog())
            {
                tboxModelEdition.Text = dialog.FileName;
            }
        }

        private void OpenIndexHandler(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() 
            {
                Title = "Select new Index Module",
                Filter = "EXE File (*.exe)|*.exe"
            };
            if ((bool)dialog.ShowDialog())
            {
                tboxIndexEdition.Text = dialog.FileName;
            }
        }

        private void SaveHandler(object sender, RoutedEventArgs e)
        {
            var modelModule = InfoRecoveryManager.ModuleElements.First(mod => mod.Name == "Model");
            modelModule.Path = config.ModelPath;
            var indexModule = InfoRecoveryManager.ModuleElements.First(mod => mod.Name == "Index");
            indexModule.Path = config.IndexPath;
            this.Close();
        }

        private void CloseHandler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
