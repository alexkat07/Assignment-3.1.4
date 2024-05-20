namespace Assignment_3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int userX;
            int userY;
            while (true) 
            {
                Console.WriteLine("Please pick an x coordinate");
                if (int.TryParse(Console.ReadLine(), out userX)) 
                {
                    
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid number. Try again.");
                }


            }
            while (true) 
            {
                Console.WriteLine("Please pick an y coodinate");
                if (int.TryParse(Console.ReadLine(), out userY))
                {
                    
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid number. Try again.");
                }
            }
            

            

          
            

            int quad = CoordinateLocation(userX, userY);

            string[] nums = { "None", "First", "Second", "Thrid", "Fourth" };

            Console.WriteLine($"The coordinate point ({userX},{userY}) lies in the {nums[quad]} quadrant");
        }

        static int CoordinateLocation(int x, int y) 
        {
            int quadrant;
        
            if (x > 0 && y > 0)
            {
                quadrant = 1;
            }
            else if (x > 0 && y < 0)
            {
                quadrant = 4;
            }
            else if (x < 0 && y > 0)
            {
                quadrant = 2;
            }
            else if (x < 0 && y < 0)
            {
                quadrant = 3;
            }

            else quadrant = 0;
            return quadrant;
        }
    }
}
