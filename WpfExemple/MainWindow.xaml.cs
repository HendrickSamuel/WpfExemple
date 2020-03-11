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
    public partial class MainWindow : Window
    {
        IPageChange currentControl;


        public MainWindow()
        {
            InitializeComponent();
            LoadPage1();
        }

        private void MainWindow_OnPageChange(int obj)
        {
            switch (obj)
            {
                case 1: LoadPage2(); break; // si on vient de la page 1 on va vers la page 2
                case 2: LoadPage1(); break; // si on vient de la page 2 on va vers la page 1
            }
        }

        public void LoadPage2()
        {
            currentControl = new Page2();
            this.MonControle.Content = currentControl;

            currentControl.PageChange += MainWindow_OnPageChange;
        }

        public void LoadPage1()
        { 
            currentControl = new Page1();
            this.MonControle.Content = currentControl;

            currentControl.PageChange += MainWindow_OnPageChange;
        }
    }
}
