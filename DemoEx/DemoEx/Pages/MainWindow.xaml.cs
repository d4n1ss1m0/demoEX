using DemoEx.AppData;
using DemoEx.Pages;
using DemoEx.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace DemoEx
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        List<MaterialPage> _materialPages  = new List<MaterialPage>();
        List<IndexPages> _indexPages = new List<IndexPages>();
        MainWindowViewModel mainWindowView = new MainWindowViewModel();


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = mainWindowView;
            FrameObj.frameMain = frmMain;
            var materials = ConnectToDB.ShopEntities.Material.ToList();
            Update(materials);
            
            frmMain.Navigate(MaterialPages[0]);
        }

        public List<MaterialPage> MaterialPages { get => _materialPages; set => _materialPages = value; }
        public List<IndexPages> IndexPages { get => _indexPages; set => _indexPages = value; }

        public void Update(List<Material> materials)
        {
            MaterialPages.Clear();
            IndexPages.Clear();
            int index = 0;
            for (int i = 0; i <= materials.Count(); i = i + 15)
            {                           
                if (materials.Count - i > 15)
                {
                    index++;
                    IndexPages.Add(new IndexPages(index));
                    MaterialPage mp = new MaterialPage();
                    mp.DataContext = new MaterialsViewModel(materials.GetRange(i, 15), index);
                    MaterialPages.Add(mp);

                }
                else
                {
                    index++;
                    IndexPages.Add(new IndexPages(index));
                    MaterialPage mp = new MaterialPage();
                    mp.DataContext = new MaterialsViewModel(materials.GetRange(i, materials.Count - i), index);
                    MaterialPages.Add(mp);
                    break;
                }
                    
                
                
            }
            Mat.ItemsSource = null;
            Mat.ItemsSource = IndexPages;
            frmMain.Navigate(MaterialPages[0]);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(MaterialPages[Convert.ToInt32(((Button)sender).Content)-1]);
        }

       
 
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        public void Filter()
        {
            if (Mat != null)
            {
                var materials = ConnectToDB.ShopEntities.Material.ToList();
                if (CmbxSort != null
                    && CmbxSort.SelectedIndex != -1 
                    && CmbxSort.SelectedItem.ToString() != "Все типы" )
                {
                    MaterialType mat = ConnectToDB.ShopEntities.MaterialType.Where(k => k.Title == CmbxSort.SelectedItem.ToString()).FirstOrDefault();
                    materials = materials.Where(s => s.MaterialType == mat).ToList();
                }
                if (FilterCombo != null && FilterCombo.SelectedIndex != -1)
                {
                    if(FilterCombo.SelectedItem.ToString() == "Стоимость")
                    {
                        materials = materials.OrderBy(s => s.Cost).ToList();
                    }
                     else if (FilterCombo.SelectedItem.ToString() == "Остаток на складе")
                    {
                        materials = materials.OrderBy(s => s.CountInStock).ToList();
                    }
                    else if(FilterCombo.SelectedItem.ToString() == "Наименование")
                    {
                        materials = materials.OrderBy(s => s.Title).ToList();
                    }
                }
                if(SearchBox.Text != null && SearchBox.Text != "")
                {
                    materials = materials.Where(s => s.Title.Contains(SearchBox.Text) ).ToList();
                }

                Update(materials);
            }
           
        }

        private void CmbxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }
    }
}
