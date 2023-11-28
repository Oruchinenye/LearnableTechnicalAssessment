namespace TechnicalTest
{
    class Program
    {
        static void Main()
        {
            int[] array = { 5, 4, 5, 4, 5, 4, 4, 5, 3, 3, 2, 2, 1, 5 };
            int n = 2;

            NthMostRateSignature(array, n);

        }

        public static void NthMostRateSignature(int[] list, int n)
        {
            Dictionary<int, int> items = new();
            List<int> nthRarestItems = new List<int>();
            try
            {
                foreach (var item in list)
                {
                    if (items.ContainsKey(item))
                    {
                        items[item]++;
                    }
                    else
                    {
                        items[item] = 1;
                    }
                }

                var nthRarestCount = items.OrderBy(v => v.Value)
                                                  .ElementAt(n - 1)
                                                  .Value;

                nthRarestItems = items.Where(v => v.Value == nthRarestCount)
                                                 .Select(v => v.Key)
                                                 .ToList();
                Console.WriteLine($"The {n}th rarest item(s) is/are: {string.Join(", ", nthRarestItems)}");
            }
            catch
            {
                Console.WriteLine("Out of range");
            }

        }
    }

}
