using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEx.AppData
{
  public sealed class ConnectToDB
    {
        private ConnectToDB() { }
        
        private static ShopEntities s_shopEntities;

        public static ShopEntities ShopEntities
        {
            get
            {
                if (s_shopEntities == null)
                {
                    s_shopEntities = new ShopEntities();
                }
                return s_shopEntities;
            }
        }

    }
}
