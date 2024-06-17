namespace MagicVilla_VillaAPI.Logging
{
    public class LoggingV2 : ILogging
    {
        public void Log(string message, string type)
        {
            if (type == "error")
            {
                Console.BackgroundColor = ConsoleColor.Red;  //Hata verirken dikkat çekici kırmızı kullan
                Console.WriteLine("ERROR - " + message);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                if (type == "warning")
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("ERROR - " + message);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
