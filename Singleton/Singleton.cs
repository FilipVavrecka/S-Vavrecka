namespace Singleton1
{
    class Singleton
    {
        private static Singleton? instance;
        private Singleton() {}

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public void ShowMessage()
        {
            Console.WriteLine("Singleton zprava");
        }
    }

    
}