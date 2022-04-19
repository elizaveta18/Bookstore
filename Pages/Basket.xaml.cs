using Bookstore.Class;
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
using static Bookstore.MainWindow;

namespace Bookstore.Pages
{
    /// <summary>
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Page
    {
        List<Boockstore> boockstores = BaseConnect.baseConnect.Boockstore.ToList();
        public Basket()
        {
            InitializeComponent();
            listbox2.ItemsSource = boockstores;//Вывод данных в лист из базы
        }

        private void btn_Naz_Click(object sender, RoutedEventArgs e)
        {
            User.frm.GoBack();
        }

        private void btn_Order_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
