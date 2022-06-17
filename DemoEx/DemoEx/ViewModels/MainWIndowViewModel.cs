using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DemoEx;
using DemoEx.AppData;

namespace DemoEx.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private List<string> _sorted = new List<string>();
        private List<string> _filtered = new List<string>();

        public MainWindowViewModel()
        {
            
            _sorted = ConnectToDB.ShopEntities.MaterialType.Select(u => u.Title).ToList();
            _sorted.Insert(0,"Все типы");
            _filtered.Add("Стоимость");
            _filtered.Add("Остаток на складе");
            _filtered.Add("Наименование");
        }
        public List<string> Sorted
        {
            get => _sorted;
            set => Set(ref _sorted, value);
        }

        public List<string> Filtered
        {
            get => _filtered;
            set => Set(ref _filtered, value);
        }


    }

 
}


