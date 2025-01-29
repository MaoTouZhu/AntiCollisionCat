using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCollisionCat.API
{
    public interface IInput<T> : IHasName
    {
        T Value { get; }
    }
}
