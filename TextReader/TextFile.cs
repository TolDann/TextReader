using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Controls;

namespace TextReader
{
    internal class TextFile
    {
        private string _fileName;

        public TextFile(string fileName)
        {
            _fileName = fileName;
        }

        public void ShowFileInTextBlock(TextBlock txtBlock)
        {
            txtBlock.Text = File.ReadAllText(_fileName);
        }

    }
}
