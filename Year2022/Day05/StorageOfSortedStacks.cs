using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Year2022.Common;

namespace Year2022.Day05
{
    public class StorageOfSortedStacks<T> : IEnumerable<Stack<T>>
    {
        private SortedDictionary<int, Stack<T>> _stacks;

        public StorageOfSortedStacks()
        {
            _stacks = new SortedDictionary<int, Stack<T>>();
        }

        #region Enumerator
        IEnumerator<Stack<T>> IEnumerable<Stack<T>>.GetEnumerator()
        {
            foreach (var item in _stacks)
            {
                yield return item.Value;
            }
        }

       IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<Stack<T>>).GetEnumerator();
        }
        #endregion

        public void Add(int index, T value)
        {
            if (!_stacks.ContainsKey(index))
            {
                _stacks.Add(index, new Stack<T>());
            }
            _stacks[index].AddOnBottomRecursive(value);
        }

        public void Move(int quantity, int from, int to, bool moveMultipleAtOnce)
        {
            if (!_stacks.ContainsKey(to))
            {
                _stacks.Add(to, new Stack<T>());
            }

            if (moveMultipleAtOnce)
            {
                Stack<T> tmp = new Stack<T>();
                for(int i = 0; i < quantity; i++)
                {
                    tmp.Push(_stacks[from].Pop());
                }

                for (int i = 0; i < quantity; i++)
                {
                    _stacks[to].Push(tmp.Pop());
                }
            }
            else
            {
                for(int i = 0; i < quantity; i++)
                {
                    _stacks[to].Push(_stacks[from].Pop());
                }
            }
        }
    }
}
