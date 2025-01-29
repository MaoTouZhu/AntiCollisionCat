using AntiCollisionCat.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCollisionCat.Sharp
{
    /// <summary>
    /// 球接口
    /// </summary>
    public interface ISphere : IHasName, ISharp
    {
        /// <summary>
        /// 半径
        /// </summary>
        double Radius { get; set; }
    }
}
