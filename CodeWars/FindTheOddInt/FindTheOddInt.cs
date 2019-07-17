using System;
using System.Linq;

namespace CodeWars.FindTheOddInt
{
    public static class FindTheOddInt
    {
        public static int FindIt(int[] seq)
        {
            // Sort the sequence
            // Compare objects
            // If same object count is 1
            // Return odd object
            Array.Sort(seq);
            var seqCount = seq.Length - 1;

            var count = 1;
            for (var i = 0; i < seqCount; i++)
            {
                while (seq[i] == seq[i + 1])
                {
                    count++;
                    i++;
                }

                if (count % 2 != 0)
                {
                    return seq[i];
                }

                count = 1;
            }

            return seq.Last();
        }
    }
}