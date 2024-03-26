
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
            GiftBox addressA = GiftBoxMaker("A친구야 잘 지내지?", 110000);
            GiftBox addressB = GiftBoxMaker("B친구야 잘 지내지?", 120000);
            GiftBox addressC = GiftBoxMaker("C친구야 잘 지내지?", 130000);

            GiftBox[] giftBoxArr = new GiftBox[3];
            GiftBox giftBox = giftBoxArr[0];
            giftBoxArr[0] = addressA;
            giftBoxArr[1] = addressB;
            giftBoxArr[2] = addressC;
            Console.WriteLine("giftBix Array Count : " + giftBoxArr.Length);

            //List
            List<GiftBox> giftBoxList = new List<GiftBox>();
            giftBoxList.Add(addressA); //0
            giftBoxList.Add(addressB); //1
            giftBoxList.Add(addressC); //2

            Console.WriteLine(giftBoxList[2].Letter);
            Console.WriteLine("giftbox List Count : " + giftBoxList.Count);
        }

        private static GiftBox GiftBoxMaker(string letter, int money)
        {
            GiftBox addressA = new GiftBox()
            {
                Letter = letter,
                Money = money
            };
            
            return addressA;
        }
    }
}