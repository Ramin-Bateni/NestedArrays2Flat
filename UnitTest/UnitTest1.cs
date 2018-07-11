using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NestedArrays2Flat.Inf.Extensions;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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

            var flatten=arrSample.ToFlatArray();

            CollectionAssert.AreEqual(flatten, new[] {1, 2, 3, 4});
        }
    }
}
