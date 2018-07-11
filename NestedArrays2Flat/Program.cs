using System;
using System.Collections.Generic;

namespace NestedArrays2Flat
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Sample non-flat array (nested array)
            var arrSample = new object[]
            {
                new object[]
                {
                    new object[]
                    {
                        1, 2, new object[]
                        {
                            3
                        }
                    }, 4
                }
            };

            Console.WriteLine("Flating Array\n\n Input:\t[[1,2,[3]],4]");

            // Flating the array
            var arrFlated =arrSample.ToFlatArray();

            Console.WriteLine($"Output:\t[{string.Join(",", arrFlated)}]");

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Array Extensions Class
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Flating a nested array. It works fot simple or complicated nested arrays
        /// </summary>
        /// <param name="arrNested">Nestead Array eq: [[1,2,[3]],4]</param>
        /// <returns>Flatten Array</returns>
        public static int[] ToFlatArray(this object[] arrNested)
        {
            return new ArrayTools().ToFlatArray(arrNested);
        }
    }

    /// <summary>
    /// Array Tools Class
    /// </summary>
    public class ArrayTools
    {
        /// <summary>
        /// This list will be filled by ToFlatArray method in each step of its recursive functionality and keep the Flattent Array result as List.
        /// </summary>
        private List<int> _flatten;

        /// <summary>
        /// Flating a nested array. It works fot simple or complicated nested arrays
        /// </summary>
        /// <param name="arrNested">Nestead Array eq: [[1,2,[3]],4]</param>
        /// <returns>Flatten Array</returns>
        public int[] ToFlatArray(object[] arrNested)
        {
            if (arrNested == null)
            {
                throw new ArgumentNullException($"Error: {nameof(arrNested)} is null in {nameof(ToFlatArray)} extension method!");
            }
            if (_flatten == null)
            {
                _flatten = new List<int>();
            }
            // Loop over each item of array
            foreach (var item in arrNested)
            {
                if (item.GetType() == typeof(object[]))
                {
                    //Call ToFlatArray as recursive to scan arrNested
                    ToFlatArray((object[])item);
                }
                else
                {
                    // Adding the Leaf (int number) to the result list
                    _flatten.Add((int)item);
                }
            }
            return _flatten.ToArray();
        }
    }
}
