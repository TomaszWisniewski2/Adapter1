using System;

namespace Adapter

{
    public interface Butelka
    {
        string GetRequest();
    }

    class Szklanka
    {
        public string GetSpecificRequest()
        {
            return "Wypij";
        }
    }
    class Przelej : Butelka
    {
        private readonly Szklanka _szklanka;

        public Przelej(Szklanka szklanka)
        {
            this._szklanka = szklanka;
        }

        public string GetRequest()
        {
            return $"This is '{this._szklanka.GetSpecificRequest()}'";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Szklanka Szklanka = new Szklanka();
            Butelka target = new Przelej(Szklanka);

            Console.WriteLine("Nie możemy pić ze szklanki gdyż nie mamy jak przelać wody");
            Console.WriteLine("Adapter przelej pozwala nam na przelanie :)");

            Console.WriteLine(target.GetRequest());
        }
    }
}
