namespace app_check
{
    public class testcheck
    {
        static string a { get; set; } //= "5";
        static List<string> hahaList = new List<string>();
        public static void Checksomething()
        {
            checkNull();
            a = "5";
            checkNull();
            checkList();

            checkInt(3);
            checkString("");
            checkDict();
        }
        private static void checkDict()
        {
            Dictionary<string, string> aa = new Dictionary<string, string>();
            Console.WriteLine("Dict" + aa.Count);
            if (aa.Count == 0)
            {
                Console.WriteLine("Dict is NUll");
            }
            else
            {
                Console.WriteLine("Dict is NOT null");
            }
            aa.Add("keyaa", "valuebb");
            if (aa.Count == 0)
            {
                Console.WriteLine("Dict is NUll");
            }
            else
            {
                Console.WriteLine("Dict is NOT null");
            }
        }

        private static void checkString(string ss)
        {

            if (String.IsNullOrEmpty(ss))
            {
                Console.WriteLine("SS is NULL");
            }
            else
            {
                Console.WriteLine("SS in NOT Null");
            }
        }

        private static void checkInt(int aa)
        {

            if (aa == null)
            {
                Console.WriteLine("INT it's a null");
            }
            else
            {
                Console.WriteLine("INT it's not a null");
            }
        }

        private static void checkNull()
        {
            //a="10";
            if (a == null)
            {
                Console.WriteLine("it a null");
            }
            else
            {
                Console.WriteLine("it's NOT a null");
            }
        }

        private static void checkList()
        {

            if (hahaList is null)
            {
                Console.WriteLine("list is right" + hahaList.Count);
            }
            else
            {
                Console.WriteLine("list not Null" + hahaList.Count);
            }
        }
    }
}