using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiCollisionCat.API
{
    public interface IOutput<T> : IInput<T>
    {
        bool SetValue(T value);
    }
}
