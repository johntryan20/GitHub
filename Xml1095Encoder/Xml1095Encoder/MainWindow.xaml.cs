using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using Xml1095Encoder.Model; 

namespace Xml1095Encoder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Form1095Encoder encoder = new Form1095Encoder();

            // write xml encoded file 
            encoder.WriteFile();

            // launch results in chrome 
            Process.Start("chrome.exe", "C:\\Users\\John.Ryan\\Documents\\SerializationOverview.xml");
            
            // close main window 
            this.Close();
        }
    }
}
