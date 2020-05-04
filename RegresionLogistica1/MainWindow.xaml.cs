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

namespace RegresionLogistica1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double datos;
        private double diagnosis_variable;

        //Clase principal
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, RoutedEventArgs e)
        {
            datos = 19.853002 - (0.2884483 * double.Parse(texture.Text)) - (0.011998 * double.Parse(area.Text)) - (12.79218 * double.Parse(compactness.Text)) 
                - (17.23231 * double.Parse(concavity.Text)) - (28.786981 * double.Parse(symmetry.Text)) + (31.80462 * double.Parse(fractalDimension.Text));
            diagnosis_variable = 1 / (1 + (Math.Pow(Math.Exp(1), -datos)));
            diagnosis.Text = diagnosis_variable.ToString();
            if (Math.Round(diagnosis_variable) == 0)
            {
                MessageBox.Show("Paciente " + id.Text + ", diagnóstico: 0 (Maligno) ");
            }
            else
            {
                MessageBox.Show("Paciente " + id.Text + ", diagnóstico: 1 (Benigno)");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Caso1xaml ventana = new Caso1xaml();
            ventana.Show();
            this.WindowState = WindowState.Minimized;
        }
    }
}
