using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;

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

        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.theme = ((System.Windows.Controls.Button)sender).Tag.ToString();
            Properties.Settings.Default.Save();
            MainWindow.UpdateTheme();
        }
        #endregion

        #region OnTextChange
        private void FontSizeInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            ValidateFontSizeInput(FontSizeInput, Properties.Settings.Default.maxFontSize, "fontSize");
        }
        #endregion

        #region Compositional functions
        private void ValidateFontSizeInput(System.Windows.Controls.TextBox inputField, int maxFontSize, string propertiesVariableName)
        {
            int newFontSize;
            if (int.TryParse(inputField.Text, out newFontSize) && newFontSize > 0)
            {
                if (0 < newFontSize && newFontSize <= maxFontSize)
                {
                    switch (propertiesVariableName)
                    {
                        case "fontSize":
                            Properties.Settings.Default.fontSize = newFontSize; break;
                        case "interfaceFontSize":
                            Properties.Settings.Default.defaultFontSize = newFontSize; break;
                    }
                }
                else
                {
                    if (newFontSize > maxFontSize)
                        Properties.Settings.Default.fontSize = maxFontSize;
                }
            }
            else
                Properties.Settings.Default.fontSize = Properties.Settings.Default.defaultFontSize;
            Properties.Settings.Default.Save();
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
