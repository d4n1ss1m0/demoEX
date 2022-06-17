using DemoEx.AppData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace DemoEx.Pages
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit()
        {
            InitializeComponent();
           
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ConnectToDB.ShopEntities.Material.Remove((Material)this.DataContext);
            ConnectToDB.ShopEntities.SaveChanges();
            this.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            List<int> temp = ConnectToDB.ShopEntities.MaterialType.Where(k=> k.Title == MaterialTypes.SelectedItem.ToString()).Select(s=> s.ID).ToList();
            ((Material)this.DataContext).MaterialTypeID = temp[0];
            ConnectToDB.ShopEntities.Entry((Material)this.DataContext).State = EntityState.Modified;
            ConnectToDB.ShopEntities.SaveChanges();
            this.Close();
        }

        private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var types = ConnectToDB.ShopEntities.MaterialType.Select(u => u.Title).ToList();
            int index = types.IndexOf(((Material)this.DataContext).MaterialType.Title);
            MaterialTypes.ItemsSource = types;
            MaterialTypes.SelectedIndex = index;
        }
    }
}
