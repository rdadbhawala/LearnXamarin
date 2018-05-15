using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Lib;

namespace LibAndroid
{
    public class SysInfoAndroid
        : SysInfoDal
    {
        public SysInfo GetSysInfo()
        {
            return new SysInfo()
            {
                Name = Application.Context.PackageName
            };
        }
    }
}
