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

namespace Курсовик_2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(login.Text))
            {
                if (!String.IsNullOrEmpty(password.Password))
                {
                    IQueryable<Autorization> autorizations = coffeeEntities1.GetContext().Autorization.Where(p => p.Логин == login.Text && p.Пароль == password.Password);
                    if (autorizations.Count() == 1)
                    {
                        MessageBox.Show("Добро пожаловать");
                        Menu window = new Menu
                        {
                            Owner = this
                        };
                        window.Show();
                        this.Hide();

                    }
                    else MessageBox.Show("Нeверный логин или пароль");

                }
            }
        }
    }
}
