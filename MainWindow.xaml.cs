using System;
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

namespace DiscordSpoilerMessageV3
{
    // Interaction logic for MainWindow.xaml
    
    public partial class MainWindow : Window
    {
        public static TextBox LogBox;

        public static void AddToLogBox(string input)
        {
            string time = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            LogBox.Text += time + " > " + input + "\r\n";
            LogBox.ScrollToEnd();
        }

        public MainWindow()
        {
            InitializeComponent();
            LogBox = logBox; // This needs to be here so that LogBox gets the reference to the instance that we want.
        }

        private void InputBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(OutputBox == null) return;
            OutputBox.Text = Spoilerinator.Spoil(InputBox.Text);
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Spoilerinator.Spoil(InputBox.Text));
            AddToLogBox($"Copied text {Spoilerinator.Spoil(InputBox.Text)} to clipboard.");
        }
    }
}
