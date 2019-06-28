using System;
using System.Diagnostics;
using System.Text;

namespace LastStoneWeight
{
    /// <summary>
    /// https://leetcode.com/problems/last-stone-weight/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var testInput1 = new int[]
            {
                2, 7, 4, 1, 8, 1
            };

            var testInput2 = new int[]
            {
                1, 3
            };

            var testInput3 = new int[]
            {
                4
            };

            var testInput4 = new int[]
            {
                2, 2
            };

            var testInput5 = new int[]
            {
                9, 3, 2, 10
            };

            var solution = new Solution();

            var result = solution.LastStoneWeight(testInput1);
            Debug.Assert(result == 1);

            result = solution.LastStoneWeight(testInput2);
            Debug.Assert(result == 2);

            result = solution.LastStoneWeight(testInput3);
            Debug.Assert(result == 4);

            result = solution.LastStoneWeight(testInput4);
            Debug.Assert(result == 0);

            result = solution.LastStoneWeight(testInput5);
            Debug.Assert(result == 0);
        }
    }

    public class Solution
    {
        public int LastStoneWeight(int[] stones)
        {
            // insert stones into max-heap
            // while heap.size() is greater than or equal to 2
            //   y = extract_max
            //   x = extract_max
            //   diff = y-x
            //   if (diff > 0), insert diff into heap

            var heap = new MaxHeap(stones.Length);

            foreach (var stone in stones)
            {
                heap.Add(stone);
            }

            int x, y, diff;
            while (heap.Size() >= 2)
            {
                y = heap.Poll();
                x = heap.Poll();
                diff = Math.Abs(y - x);
                if (diff > 0)
                {
                    heap.Add(diff);
                }
            }

            return heap.Peek();
        }

        public class MaxHeap
        {
            private int[] _arr;
            private int _capacity;
            private int _size;

            public MaxHeap(int capacity)
            {
                _capacity = capacity;
                _arr = new int[_capacity];
                _size = 0;
            }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append("[");
                foreach (var item in _arr)
                {
                    sb.Append(item + ", ");
                }
                sb.Append($"] (size = {_size})");
                return sb.ToString();
            }

            public int Size()
            {
                return _size;
            }

            public void Add(int value)
            {
                _arr[_size] = value;
                _size++;
                HeapifyUp();
            }

            public int Peek()
            {
                if (_size == 0)
                {
                    return 0;
                }
                return _arr[0];
            }

            public int Poll()
            {
                if (_size == 0)
                {
                    throw new Exception();
                }
                int max = _arr[0];
                _arr[0] = _arr[_size - 1];
                _size--;
                HeapifyDown();
                return max;
            }

            private void HeapifyUp()
            {
                int index = _size - 1;
                while (HasParent(index) && Parent(index) < _arr[index])
                {
                    Swap(ParentIndex(index), index);
                    index = ParentIndex(index);
                }
            }

            private void HeapifyDown()
            {
                int index = 0;
                while (HasLeftChild(index))
                {
                    int biggerChildIndex = IndexOfBiggerChild(index);

                    if (_arr[index] > _arr[biggerChildIndex])
                    {
                        break;
                    }
                    else
                    {
                        Swap(index, biggerChildIndex);
                    }
                    index = biggerChildIndex;
                }
            }

            private int IndexOfBiggerChild(int index)
            {
                // assume left child
                int biggerChildIndex = LeftChildIndex(index);
                // if right child exists and is bigger, swap
                if (HasRightChild(index) && RightChild(index) > LeftChild(index))
                {
                    biggerChildIndex = RightChildIndex(index);
                }
                return biggerChildIndex;
            }

            private void Swap(int idx1, int idx2)
            {
                int temp = _arr[idx1];
                _arr[idx1] = _arr[idx2];
                _arr[idx2] = temp;
            }

            private int LeftChildIndex(int parentIndex)
            {
                return 2 * parentIndex + 1;
            }

            private int RightChildIndex(int parentIndex)
            {
                return 2 * parentIndex + 2;
            }

            private int ParentIndex(int childIndex)
            {
                return (childIndex - 1) / 2;
            }

            private int LeftChild(int parentIndex)
            {
                return _arr[LeftChildIndex(parentIndex)];
            }

            private int RightChild(int parentIndex)
            {
                return _arr[RightChildIndex(parentIndex)];
            }

            private int Parent(int childIndex)
            {
                return _arr[ParentIndex(childIndex)];
            }

            private bool HasLeftChild(int index)
            {
                return LeftChildIndex(index) < _size;
            }

            private bool HasRightChild(int index)
            {
                return RightChildIndex(index) < _size;
            }

            private bool HasParent(int index)
            {
                return ParentIndex(index) >= 0;
            }
        }
    }
}
