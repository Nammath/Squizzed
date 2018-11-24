using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Squizzed
{
    public class Commands
    {
        public static RoutedUICommand PreviousQuestion = new RoutedUICommand("Load previous question", "PreviousQuestion", typeof(Commands));
        public static RoutedUICommand PlayButton = new RoutedUICommand("Play the game", "Play", typeof(Commands));
        public static RoutedUICommand AddCard = new RoutedUICommand("Add card", "Add", typeof(Commands));
        public static RoutedUICommand EditCard = new RoutedUICommand("Edit card", "Edit", typeof(Commands));
        public static RoutedUICommand DeleteCard = new RoutedUICommand("Delete card", "Delete", typeof(Commands));
    }
}
