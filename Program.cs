namespace BasicCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flipcoin flipcoin = new Flipcoin();
          flipcoin.FlipcoinNumber();


            Leapyear leapyear = new Leapyear();
            leapyear.LeapyearNumber();

            Power power = new Power();
            power.PowerNumber();

        }
    }
}