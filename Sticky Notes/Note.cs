using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sticky_Notes
{
    class Note
    {
        public int Id { get; set; }
        string FileName { get; set; }

        public Note(int id, string fileName = "")
        {
            Id = id;
            if (String.IsNullOrEmpty(fileName))
            {
                Random r = new Random();
                FileName = "sn" + r.Next() + ".txt";
            }
            else
                FileName = fileName;
        }

        public void Save(TextBox inputField)
        {
            File.WriteAllText(GetFilePath(), inputField.Text);
        }

        public void Show(TextBox outputField)
        {
            outputField.Text = File.ReadAllText(GetFilePath());
        }

        public void Delete()
        {
            File.Delete(GetFilePath());
        }

        private string GetFilePath()
        {
            return Path.Combine(Properties.Settings.Default.savePath, FileName);
        }
    }
}
