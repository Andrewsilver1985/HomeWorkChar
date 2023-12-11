namespace Zadacha_1
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            string str = "рвал дед лавр";

            System.Console.WriteLine($"Это слово в разных регистрах==>>  {str} ");

        }
        private static void Polindrom(string str)
        {
            int size = str.Length;
            int count = 0;
            while (str[count] == str[size - count] && count < size)


            {

                count++;

            }
            if (count == size / 2)
            {
                
            }

        }
    }
}