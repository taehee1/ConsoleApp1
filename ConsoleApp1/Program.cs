using ConsoleApp1;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("시작부문");

            int aMoney = 10000;
            int bMoney = aMoney;
            aMoney = 20000;
            Console.WriteLine("aMoney : " + aMoney);
            Console.WriteLine("bMoney : " + bMoney);

            GiftBox aGiftBox = new GiftBox()
            {
                Letter = "안녕",
                Money = 10000
            };

            GiftBox bGiftBox = aGiftBox;
            aGiftBox.Money = 20000;
            Console.WriteLine("aGiftBox : " + aGiftBox.Money);
            Console.WriteLine("bGiftBox : " + bGiftBox.Money);
        }
    }
}
