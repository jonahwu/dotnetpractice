namespace app_getset
{
    public class testgetset
    {
        // it's a simple delaire that we can get set the Score without more definition.
        // if just use = or read just use the following statement.
        public int SimpleScore {get; set;}
        // or with some operation while return
        // if now simple you might need more description shown as followed

        int score;
        public int Score{
            get{
                var pp= this.score +1;
             return pp;
              }
            set {
                this.score = value;
            }
              
        }
        // if now simple you might need more description shown as followed --end

        public void ShowScore(){
            // one can use this. to make sure used the variable. If you are not make sure
            Console.WriteLine("here is the score with this statement"+this.Score);
            
            Console.WriteLine("here is the score"+ Score);
        }   
    }
}