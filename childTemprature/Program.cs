namespace childTemprature
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" welcome to child temprature app ");
            //ask user to enter temprature
            Console.WriteLine("please enter temprature");
            //read temprature
            double temprature = 0;
            bool isCnverted = double.TryParse(Console.ReadLine(), out temprature);
            //if
            if (temprature == 37 || temprature == 37.5)
            {
                Console.WriteLine("The child's temperature is good.");
            }

            else
            {
                Console.WriteLine("The child's temperature is bad.");

            }
        }
    }
}
