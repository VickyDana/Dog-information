namespace Dog_information
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string DogName = "Nik";
            string DogBreed = "Golden Retriever";
            int DogAge = 5;
            double DogWeight = 67.22;
            bool DogSpayed = true;
           
            Console.WriteLine(" The name of the dog is " + DogName);
            Console.WriteLine( " My dog's breed type is " + DogBreed);
            Console.WriteLine(" Nik is " + DogAge + " years");
            Console.WriteLine(" Nik weighs " + DogWeight + " kg");
            Console.WriteLine(" Is Nik spayed true or false? " + DogSpayed);

            Console.ReadKey();
        }
    }
}
