namespace Task1
{
   class Cat
    {
        public string Name { get; set; }
        public int Years { get; set; }
        public void Say()
        {
            Console.WriteLine("The cat's name is {0} and is {1} years old.", Name, Years);
        }
    }
}