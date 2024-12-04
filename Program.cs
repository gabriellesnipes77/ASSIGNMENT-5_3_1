namespace ASSIGNMENT_5_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1)); //Output: True
            Console.WriteLine(CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 2)); //Output: False
        }
    }
    
    
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                //Check if the current plot is empty and the adjacent plots are also empty or out of bounds
                if (flowerbed[i] == 0 &&
                    (i == 0 || flowerbed[i - 1] == 0) && //No flower on the left side 
                    (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)) // No flower on the right side
                {
                    flowerbed[i] = 1; //plant a flower here
                    count++; //Increment the count of flowers planted
                    if (count >= n) //if we have planted enough flowers, return true
                    {
                        return true;
                    }
                    i++; //Skip the next plot to ensure no adjacent flowers are planted
                }
            }
            return count >= n; //If we managed to plant 'n' flowers, return true, else false
        }
    }
}
