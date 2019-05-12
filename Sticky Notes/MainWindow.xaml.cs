﻿using System;
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
using System.IO;

namespace Sticky_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int currentId = -1;
        int maxId = -1;
        List<Note> notes = new List<Note>();

        public MainWindow()
        {
            InitializeComponent();

            SetSavePath();
            // If no notes have been loaded add a default one
            if (!LoadNotes())
            {
                notes.Add(new Note(++maxId));
                currentId++;
            }
        }

        private void SetSavePath()
        {
            string currentPath = Properties.Settings.Default.savePath;
            if (String.IsNullOrEmpty(currentPath) || !Directory.Exists(currentPath))
            {
                string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Sticky Notes");
                
                // Set save path to the default value
                Properties.Settings.Default.savePath = defaultPath;

                // Create a directory in the path if it doesn't exist
                if (!Directory.Exists(defaultPath))
                    Directory.CreateDirectory(defaultPath);
            }
        }

        private bool LoadNotes()
        {
            foreach (var noteFilePath in Directory.GetFiles(Properties.Settings.Default.savePath, "sn*.txt", SearchOption.AllDirectories))
            {
                string noteFileName = Path.GetFileName(noteFilePath);
                notes.Add(new Note(++maxId, noteFileName));
                // Increment currentId so that the first one the user will see will be the most recent one
                currentId++;
            }

            if (notes.Count() > 0)
            {
                notes[currentId].Show(IOField);
                UpdateCounter();
                return true;
            }
            return false;
        }

        private void UpdateCounter()
        {
            Counter.Text = (currentId + 1).ToString() + '/' + (maxId + 1).ToString();
        }

        #region Buttons
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            notes[currentId].Save(IOField);
            Environment.Exit(0);
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            notes[currentId].Save(IOField);
            if (currentId > 0)
            {
                currentId--;
                notes[currentId].Show(IOField);
            }
            UpdateCounter();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            notes[currentId].Save(IOField);
            if (currentId < maxId)
            {
                currentId++;
                notes[currentId].Show(IOField);
            }
            UpdateCounter();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (maxId > 0)
            {
                notes[currentId].Delete();
                notes.RemoveAt(currentId);
                for (int i = currentId; i < maxId; i++)
                    notes[i].Id--;
                maxId--;
                // If the deleted note was the last one, decrease currentId by 1
                // so that now it will point to the last note in the list
                if (currentId > maxId)
                    currentId--;
                notes[currentId].Show(IOField);
                UpdateCounter();
            }
            else
                IOField.Text = "";
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            notes[currentId].Save(IOField);
            if (currentId == maxId)
                notes.Add(new Note(++currentId));
            else
                notes.Insert(++currentId, new Note(--currentId));
            for (int i = currentId; i < maxId; i++)
                notes[i].Id++;
            maxId++;
            IOField.Text = "";
            UpdateCounter();
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
