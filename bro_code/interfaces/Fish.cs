using interfaces;

    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish flees.");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish hunts.");
        }
    }