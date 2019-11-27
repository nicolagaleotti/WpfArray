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
            int[] array1 = new int[valore];
            GestioneArray.RiempiArray(array1);
            string risposta = "";
            for (int i = 0; i < array1.Length; i++)
            {
                risposta = risposta+ " " + array1[i].ToString();
            }
            lblResult1.Content = risposta;
            int[] array2 = new int[valore];
            GestioneArray.RiempiArray(array2);
            risposta = "";
            for (int i = 0; i < array2.Length; i++)
            {
                risposta = risposta + " " + array2[i].ToString();
            }
            lblResult2.Content = risposta;
            long[] array = new long[array1.Length];
            array = GestioneArray.UnisciArray(array1, array2);
            risposta = "";
            for (int i = 0; i < array2.Length; i++)
            {
                risposta = risposta + " " + array[i].ToString();
            }
            lblUnione.Content = risposta;
        }

        
    }
}