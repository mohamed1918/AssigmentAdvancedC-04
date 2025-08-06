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
            //int[] arr = { 1, 2, 3, 4, 5, 4 };
            //bool hasDuplicates = arr.Length != arr.Distinct().Count();
            //Console.WriteLine($"Array has duplicates: {hasDuplicates}");

            #endregion

            #region Q6
            //SortedDictionary<int, string> students = new SortedDictionary<int, string>();
            //students.Add(101, "mohammed");
            //students.Add(102, "mohanand");
            //students.Add(103, "mariam");
            //Console.WriteLine("\nStudents:");
            //foreach (var s in students)
            //    Console.WriteLine($"{s.Key}: {s.Value}");
            //students.Remove(102);
            //Console.WriteLine("After removing ID 102:");
            //foreach (var s in students)
            //    Console.WriteLine($"{s.Key}: {s.Value}");
            #endregion

            #region Q7
            //SortedList<int, string> employees = new SortedList<int, string>
            //{
            //    { 1, "moammed" },
            //    { 3, "Mohanand" },
            //    { 2, "mariam" }
            //};
            //Console.WriteLine("\nEmployees:");
            //foreach (var emp in employees)
            //    Console.WriteLine($"{emp.Key}: {emp.Value}");
            #endregion

            #region Q8
            //int N = 10;
            //int[] nums = { 1, 2, 4, 5, 7, 9 };
            //var missing = Enumerable.Range(1, N).Except(nums);
            //Console.WriteLine("\nMissing numbers: " + string.Join(", ", missing));
            #endregion

            #region Q9
            //List<int> listWithDuplicates = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            //HashSet<int> uniqueSet = new HashSet<int>(listWithDuplicates);
            //Console.WriteLine("\nUnique values: " + string.Join(", ", uniqueSet));
            #endregion

            #region Q10
            //Hashtable original = new Hashtable { { "A", 1 }, { "B", 2 }, { "C", 3 } };
            //Hashtable swapped = new Hashtable();
            //foreach (DictionaryEntry entry in original)
            //    swapped[entry.Value] = entry.Key;
            //Console.WriteLine("\nSwapped Hashtable:");
            //foreach (DictionaryEntry entry in swapped)
            //    Console.WriteLine($"{entry.Key}: {entry.Value}");
            #endregion

            #region Q11
            //HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            //HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
            //set1.UnionWith(set2);
            //Console.WriteLine("\nUnion: " + string.Join(", ", set1));
            #endregion

            #region Q12
            //Dictionary<string, int> dict = new Dictionary<string, int>
            //{
            //    { "apple", 1 }, { "animal", 2 }, { "airport", 3 }, { "banana", 4 }
            //};
            //char targetChar = 'a';
            //int count = dict.Keys.Count(k => k.StartsWith(targetChar.ToString()));
            //Console.WriteLine($"\nKeys starting with '{targetChar}': {count}");
            #endregion

            #region Q13
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 3, 5, 7, 9 };
            int target = 4;
            List<int> greaterList = sortedSet.Where(x => x > target).ToList();
            Console.WriteLine("\nElements greater than target: " + string.Join(", ", greaterList));
            #endregion
        }
    }
}
