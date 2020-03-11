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

namespace WpfExemple
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : UserControl, IPageChange
    {
        public event Action<int> PageChange; 

        public Page1()
        {
            InitializeComponent();
        }

        private void MonBoutton_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow.triggerPageChange(2); // appel du lancement de l'evenement
            PageChange?.Invoke(1);
        }
    }
}
