namespace ConsoleApp1
{
    class GiftBox
    {
        public string Letter;
        public int Money;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GiftBox a = new GiftBox()
            {
                Letter = "잘 지내지?",
                Money = 100000
            };

            Console.WriteLine("A 송장내용");
            Console.WriteLine(a.Letter);
            Console.WriteLine(a.Money);
            GiftBox 배송기사님 = a;

            Console.WriteLine("배송기사님 송장내용");
            Console.WriteLine(배송기사님.Letter);
            Console.WriteLine(배송기사님.Money);

            a.Letter = "어떻게 지내고 있어?";
            a.Money = 150000;

            Console.WriteLine("A 변경이후 송장내용");
            Console.WriteLine(a.Letter);
            Console.WriteLine(a.Money);

            Console.WriteLine("배송기사님 송장내용");
            Console.WriteLine(배송기사님.Letter);
            Console.WriteLine(배송기사님.Money);
        }
    }
}
