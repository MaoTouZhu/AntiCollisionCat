using AntiCollisionCat.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCollisionCat.Sharp.Box
{
    /// <summary>
    /// 盒子接口
    /// </summary>
    public interface IBox : ISharp, IHasName
    {
        /// <summary>
        /// 盒子尺寸, 半值
        /// </summary>
        Data.Vector Halfize { get; set; }
    }
}
