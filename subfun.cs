using driver.num;
using GlobalVarDemo;
using sqldriver = GlobalVarDemo;
namespace subfun.cal1
{
    public class Calsome
    {
        public void CalExp(){
            Console.WriteLine("where global counter is:"+Drivers.counter);
            Console.WriteLine("another way to use using:"+sqldriver.Drivers.counter);
            //int a = 1 + Globals.counter; 
        }
    }
}