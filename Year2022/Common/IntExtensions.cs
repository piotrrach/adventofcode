using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year2022.Common
{
    public static class IntExtensions
    {
        public static bool IsInRange(this int value, int rangeStart, int rangeEnd) {
            return (value >= rangeStart && value <= rangeEnd)
                || (value >= rangeEnd && value <= rangeStart);
        }
    }
}
