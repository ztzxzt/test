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

namespace test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
           Window1 window1 = new Window1();
            window1.Show();
            //try
            //{
            //    test.bd.data1337Entities1 entities1 = new bd.data1337Entities1();

            //    var query = entities1.users.Select(x => x.login);
            //    foreach (var item in query)
            //    {
            //        MessageBox.Show(item.ToString());
            //    }

            //    MessageBox.Show("База работает");

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("База не работает");
            //    throw;
            //}
        }

        private void Button_Ent_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }
    }
}
