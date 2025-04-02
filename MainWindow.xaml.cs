using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FNAFSaveEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e) {

            string appDataRoamingPath = System.IO.Path.Combine( // this code is skunked because fuck visual studio
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "MMFApplications"
            );
            string file = System.IO.Path.Combine(appDataRoamingPath, "freddy");
            string content = "[freddy]\r\nlevel=5\r\nbeatgame=1\r\nbeat6=1\r\nbeat7=1";

            if (!File.Exists(file))
            {
                MessageBox.Show("Freddy save file doesn't exist, Run FNAF 1 or buy one on steam.");
            }
            else
            {
                File.WriteAllText(file, content);
                MessageBox.Show("Done.");
            }
           
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            string appDataRoamingPath = System.IO.Path.Combine( // this code is skunked because fuck visual studio
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "MMFApplications"
            );
            string file = System.IO.Path.Combine(appDataRoamingPath, "freddy2");
            string content = "[freddy2]\r\ncine=1\r\nlevel=5\r\nturn=1\r\nbeatgame=1\r\nbeat6=1\r\nbeat7=1\r\nc1=1\r\nc2=1\r\nc3=1\r\nc4=1\r\nc5=1\r\nc6=1\r\nc7=1\r\nc8=1\r\nc9=1\r\nc10=1\r\n";

            if (!File.Exists(file))
            {
                MessageBox.Show("Freddy2 save file doesn't exist, Run FNAF 2 or buy one on steam.");
            }
            else
            {
                File.WriteAllText(file, content);
                MessageBox.Show("Done.");
            }

        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {

            string appDataRoamingPath = System.IO.Path.Combine( // this code is skunked because fuck visual studio
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "MMFApplications"
            );
            string file = System.IO.Path.Combine(appDataRoamingPath, "freddy3");
            string content = "[freddy3]\r\nlevel=5\r\nbeat7=1\r\nbeatgame=1\r\nbeat6=1\r\ncheats=1\r\nminigames=5\r\nbb=1\r\ncake=1\r\nk1=1\r\nk2=1\r\nk3=1\r\nk4=1\r\nk5=1\r\ncine=1\r\ngoodend=1\r\n4thstar=1\r\nfast=1\r\nnocams=1\r\nhyper=1\r\nvents=1\r\nturn=5\r\nextras=5";

            if (!File.Exists(file))
            {
                MessageBox.Show("Freddy3 save file doesn't exist, Run FNAF 3 or buy one on steam.");
            }
            else
            {
                File.WriteAllText(file, content);
                MessageBox.Show("Done.");
            }

        }
    }
}
