using System.Windows;
using System.Windows.Forms;

namespace Sticky_Notes
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        #region Buttons
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.isSettingsWindowOpened = false;
            this.Close();
        }

        private void PathButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            if (!string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
            {
                Properties.Settings.Default.savePath = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region OnTextChange
        private void FontSizeInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            int newFontSize;
            if (int.TryParse(FontSizeInput.Text, out newFontSize))
            {
                if (0 < newFontSize && newFontSize < 100)
                {
                    Properties.Settings.Default.fontSize = newFontSize;
                    Properties.Settings.Default.Save();
                }
                else
                    System.Windows.MessageBox.Show("Font size: 1-99 values allowed", "Warning!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Move window
        private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try { this.DragMove(); }
            catch { }
        }
        #endregion
    }
}
