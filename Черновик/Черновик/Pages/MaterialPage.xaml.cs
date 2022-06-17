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
using Черновик.AppData;
using Черновик.ViewModels;

namespace Черновик.Pages
{
    /// <summary>
    /// Логика взаимодействия для MaterialPage.xaml
    /// </summary>
    public partial class MaterialPage : Page
    {
        public MaterialPage()
        {
            InitializeComponent();
            
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LSD != null)
            {
                ((MaterialsViewModel)this.DataContext).Search = ((TextBox)sender).Text;
                ((MaterialsViewModel)this.DataContext).SortFilt();
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LSD != null)
            {
                ((MaterialsViewModel)this.DataContext).SortFilt();
            }
        }

        private void Page_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (LSD != null)
            {
                var materials = ConnectToDB.DemoEx.Material.ToList();
                ((MaterialsViewModel)this.DataContext).Update(materials);
            }
        }

        private void LSD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ListBox)sender).SelectedItem != null)
            {
                EditSUKA edit = new EditSUKA();
                edit.DataContext = ((MaterialsViewModel)this.DataContext).Current.Material;
                edit.ShowDialog();
            }
            
        }
    }
}
