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
        #region EVENEMENT DE CHANGEMENT DE PAGE
        public static event Action<int> OnPageChange; // evenement pas encore vu en classe

        public static void triggerPageChange(int i)
        {
            OnPageChange?.Invoke(i);
        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            this.MonControle.Content = new Page1();
            OnPageChange += MainWindow_OnPageChange; // ma mainwindow s'abonne à l'evenement et apelle cette methode quand il est declenché

        }

        private void MainWindow_OnPageChange(int obj)
        {
            switch (obj)
            {
                case 1: LoadPage1(); break;
                case 2: LoadPage2(); break;
            }
        }

        public void LoadPage2()
        {
            this.MonControle.Content = new Page2();
        }

        public void LoadPage1()
        {
            this.MonControle.Content = new Page1();
        }
    }
}
