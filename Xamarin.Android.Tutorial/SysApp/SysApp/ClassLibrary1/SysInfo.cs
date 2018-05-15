using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class SysInfo
    {
        public string Name { get; set; }
    }

    public interface SysInfoDal
    {
        SysInfo GetSysInfo();
    }
}
