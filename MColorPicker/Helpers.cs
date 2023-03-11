using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MColorPicker
{
    internal static class Helpers
    {
        internal static bool ColorsAreEqual(Color x, Color y)
            => x.R == y.R && x.G == y.G && x.B == y.B && x.A == y.A;
    }
}
