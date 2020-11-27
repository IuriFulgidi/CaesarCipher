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

namespace CaesarWPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_DoWork_Click(object sender, RoutedEventArgs e)
        {
            string input = txt_input.Text;
            int key = Convert.ToInt32(txt_key.Text);
            string output = "";
            Encoder enc = new Encoder(key);
            Encoder dec = new Decoder(key);

            if (rdb_Encode.IsChecked==true)
            {
                foreach (char lettera in input)
                    output += enc.Encode(lettera);
            }
            else
            {
                foreach (char lettera in input)
                    output += dec.Decode(lettera);
            }

            lbl_output.Content = output;
        }
    }
}
