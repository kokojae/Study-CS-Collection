// 참고 : https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/collections

using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열 목록을 만듭니다.
            //var salmons = new List<string>();
            //salmons.Add("chinook");
            //salmons.Add("coho");
            //salmons.Add("pink");
            //salmons.Add("sockeye");

            // 컬렉션 이니셜 라이저를 사용하여
            // 문자열 목록을 만듭니다.
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            // 목록을 반복합니다.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }

            Console.Write("\n\n");

            for (var index = 0; index < salmons.Count; index++)
            {
                Console.Write(salmons[index] + " ");
            }

            Console.Write("\n\n");

            // 개체를 지정하여 목록에서
            // 요소를 제거합니다.
            salmons.Remove("coho");

            // 목록을 반복합니다.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }

            Console.Write("\n\n");

            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // 홀수를 제거하십시오.
            for (var index = numbers.Count - 1; index >= 0; index--)
            {
                if (numbers[index] % 2 == 1)
                {
                    // 목록에서 0부터 시작하는 색인을 지정하여
                    // 요소를 제거하십시오.
                    numbers.RemoveAt(index);
                }
            }

            // 목록을 반복합니다.
            // 람다 식은 List (T) 개체의 ForEach 메서드에
            // 배치됩니다.
            numbers.ForEach(number => Console.Write(number + " "));

            Console.Write("\n\n");

            IterateThroughList();

            Console.Write("\n\n");
        }

        private static void IterateThroughList()
        {
            var theGalaxies = new List<Galaxy>
        {
            new Galaxy() { Name="Tadpole", MegaLightYears=400},
            new Galaxy() { Name="Pinwheel", MegaLightYears=25},
            new Galaxy() { Name="Milky Way", MegaLightYears=0},
            new Galaxy() { Name="Andromeda", MegaLightYears=3}
        };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
            }
        }
    }

    public class Galaxy
    {
        public string Name { get; set; }
        public int MegaLightYears { get; set; }
    }
}
