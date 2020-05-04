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
    /// Lógica de interacción para Caso1xaml.xaml
    /// </summary>
    public partial class Caso1xaml : Window
    {
        private double datos;
        private double diagnosis_variable;
        public Caso1xaml()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, RoutedEventArgs e)
        {
            datos = 7.3592 + (2.04930 * double.Parse(radius.Text)) - (0.38473 * double.Parse(texture.Text)) + 
                (0.07151 * double.Parse(perimeter.Text)) - (0.03980 * double.Parse(area.Text)) - (76.43227 * double.Parse(smoothness.Text)) 
                + (1.46242 * double.Parse(compactness.Text)) - (8.46870 * double.Parse(concavity.Text)) - (66.82176 * double.Parse(concavePoints.Text)) 
                - (16.27824 * double.Parse(symmetry.Text)) + (68.33703 * double.Parse(fractalDimension.Text));
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
            this.Close();
            MainWindow main = new MainWindow();
        }
    }
}
