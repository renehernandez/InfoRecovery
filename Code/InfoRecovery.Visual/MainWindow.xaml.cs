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
using InfoRecovery.Core.JsonActions;
using Microsoft.Win32;
using InfoRecovery.Visual.Commands;
using Ookii.Dialogs.Wpf;
using InfoRecovery.Visual.Windows;
using System.Diagnostics;
using Xceed.Wpf.Toolkit;
using InfoRecovery.Visual.ViewModels;

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
            SetViewModels();
            InitializeStructure();
        }

        public void InitializeStructure()
        {
            InfoRecoveryManager.BuildConfigurations();
            InfoRecoveryManager.CreateJson();
        }

        public void SetViewModels()
        {
            //config = new ConfigurationViewModel(){
            //    ModelPath = InfoRecoveryManager.ModuleElements.First(mod => mod.Name == "Model").Path,
            //    IndexPath = InfoRecoveryManager.ModuleElements.First(mod => mod.Name == "Index").Path,
            //};
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

            dialog.Description = "Open Folder";
            if ((bool)dialog.ShowDialog())
            {
                var build = new ModelAction() { Action = "build", Path = dialog.SelectedPath };
                var config = InfoRecoveryManager.InfoConfig;
                string path = string.Format("{0}\\{1}.json", config.JsonElement.Path, config.JsonElement.Name);
                
                JsonHelper.WriteJson(build, path);
                
                var mod = InfoRecoveryManager.ModuleElements.First(m => m.Name == "Model");
                var info = new ProcessStartInfo(mod.Path);
                info.UseShellExecute = false;
                info.CreateNoWindow = true;
                var args = new StringBuilder(path);
                args.Append(string.Format(" {0}", InfoRecoveryManager.ModuleElements.First(m => m.Name == "Text").Path));
                args.Append(string.Format(" {0}", InfoRecoveryManager.ModuleElements.First(m => m.Name == "Index").Path));
                info.Arguments = args.ToString();

                var process = Process.Start(info);
                process.WaitForExit();
            }

        }

        private void FindHandler(object sender, RoutedEventArgs e)
        {
            
        }

        private void EditHandler(object sender, RoutedEventArgs e)
        {
            new Configuration().ShowDialog();
        }

    }
}
