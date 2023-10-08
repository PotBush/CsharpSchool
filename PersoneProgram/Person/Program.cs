namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonClass persona1 = new PersonClass("Francesco", "Foschi", 02, 11, 2007);

            Console.WriteLine(persona1.CalculateAge(8, 10, 2023));
        }
    }
}
