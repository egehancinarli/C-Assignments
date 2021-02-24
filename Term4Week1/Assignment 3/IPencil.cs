using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public interface IPencil
    {
        bool CanWrite { get; }
        void Write(string Message);
        void AfterSharpening();

    }
}
