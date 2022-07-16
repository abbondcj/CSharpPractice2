namespace CSharpPractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate a new string array
            string[] names = new string[4];
            // initialize a new string array by specifying data types
            string[] animals = new string[] { "Triceraptops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            List<string> dinosaurs = new();
            int length = dinosaurs.Count;
            dinosaurs.Add("T Rex");
            dinosaurs.Add("Velociraptor");
            dinosaurs.Add("Stegasaurus");
            length = dinosaurs.Count;

            List<string> dinosaurs_copy = dinosaurs.Select( animal => animal + "!").ToList();

            foreach (var new_dinosaur in dinosaurs_copy)
            {
            Console.WriteLine(new_dinosaur);
            }

            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}