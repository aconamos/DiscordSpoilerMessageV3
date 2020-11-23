using System;
using System.Collections.Generic;
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

namespace DiscordSpoilerMessageV3
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class HistoryTile : UserControl
    {
        public readonly Spoilerinator spoilerinator = new Spoilerinator();

        public HistoryTile()
        {
            InitializeComponent();
        }

        private void InputBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OutputBox == null) return;
            OutputBox.Text = Spoilerinator.Spoil(InputBox.Text);
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Spoilerinator.Spoil(InputBox.Text));
            MainWindow.AddToLogBox($"Copied text {Spoilerinator.Spoil(InputBox.Text)} to clipboard.");
        }
    }
}
