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
using System.IO;
using Microsoft.Win32;

namespace TextReader
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void ClickButtonOpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFildeDialog = new OpenFileDialog();
            if (openFildeDialog.ShowDialog() == true)
            {
                string fileName = openFildeDialog.FileName;

                TextFile textFile = new TextFile(fileName);
                textFile.ShowFileInTextBlock(txtBlock_textDisplay);
            }
            
        }
    }
}
