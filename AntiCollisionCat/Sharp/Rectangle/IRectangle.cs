using AntiCollisionCat.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCollisionCat.Sharp
{
    /// <summary>
    /// 空间矩形接口
    /// </summary>
    public interface IRectangle : IHasName, ISharp
    {
        /// <summary>
        /// 外边尺寸1
        /// </summary>
        double L1 { get; set; }

        /// <summary>
        /// 外边尺寸2
        /// </summary>
        double L2 { get; set; }
    }
}
