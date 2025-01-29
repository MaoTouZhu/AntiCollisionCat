using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCollisionCat.Sharp
{
    /// <summary>
    /// 形状接口
    /// </summary>
    public interface ISharp
    {
        /// <summary>
        /// 中心坐标
        /// </summary>
        Data.Matrix3 Center { get; set; }

        /// <summary>
        /// 方向或姿态
        /// </summary>
        Data.Matrix3 Direction { get; set; }

        /// <summary>
        /// 平移
        /// </summary>
        /// <param name="dir">平移方向</param>
        void Parallel(Data.Vector dir);
    }
}
