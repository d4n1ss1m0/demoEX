using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Черновик.AppData;

namespace Черновик.ViewModels
{
     public class MaterialsViewModel : BaseViewModel
    {
        MaterialViewModel _current;
        ObservableCollection<MaterialViewModel> _materials = new ObservableCollection<MaterialViewModel>();
        List<string> _sorted = new List<string>();
        List<string> _filtered = new List<string>();
        string _search;
        string _filter;
        string _sort;

        public ObservableCollection<MaterialViewModel> Materials { get => _materials; set => Set(ref _materials, value); }
        public List<string> Sorted { get => _sorted; set => Set(ref _sorted, value); }
        public List<string> Filtered { get => _filtered;set=> Set(ref _filtered, value); }
        public string Search { get => _search; set {Set(ref _search, value);}
        }
        public string Filter { get => _filter; set {Set(ref _filter, value);}
        }
        public string Sort { get => _sort; set {
                Set(ref _sort, value);
                   
            } }
        public MaterialViewModel Current { get => _current; set => Set(ref _current, value); }

        public MaterialsViewModel()
        {
            _filtered = ConnectToDB.DemoEx.MaterialType.Select(s => s.Title).ToList();
            int x = 0;
        }

        public void Update(List<Material> materials) //Подгрузка
        {
            _materials.Clear();
            foreach(var item in materials)
            {
                MaterialViewModel vm = new MaterialViewModel();
                vm.Material = item;
                if (item.Image == "")
                {
                    vm.Image = "../Resources/picture.png";
                }
                else
                {
                    vm.Image = item.Image;
                }
                vm.Title = item.Title;
                _materials.Add(vm);
            }
        }

        public void SortFilt() //Сортировка по всем критериям
        {
            var materials = ConnectToDB.DemoEx.Material.ToList();
            if (Search != "" && Search != null)
            {
                materials = materials.FindAll(s => s.Title.Contains(Search));
            }
            if (_filter != null)
            {
               materials = materials.FindAll(s => s.MaterialType.Title == _filter);
            }
            Update(materials);
        }
    }
}
