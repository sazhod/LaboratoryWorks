using lab5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace lab5
{
    public class Commands
    {
        public static RoutedCommand Undo { get; set; }
        public static RoutedCommand Save { get; set; }
        public static RoutedCommand New { get; set; }
        public static RoutedCommand Find { get; set; }
        public static RoutedCommand Edit { get; set; }
        public static RoutedCommand Delete { get; set; }

        static Commands()
        {
            InputGestureCollection inputGesture = new InputGestureCollection() { new KeyGesture(Key.Z, ModifierKeys.Control, "Ctrl+Z") };
            Undo = new RoutedCommand("Undo", typeof(Commands), inputGesture);

            inputGesture = new InputGestureCollection { new KeyGesture(Key.S, ModifierKeys.Control, "Ctrl+S") };
            Save = new RoutedCommand("Save", typeof(Commands), inputGesture);

            inputGesture = new InputGestureCollection { new KeyGesture(Key.N, ModifierKeys.Control, "Ctrl+N") };
            New = new RoutedCommand("New", typeof(Commands), inputGesture);

            inputGesture = new InputGestureCollection { new KeyGesture(Key.F, ModifierKeys.Control, "Ctrl+F") };
            Find = new RoutedCommand("Find", typeof(Commands), inputGesture);

            inputGesture = new InputGestureCollection { new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+E") };
            Edit = new RoutedCommand("Edit", typeof(Commands), inputGesture);

            inputGesture = new InputGestureCollection { new KeyGesture(Key.D, ModifierKeys.Control, "Ctrl+D") };
            Delete = new RoutedCommand("Delete", typeof(Commands), inputGesture);
        }
    }
}
