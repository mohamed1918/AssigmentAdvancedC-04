using System.Collections;

namespace AssigmentAdvancedC_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int[] numbers = { 1, 2, 2, 3, 4, 3, 1, 1 };
            Hashtable freqTable = new Hashtable();
            foreach (int num in numbers)
            {
                if (freqTable.ContainsKey(num))
                    freqTable[num] = (int)freqTable[num] + 1;
                else
                    freqTable[num] = 1;
            }
            Console.WriteLine("Frequencies:");
            foreach (DictionaryEntry entry in freqTable)
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            #endregion
        }
    }
}
