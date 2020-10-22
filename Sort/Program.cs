using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            ListCars();
        }

        private static void ListCars()
        {
            var cars = new List<Car>
            {
                { new Car() { Name = "car1", Color = "blue", Speed = 20}},
                { new Car() { Name = "car2", Color = "red", Speed = 50}},
                { new Car() { Name = "car3", Color = "green", Speed = 10}},
                { new Car() { Name = "car4", Color = "blue", Speed = 50}},
                { new Car() { Name = "car5", Color = "blue", Speed = 30}},
                { new Car() { Name = "car6", Color = "red", Speed = 60}},
                { new Car() { Name = "car7", Color = "green", Speed = 50}}
            };

            // 색상을 알파벳순으로 정렬 한 다음 
            // 속도를 내림차순으로 정렬합니다.
            cars.Sort();

            // 모든 자동차를 봅니다.
            foreach (Car thisCar in cars)
            {
                Console.Write(thisCar.Color.PadRight(5) + " ");
                Console.Write(thisCar.Speed.ToString() + " ");
                Console.Write(thisCar.Name);
                Console.WriteLine();
            }
        }
    }

    public class Car : IComparable<Car>
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public int CompareTo(Car other)
        {
            // 이 메서드를 호출하면 정렬에 사용되는 
            // 단일 비교가 수행됩니다.

            // 비교되는 개체의 상대적 순서를 결정합니다.            
            // 색상별로 알파벳순으로 정렬 한 다음 
            // 내림차순으로 속도별로 정렬합니다.


            // 색상을 비교하십시오.
            int compare;
            compare = string.Compare(this.Color, other.Color, true);

            // 색상이 동일하면 속도를 비교하십시오.
            if (compare == 0)
            {
                compare = this.Speed.CompareTo(other.Speed);

                // 속도를 위해 내림차순을 사용하십시오.
                compare = -compare;
            }

            return compare;
        }
    }
}
