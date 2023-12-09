using System;

namespace CombinationsOfAB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Введём с клавиатуры длину комбинации
            Console.WriteLine("Введите длину комбинации: ");
            int n = int.Parse(Console.ReadLine());

            // Выведем на экран все комбинации
            foreach (string combination in GenerateCombinations(n))
            {
                Console.WriteLine(combination);
            }
        }

        private static IEnumerable<string> GenerateCombinations(int n)
        {
            // Если длина комбинации равна 0, то возвращаем пустую строку
            if (n == 0)
            {
                yield return "";
            }

            // Итерируемся по всем комбинациям длиной n - 1
            foreach (string combination in GenerateCombinations(n - 1))
            {
                // Добавляем в конец комбинации символ a
                yield return combination + "a";

                // Добавляем в конец комбинации символ b
                yield return combination + "b";
            }
        }
    }
}
