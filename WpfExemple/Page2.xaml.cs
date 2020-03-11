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
    public partial class Page2 : UserControl, IPageChange
    {
        public event Action<int> PageChange;

        public Page2()
        {
            InitializeComponent();
        }

        private void MonBoutton_Click(object sender, RoutedEventArgs e)
        {
           PageChange?.Invoke(2); // id de la page
        }
    }
}
