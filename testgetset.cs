namespace checkgetset
{
    public class anumber
    {
        int num=100;
        public int Num {
            get{
                // no matter num as declair or this.num all works well.
                //return num;
                return this.num;
            }
            set{
                num=value;
            }
        }
    }
}