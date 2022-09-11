namespace HW_DelegatesPart2
{
    internal class Program
    {
        static void Main()
        {
           
        }

        public delegate string ConvertColor(System.Drawing.Color color);
        public class Dispacher
        {
            public event ConvertColor colorEvent;
            public string ConvertColor(System.Drawing.Color color)
            {
                if (colorEvent != null) return colorEvent(color);
                throw new NullReferenceException();
            }
        }

        public int MultipleOfSeven(int[] arr)
        {
            return arr.Count(n => n % 7 == 0);
        }
        public int PositiveInArr(int[] arr)
        {
            return arr.Count(n => n > 0);
        }
        public int NegativeInArr(int[] arr)
        {
            return arr.Count(n => n < 0);
        }
        public bool FindWord(string[] text, string word)
        {
            if (text.Where(x => x.StartsWith(word)).FirstOrDefault() == word) return true;
            else return false;
        }
    }
}