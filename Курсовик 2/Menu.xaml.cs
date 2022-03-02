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

namespace Курсовик_2
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            MainFrame.Navigate(new ProductPage());
            Manager.MainFrame = MainFrame;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
         private void MainFrame_ContentRendered (object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                backButton.Visibility = Visibility.Visible;
            }
            else
            {
                backButton.Visibility = Visibility.Hidden;
            }
        }
    }
}
