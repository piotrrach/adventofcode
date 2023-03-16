using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year2022.Common
{
    public static class StackExtensions
    {
        public static void AddOnBottomRecursive<T>(this Stack<T> stack, T value)
        {
            if (!stack.Any())
            {
                stack.Push(value);
                return;
            }
            T tempValue = stack.Pop();
            stack.AddOnBottomRecursive(value);
            stack.Push(tempValue);
        }
    }
}
