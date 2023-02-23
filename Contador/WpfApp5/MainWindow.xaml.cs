using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace WpfApp5
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
        int[] arreglo = new int[3];
        byte contador = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int valor= int.Parse(txt1.Text);
            arreglo[contador] = valor;
            contador++;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            for(int i=0; i<arreglo.Length; i++)
            {
                listBox.Items.Add(arreglo[i]);
            }
        }
    }
}
