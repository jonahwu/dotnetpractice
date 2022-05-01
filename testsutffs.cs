using InstanceDemo;
using ii=InstanceDemoInit;
namespace testall
{
    public class teststuffs
    {
        public void testObject(){

            DriversRun dr = new DriversRun();
            Console.WriteLine("instance conter");
            Console.WriteLine(dr.counter);
            //not working for static class
            //Drivers dr = new Drivers();
            
            
        }
        public void testInstanceInit(){
            ii.DriversRunInit iii = new ii.DriversRunInit();
            Console.WriteLine(iii.counter);
        }
    }
}