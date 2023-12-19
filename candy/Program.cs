namespace candy
{
    internal class Program
    {
        struct Candy
        {
            public int manufacter;
            public int type;
            public int price;
        }

        static string dataInput ()
        {
            string inputText = Console.ReadLine ();
            return inputText; 
        }

        static string splitData(string inputText)
        {
            inputText.Split(" ");
            return inputText;
        }

        static Candy[] candyBlockCreate(int count)
        {
            string inputText;
            Candy[] block = new Candy[count + 1];
            for (int i = 1; i <= count; i++)
            {
                inputText = dataInput();
                string row = splitData(inputText);
                block[i].manufacter = row[0];
                block[i].type = row[1];
                block[i].price = row[2];
            }
            return block;

        }

        static void Main(string[] args)
        {
            string input = dataInput ();
            string split = splitData (input);
            int sale = Convert.ToInt32(split[0]);
            int manfCount = Convert.ToInt32(split[1]);
            int typeCount = Convert.ToInt32(split[2]);

            Candy[] candies = candyBlockCreate(sale);

            //1. feladat
            int manfOfMinPr = 0;
            int typeOfMinPr = 0;
            for (int i = 1; i <= sale; i++)
            {
                if (candies[i].price < candies[i+1].price)
                {
                    manfOfMinPr = i;
                    
                }
            }
            


        }
    }
}