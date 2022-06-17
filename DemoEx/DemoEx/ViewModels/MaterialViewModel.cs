using DemoEx.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEx.ViewModels
{
    public class MaterialViewModel : BaseViewModel
    {
        string _materialType;
        string _materialName;
        string _countInPack;
        string _Suppliers;
        string _countInStock;
        string _image;
        Material _material;
        public string MaterialType { get => _materialType; set => Set(ref _materialType,value); }
        public string MaterialName { get => _materialName; set => Set(ref _materialName, value); }
        public string CountInPack { get => _countInPack; set => Set(ref _countInPack, value); }
        public string Suppliers { get => _Suppliers; set => Set(ref _Suppliers, value); }
        public string CountInStock { get => _countInStock; set => Set(ref _countInStock, value); }
        public string Image{ get => _image; set => Set(ref _image, value); }

        public Material Material { get => _material; set => Set(ref _material, value); }
        public MaterialViewModel()
        {

        }
    
}
}
