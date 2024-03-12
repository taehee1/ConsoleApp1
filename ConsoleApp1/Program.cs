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

            GiftBox 배송기사님 = a;
                                   
            a.Letter = "어떻게 지내고 있어?";
            a.Money = 150000;

        }
    }
}
