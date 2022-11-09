using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
    internal class Program
    {
        /* 在主控台應用程式裡,宣告一個 static method, 名稱為GetEvenItems
         * 傳回型別是 List<int>
         * 傳入參數有二個
         *   List<int> 是待篩選的集合, 內含多個奇/偶數的數值
         *   Func<int ,bool> 用來篩選, 是偶數傳回true, 奇數傳回fals
         * 在 Main 裡叫用 GetEvenItems, 傳入一個集合, 並傳回一個只包含偶數的集合
         */
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {25,48,56,28,47,52,13,89 };
            Func<int, bool> isEven = n => n % 2 == 0;

            List<int> result = GetEvenItems(numbers, isEven);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
        static List<int> GetEvenItems(List<int> items, Func<int, bool> func)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < items.Count; i++)
            {
                if (func(items[i]) == true)
                    result.Add(items[i]);
            }
            return result;
        }
    }
}
