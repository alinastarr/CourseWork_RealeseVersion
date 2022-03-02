using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Курсовик_2
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();

            DGridProducts.ItemsSource = coffeeEntities1.GetContext().products.ToList();

            var alltypes = coffeeEntities1.GetContext().Type1.ToList();
            alltypes.Insert(0, new Type1
            {
                name = "Все типы"

            });

            Combotype.ItemsSource = alltypes;
            Combotype.SelectedIndex = 0;

            
             



        }
       



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddPage(null));
        }

        private void Page_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                coffeeEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridProducts.ItemsSource = coffeeEntities1.GetContext().products.ToList();
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddPage((sender as Button).DataContext as products));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var productsForRemoving = DGridProducts.SelectedItems.Cast<products>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить слудеющие {productsForRemoving.Count()} элементы?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    coffeeEntities1.GetContext().products.RemoveRange(productsForRemoving);
                    coffeeEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DGridProducts.ItemsSource = coffeeEntities1.GetContext().products.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       
    }
}
