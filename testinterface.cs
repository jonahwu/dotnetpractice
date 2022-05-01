using CsharpInterface;


namespace CsharpInterface {

  interface IPolygon {
    // method without body
    // you can not just decliard int aa must with {get; set};
    int aa {get;set;}
    void calculateArea(int l, int b);
    void calculateSome();

  }
}


namespace app_interface
{
    // that's why we need interface, IDE will show something wrong, and mention that you are 
    // not complete the interface driver. great !!! and compile failed if not fully satisfy the 
    // definition of the interface as 
    //'testinterface' 未實作介面成員 'IPolygon.calculateSome()'
    public class testinterface: IPolygon
    {
        
        public int aa{get; set;}
        
        public void calculateArea(int l, int b){
            Console.WriteLine("into the interface declaire");
        }
        
        public void calculateSome(){
            Console.WriteLine("filled more declaired from interface, and now it can be compiled success");
        }
        
 
    }
  
}