using DemoEx.AppData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEx.ViewModels
{
    public class MaterialsViewModel : BaseViewModel
    {
        int _id;

        MaterialViewModel _current;
        ObservableCollection<MaterialViewModel> _materials = new ObservableCollection<MaterialViewModel>();
        public ObservableCollection<MaterialViewModel> Materials { get => _materials; set => Set(ref _materials, value); }
        public int Id { get => _id; set  => Set(ref _id, value); }
        public MaterialViewModel Current { get => _current; set => Set(ref _current, value); }

        public MaterialsViewModel(List<Material> materials, int index)
        {
           
            _id = index;
            foreach (Material item in materials)
            {
                MaterialViewModel viewModel = new MaterialViewModel();
                viewModel.Image = item.Image;
                viewModel.MaterialName = item.Title;
                viewModel.MaterialType = item.MaterialType.Title;
                var a = ConnectToDB.ShopEntities.Supplier.ToList();
                List<string> sup = ConnectToDB.ShopEntities.Supplier.Where(s => s.Material.Select(i => i.ID).Contains(item.ID)).Select(k => k.Title).ToList();
                foreach (var sk in sup)
                    viewModel.Suppliers += sk + ", ";

                viewModel.CountInPack = item.MinCount.ToString();
                viewModel.CountInStock = item.CountInStock.ToString();

                if (item.Image == "")
                {
                    viewModel.Image = "../Resources/picture.png";
                }
                else {
                    viewModel.Image = item.Image;
                      }
                viewModel.Material = item;
                _materials.Add(viewModel);
            }
        }
    }
}
