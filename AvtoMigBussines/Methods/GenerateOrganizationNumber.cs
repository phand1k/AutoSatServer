namespace AvtoMigBussines.Methods
{
    public static class GenerateOrganizationNumber
    {
        public static string Generate()
        {
            Random rnd = new Random();
            string result = "";
            for (int i = 0; i < 12; i++)
            {
                int randomNumber = rnd.Next(1, 9);
                result += randomNumber.ToString();
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
