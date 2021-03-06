﻿using System;
using NestedArrays2Flat.Inf.Extensions;

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

   

}
