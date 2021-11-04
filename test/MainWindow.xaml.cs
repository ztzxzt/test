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
            this.Close();
            window1.Show();

        }

        private void Button_Ent_Click(object sender, RoutedEventArgs e)
        {
            string log = login.Text.Trim();
            string pass = password.Password;

            if (log.Length > 5 && pass.Length > 6)
            {
                using (data1337Entities data1337 = new data1337Entities())
                {
                    var query = data1337.users.Where(x => x.login == log && x.password == pass).FirstOrDefault();

                    if (query != null)
                    {
                        MessageBox.Show("КУ");
                        Window2 profile = new Window2();
                        this.Close();
                        profile.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Логин или пароль хуета");
            }
        }
    }
}
