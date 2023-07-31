/*write a program that reads 5 numbers from user. demonstrate concept of 
indexoutofrange exception*/



namespace consoleapplication5
{
    class l4p2
    {
        static void main(string[] args)
        {

            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("element - {0} : ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.WriteLine(array[10]);
            }

            catch (exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
