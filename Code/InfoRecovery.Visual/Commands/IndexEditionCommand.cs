using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace InfoRecovery.Visual.Commands
{
    public class IndexEditionCommand
    {
        
        private static RoutedUICommand requery;

        public static RoutedUICommand Requery
        {
            get { return requery; }
        }

        static IndexEditionCommand()
        {
            //var inputs = new InputGestureCollection
            //{
            //    new KeyGesture(Key.F5, ModifierKeys.Control, "Ctrl + F5")
            //};

            requery = new RoutedUICommand("Requery", "Requery",
                typeof(IndexEditionCommand), null);
        }
    }
}
