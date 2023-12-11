namespace Zadacha_1
{
    public static class Program
    {
        public static void Main(string[] arg)
        {
            string str = "ПрИвЕтИк";
            string str1;
            str1=str.ToLower();
            System.Console.WriteLine($"Это слово в разных регистрах==>>  {str} ");
            System.Console.WriteLine($"Это слово в нижнем регистрах==>>  {str1} ");

        }
    }
}