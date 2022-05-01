namespace Share
{
    public class Account
    {
        //private static int _money;
        // it will share the money variable if creating multiple instance
        private static int _money;
        //it wiil NOT share money variable, each instance is independence.
        //private int _money;

        public int Money{
            get => _money;
            set => _money = value;
        }
        
    }
}