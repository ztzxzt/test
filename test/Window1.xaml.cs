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
using System.Windows.Shapes;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Reg1_Click(object sender, RoutedEventArgs e)
        {
            string loginReg = LoginReg.Text.Trim();
            string passReg = PassReg.Password;
            string passReg2 = PassReg_2.Password;
            if (loginReg.Length > 5 && passReg.Length > 6 && passReg2.Length > 6)
            {
                if (passReg == passReg2)
                {
                    using (data1337Entities data1337 = new data1337Entities())
                    {
                        var query = data1337.users.Where(x => x.login.Equals(loginReg)).FirstOrDefault();

                        if (query == null)
                        {
                            data1337.users.Add(new users()
                            {
                                login = loginReg,
                                password = passReg,
                            }
                            );
                            data1337.SaveChanges();
                            MessageBox.Show("заебись вода");
                            MainWindow Main = new MainWindow();
                            this.Close();
                            Main.Show();
                        }
                    }    
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
            else
            {
                MessageBox.Show("Логин или пароль хуета");
            } 
        }


    }
}
