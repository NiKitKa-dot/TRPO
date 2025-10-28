using System.Collections.Generic;

namespace Laba7_U
{
    internal static class Utils
    {
        private static Dictionary<int, String> dict;
        static Utils()
        {
            dict = new Dictionary<int, String>(5);
            dict.Add(0, "Продукты");
            dict.Add(1, "Бытовая химия");
            dict.Add(2, "Одежда");
            dict.Add(3, "Фрукты");
            dict.Add(4, "Полиграфия");
        }

        public static String GetGroupByNumber(int number)
        {
            if (dict.ContainsKey(number))
                return dict[number];
            else
                return "???";
        }
    }
}