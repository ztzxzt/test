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
using System.Text.RegularExpressions;

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
            //Открытие окна регистрации
            Window1 window1 = new Window1();
            this.Close();
            window1.Show();

        }

        private void Button_Ent_Click(object sender, RoutedEventArgs e)
        {
            //Инициализация переменных
            string log = login.Text.Trim();
            string pass = password.Password;

            //Условие, если длина логина и пароля больше 5 символов идет подключение к базе
            if (log.Length > 5 && pass.Length > 5)
            {
                if (!Regex.IsMatch(log.ToLower(), "[йцукенгшщзхъфывапролджэячсмитьбю.\\||//ъх!@#$%^&*()_+=-Ё~`:;\"\'<>,-@№]") && (!Regex.IsMatch(pass.ToLower(), "[йцукенгшщзхъфывапролджэячсмитьбю.\\||//ъх!@#$%^&*()_+=-Ё~`:;\"\'<>,-@№]")))
                {
                    using (data1337Entities data1337 = new data1337Entities())
                    {
                        //Запрос, где пароль и логин совпадают с логином и паролем в базе
                        var query = data1337.users.Where(x => x.login == log && x.password == pass).FirstOrDefault();
                        //Условие, если запрос не пустой, открывается окно личный кабинет
                        if (query != null)
                        {
                            MessageBox.Show("Успешно вошли");
                            Window2 profile = new Window2();
                            this.Close();
                            profile.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Недопустимые символы: йцукенгшщзхъфывапролджэячсмитьбю.\\||//ъх!@#$%^&*()_+=-Ё~`:;\"\'<>,-@№");
                    login.Clear();
                    password.Clear();
                }
            }
            else
            {
                MessageBox.Show("Логин или пароль меньше 6 символов");
                login.Clear();
                password.Clear();
            }
        }
    }
}
