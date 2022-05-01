using System;
using driver.num;
using subfun.cal1;
using GlobalVarDemo;
using share = Share;
using ta = testall;
using gt = checkgetset;
using testmath;
using app_parallel;
using jjlib;
using app_getset;
using utils=app_lib;
using oneutils=app_lib.testlib;
using ck=app_check.testcheck;

namespace InstanceDemoInit
{
    // static class to hold global variables, etc.
    class DriversRunInit
    {
        // global int or a driver the connect to some database
        //public static int counter;
        //can not use static while class is not static
        public int counter;
        // here is the init function in a class
        public DriversRunInit(){
            Console.WriteLine("now i am init");
        }
        

        // global function
        // where s is not necessary; but we always need some parameters to initiate a driver.
        //also public void cannnot be static
        public void InitData(int s){
        
            counter = s;
        }
        public static string HelloWorld()
        {
            return "Hello World";
        }
    }
}

namespace InstanceDemo
{
    // static class to hold global variables, etc.
    class DriversRun
    {
        // global int or a driver the connect to some database
        //public static int counter;
        //can not use static while class is not static
        public int counter;
        

        // global function
        // where s is not necessary; but we always need some parameters to initiate a driver.
        //also public void cannnot be static
        public void InitData(int s){
            counter = s;
        }
        public static string HelloWorld()
        {
            return "Hello World";
        }
    }
}


namespace GlobalVarDemo
{
    // static class to hold global variables, etc.
    static class Drivers
    {
        // global int or a driver the connect to some database
        //public static int counter;
        public static int counter;

        // global function
        // where s is not necessary; but we always need some parameters to initiate a driver.
        public static void InitData(int s){
            counter = s;
        }
        public static string HelloWorld()
        {
            return "Hello World";
        }
    }
}


namespace MyApp // Note: actual namespace depends on the project name.
{
    
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //simdriver a = new simdriver(); 
            //a.Getnum();
            //a.Putnum();
            Drivers.InitData(900);
            Console.WriteLine("get the initial state of a global variable:"+Drivers.counter);
            Drivers.counter=3;
            Calsome cm = new Calsome();
            cm.CalExp();
            Drivers.counter=5;
            cm.CalExp();
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(a.Getnum());
            ///-------------------------------///
            share.Account ac1 = new share.Account();
            share.Account ac2 = new share.Account();
            ac1.Money=ac1.Money+10;
            Console.WriteLine("ac1 +10: now ac1 money is:"+ac1.Money);
            Console.WriteLine("and ac2 money is:"+ac2.Money);
            ac2.Money=ac2.Money-10;
            Console.WriteLine("for share money now the money is:");
            Console.WriteLine(ac1.Money);
            Console.WriteLine(ac2.Money);
            
            ta.teststuffs tt = new ta.teststuffs();
            tt.testObject();
            tt.testInstanceInit();
            

            gt.anumber ga = new gt.anumber();
            ga.Num=3;
            Console.WriteLine(ga.Num);
            //math
            // almost is 1 sec
            Expmath em= new Expmath(3);
            em.Run();

            
            Console.WriteLine(" Running Parallel job");
            var tks = new HeavyCalAsync();
            Task<int> tkss = tks.RunTasksAsync();
            await tkss;
            // inherence lib test
            var co = new ExoticCoffee();
            Console.WriteLine(co.color);
            // try get set
            var ttg = new testgetset();
            ttg.Score=10;
            Console.WriteLine("here is the get set value:"+ ttg.Score);
            Console.WriteLine("here is class funciton Score:");
            ttg.Score=11;
            ttg.ShowScore();

            // just access lib
            utils.testlib.Output("some");
            //using oneutils=app_lib.testlib; you then can simplly use the statement, simple.
            oneutils.Output("some");
            // start check something 
            ck.Checksomething();

        }
    }
}