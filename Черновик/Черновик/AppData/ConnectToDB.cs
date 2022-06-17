using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Черновик.AppData
{
    public  class ConnectToDB
    {

        private static DemoExEntities s_demoEx;

        private  ConnectToDB() { }

        public static DemoExEntities DemoEx { get
            {
                if (s_demoEx == null)
                    s_demoEx = new DemoExEntities();
                    return s_demoEx;
            }
                 }
    }
}
