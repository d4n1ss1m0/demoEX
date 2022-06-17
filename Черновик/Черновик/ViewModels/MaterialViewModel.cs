using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Черновик.ViewModels
{
     public class MaterialViewModel : BaseViewModel
    {

        Material _material;
        string _title;
        string _image;

        public Material Material { get => _material; set => Set ( ref _material,value); }
        public string Title { get => _title; set => Set(ref _title, value); }
        public string Image { get => _image; set => Set(ref _image, value); }

        public MaterialViewModel() { }
    }
}
