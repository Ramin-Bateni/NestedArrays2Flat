namespace NestedArrays2Flat.Inf.Extensions
{
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
}
