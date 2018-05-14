using System;
using System.Collections.Generic;

namespace VideoScreensaver
{
    public static class Shuffle
    {
        public static void ShufVideo<T>(this IList<T> list, Random rnd)
        {            
            var listCount = list.Count;

            for (var index = 0; index < listCount; index++)
            {
                var nextRnd = rnd.Next(index, listCount);

                var temp = list[index];
                list[index] = list[nextRnd];
                list[nextRnd] = temp;
            }
        }
    }
}
