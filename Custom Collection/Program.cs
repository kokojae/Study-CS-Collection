using System;

namespace Custom_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ListColors();
        }

        private static void ListColors()
        {
            var colors = new AllColors();

            foreach (Color theColor in colors)
            {
                Console.Write(theColor.Name + " ");
            }
            Console.WriteLine();
        }
    }

    // 컬렉션 클래스
    public class AllColors : System.Collections.IEnumerable
    {
        Color[] _colors =
        {
            new Color() { Name = "red" },
            new Color() { Name = "blue" },
            new Color() { Name = "green" }
        };

        public System.Collections.IEnumerator GetEnumerator()
        {
            return new ColorEnumerator(_colors);

            // 사용자 지정 열거자를 만드는 대신
            // 배열의 GetEnumerator를 사용할 수 있습니다.
            //return _colors.GetEnumerator();
        }

        // 사용자 지정 열거형
        private class ColorEnumerator : System.Collections.IEnumerator
        {
            private Color[] _colors;
            private int _position = -1;

            public ColorEnumerator(Color[] colors)
            {
                _colors = colors;
            }

            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return _colors[_position];
                }
            }

            bool System.Collections.IEnumerator.MoveNext()
            {
                _position++;
                return (_position < _colors.Length);
            }

            void System.Collections.IEnumerator.Reset()
            {
                _position = -1;
            }
        }
    }

    // 원소 클래스
    public class Color
    {
        public string Name { get; set; }
    }
}
