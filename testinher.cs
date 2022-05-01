namespace jjlib
{
    public class ExoticCoffee:Coffee{
        public string Country="VN";
        public void GetContryDetailed(){
            Console.WriteLine("which country");
        }
    }
    public class Coffee
    {
        public int color = 123;
        public int price = 10;
        public void GetMoreDetailed(){
            Console.WriteLine("get more detailed");
        }
    }
}