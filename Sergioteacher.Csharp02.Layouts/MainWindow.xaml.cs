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

namespace Sergioteacher.Csharp02.Layouts
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Ventana1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            miniDebug.Text = " Tamaño: " + Ventana1.Width.ToString();
            G1.Width = Ventana1.Width - 24;
            G2.Width = Ventana1.Width - 24;
            G3.Width = Ventana1.Width - 24;
            G4.Width = Ventana1.Width - 24;
            G5.Width = Ventana1.Width - 24;
            G6.Width = Ventana1.Width - 24;
            G7.Width = Ventana1.Width - 24;
            
        }
    }
}
