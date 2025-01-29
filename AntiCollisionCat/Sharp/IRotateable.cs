using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCollisionCat.Sharp
{
    /// <summary>
    /// 可旋转的
    /// </summary>
    public interface IRotateable
    {
        /// <summary>
        /// 旋转
        /// </summary>
        /// <param name="para"></param>
        void Rotate(Data.Quaternion para);
    }
}
