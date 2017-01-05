using Microsoft.PointOfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickCashDrawer
{
    class PosDrawer
    {

        CashDrawer myCashDrawer;
        PosExplorer explorer;

        public void CashDrawer()
        {
            explorer = new PosExplorer();
            DeviceInfo ObjDevicesInfo = explorer.GetDevice("CashDrawer");
            myCashDrawer = (CashDrawer)explorer.CreateInstance(ObjDevicesInfo);
        }

        public void OpenCashDrawer(int interval )
        {
            myCashDrawer.Open();
            myCashDrawer.Claim(interval);
            myCashDrawer.DeviceEnabled = true;
            myCashDrawer.OpenDrawer();
            myCashDrawer.DeviceEnabled = false;
            myCashDrawer.Release();
            myCashDrawer.Close();
        }
    }
}
