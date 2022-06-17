using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEx.ViewModels
{
    public class IndexPages : BaseViewModel
    {
        int _id;

        public int Id { get => _id; set => Set (ref _id, value); }

        public IndexPages (int id)
        {
            _id = id;
        }
    }
}
