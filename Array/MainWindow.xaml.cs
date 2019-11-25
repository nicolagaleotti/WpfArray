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
using LibreriaArray;

namespace Array
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            int valore = int.Parse(txtValore.Text);
            int[] array = new int[valore];
            GestioneArray.RiempiArray(array);
            string risposta = "";
            for (int i = 0; i < array.Length; i++)
            {
                risposta = risposta+ " " + array[i].ToString();
            }
            lblResult.Content = risposta;
        }
    }
}