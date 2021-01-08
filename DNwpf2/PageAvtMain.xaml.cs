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

namespace DNwpf2
{
    /// <summary>
    /// Логика взаимодействия для PageAvtMain.xaml
    /// </summary>
    public partial class PageAvtMain : Page
    {
        public PageAvtMain()
        {
            InitializeComponent();
        }

        

        private void Button_Click_Avt(object sender, RoutedEventArgs e)
        {
            WindowAdmin windowAdmin = new WindowAdmin();
            windowAdmin.ShowDialog();
        }
    }
}
