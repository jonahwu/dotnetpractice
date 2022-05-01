using System.Threading.Tasks;
using testmath;
namespace app_parallel
{
    public class HeavyCalAsync
    {
        public  async Task<int> RunTasksAsync(){
            Console.WriteLine(" start job1 ");      
            Task<int> tk1 = Run10SecAsync();
            Console.WriteLine(" start job2");
            Task<int> tk2 = Run5SecAsync();
            Console.WriteLine(" now job was running on parallel");
            await tk1;
            Console.WriteLine("job1 is ready:"+tk1.Result.ToString());
            await tk2;
            
            Console.WriteLine("job2 is ready:"+tk2.Result.ToString());
            Console.WriteLine("done");
            return 0;
        }
        public int RunSecs(int TimeSecs){
            // we might change to some class method
            var tk10=new Expmath(TimeSecs);
            tk10.Run();
            return 0;
        }

        public  async Task<int> Run10SecAsync(){
            // must need task.run, if NOT cpu bound will cause blocking... so shit.
            // and it's reasonable any async function declaired need a await.
            // 
            await Task.Run(()=>{
                // here just run a "normal" function, method or calculation
                // so we need define Run10Sec() that is a normal funtion.
                // and we then declared a Async function writtern as above and put 
                // normal function inside here.
                // since all the async as a fine tune code, that all comes from a normal code.
                /*
                    var tk10=new Expmath(10);
                    tk10.Run();
                */
                RunSecs(10);
                
            });
            /*
            var t =  await Task.Run(() => {  
                var Times = 10;
                double ss=0.0;
                Console.WriteLine("show times:"+Times);
                for (int f=0; f<Times;f++){
                for (int s=0; s<100;s++)
                    for (int j=0; j<1000;j++)
                    {
                        for (int i=0;i<1000;i++){
                        double a=1.3;
                        double y=(double)(i);
                        ss=ss+Math.Exp(a/y);
                    }

                    }
                }
              return 0;  
            }  );

            */
            
        
//var result = await Task.Run(() => value * 1.2f);
        // here is return
        return 10;

        }

       public  async Task<int> Run5SecAsync(){
            
            await Task.Run(()=>{

                    var tk5=new Expmath(5);
                    tk5.Run();
                
            });

            /*
            var t = await Task.Run(()=>{
                    var tk5=new Expmath(5);
                    tk5.Run();
                return 0;
            });
            */

           /*
                var t =  await Task.Run(() => {  
                var Times = 10;
                double ss=0.0;
                Console.WriteLine("show times:"+Times);
                for (int f=0; f<Times;f++){
                for (int s=0; s<100;s++)
                    for (int j=0; j<1000;j++)
                    {
                        for (int i=0;i<1000;i++){
                        double a=1.3;
                        double y=(double)(i);
                        ss=ss+Math.Exp(a/y);
                    }

                    }
                }
              return 0;  
            }  );
            */
            //here is return
            return 5;
       }

    }
}
    