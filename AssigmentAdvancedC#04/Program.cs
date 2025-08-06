using System.Collections;

namespace AssigmentAdvancedC_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int[] numbers = { 1, 2, 2, 3, 4, 3, 1, 1 };
            //Hashtable freqTable = new Hashtable();
            //foreach (int num in numbers)
            //{
            //    if (freqTable.ContainsKey(num))
            //        freqTable[num] = (int)freqTable[num] + 1;
            //    else
            //        freqTable[num] = 1;
            //}
            //Console.WriteLine("Frequencies:");
            //foreach (DictionaryEntry entry in freqTable)
            //    Console.WriteLine($"{entry.Key}: {entry.Value}");
            #endregion

            #region Q2
            //Hashtable vaules = new Hashtable { {"mohammed",21 }, { "mohaned", 18 } , { "mariam", 13 } };
            //string maxKey = "";
            //int maxValue = int.MinValue;
            //foreach (DictionaryEntry entry in vaules)
            //{
            //    if ((int)entry.Value > maxValue)
            //    {
            //        maxValue = (int)entry.Value;
            //        maxKey = (string)entry.Key;
            //    }
            //}
            //Console.WriteLine($"Key with max value: {maxKey} with value: {maxValue}");
            #endregion

            #region Q3
            //Hashtable fruits = new Hashtable { { "key1", "apple" }, { "key2", "banana" }, { "key3", "apple" } };
            //string targetValue = "apple";
            //bool found = false;
            //foreach (DictionaryEntry entry in fruits)
            //{
            //    if ((string)entry.Value == targetValue)
            //    {
            //        Console.WriteLine(entry.Key);
            //        found = true;
            //    }
            //}
            //if (!found) Console.WriteLine("Key not found");
            #endregion

            #region Q4
            //string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //var groups = words.GroupBy(w => String.Concat(w.OrderBy(c => c)));
            //Console.WriteLine("\nAnagram Groups:");
            //foreach (var group in groups)
            //    Console.WriteLine(string.Join(", ", group));
            #endregion

            #region Q5
            int[] arr = { 1, 2, 3, 4, 5, 4 };
            bool hasDuplicates = arr.Length != arr.Distinct().Count();
            Console.WriteLine($"Array has duplicates: {hasDuplicates}");

            #endregion
        }
    }
}
