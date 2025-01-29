using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCollisionCat.API
{
    public interface IAxis : IOutput<double?>
    {
        double? PosNow { get;}
        double? PosTarget { get;}
    }
}
