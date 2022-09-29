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

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Valor;
        int Fallos;
        public MainWindow()
        {
            InitializeComponent();
            Random semilla = new Random();
            this.Valor = semilla.Next(0, 101);
            this.Fallos = 0;
        }


        private void comprobarBoton_Click(object sender, RoutedEventArgs e)
        {
            if(int.Parse(cajaTextBox.Text) > Valor)
            {
                Fallos++;
                numeroTextBlock.Text = $"Has fallado, te has pasado. Número de fallos {Fallos}";
            }
            else if(int.Parse(cajaTextBox.Text) < Valor)
            {
                Fallos++;
                numeroTextBlock.Text = $"Has fallado, te has quedado corto. Número de fallos {Fallos}";
            }
            else
            {
                numeroTextBlock.Text = $"Has acertado.";
            }
        }

        private void reiniciarBoton_Click(object sender, RoutedEventArgs e)
        {
            Random semilla = new Random();
            this.Valor = semilla.Next(0, 101);
            this.Fallos = 0;
            numeroTextBlock.Text = "¿Qué número he pensado?";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
