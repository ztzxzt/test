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
using System.Text.RegularExpressions;


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
            //иницализация переменных
            string loginReg = LoginReg.Text.Trim();
            string passReg = PassReg.Password;
            string passReg2 = PassReg_2.Password;


            //Условие, если длина логина, пароля и подтв пароля больше 5 символов
            if (loginReg.Length > 5 && passReg.Length > 5 && passReg2.Length > 5)
            {
                if (!Regex.IsMatch(loginReg.ToLower(), "[йцукенгшщзхъфывапролджэячсмитьбю.\\||//ъх!@#$%^&*()_+=-Ё~`:;\"\'<>,-@№]") && (!Regex.IsMatch(passReg.ToLower(), "[йцукенгшщзхъфывапролджэячсмитьбю.\\||//ъх!@#$%^&*()_+=-Ё~`:;\"\'<>,-@№]")) && (!Regex.IsMatch(passReg2.ToLower(), "[йцукенгшщзхъфывапролджэячсмитьбю.\\||//ъх!@#$%^&*()_+=-Ё~`:;\"\'<>,-@№]")))
                {
                    //Условие, если пароль и подтв пароля совпадают
                    if (passReg == passReg2)
                    {
                        using (data1337Entities data1337 = new data1337Entities())
                        {
                            //запрос к базе
                            var query = data1337.users.Where(x => x.login.Equals(loginReg)).FirstOrDefault();
                            // если такого логина нет, то он вносится в базу данных вместе с паролем
                            if (query == null || !loginReg.Contains(""))
                            {
                                data1337.users.Add(new users()
                                {
                                    login = loginReg,
                                    password = passReg,
                                }
                                );
                                //Сохранение изменений
                                data1337.SaveChanges();
                                MessageBox.Show("ОК");
                                MainWindow Main = new MainWindow();
                                this.Close();
                                Main.Show();
                            }
                            else
                            {
                                MessageBox.Show("Такой логин уже существует");
                                LoginReg.Clear();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают");
                        PassReg.Clear();
                        PassReg_2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Недопустимые символы: йцукенгшщзхъфывапролджэячсмитьбю.\\||//ъх!@#$%^&*()_+=-Ё~`:;\"\'<>,-@№");
                    LoginReg.Clear();
                    PassReg.Clear();
                    PassReg_2.Clear();
                }
            }
            else
            {
                MessageBox.Show("Логин или пароль меньше 6 символов");
                LoginReg.Clear();
                PassReg.Clear();
                PassReg_2.Clear();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Main1 = new MainWindow();
            this.Close();
            Main1.Show();
        }
    }
}

