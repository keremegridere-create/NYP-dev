    internal class Program
    {
        static void Main(string[] args)
        {
            bool ekipmanOdunçte = false;
            Console.Write(" Ödünç almak istediğiniz gün sayısını girin(1-7): ");
            string gunStr = Console.ReadLine();

            if (ekipmanOdunçte)
            {
                Console.WriteLine( "isteğiniz reddedildi: Ekipman şu an ödünçte!");

            }
            else if (!int.TryParse(gunStr,out int gun))
            {
                Console.WriteLine("Geçersiz giriş! Lütfen 1 ile 7 arasında bir sayı girin.");

            }
            else
            {
                if(gun >= 1 && gun <= 7)
                {
                    Console.WriteLine( "isteğiniz kabul edildi:{gun} günlüğüne verildi");
                }
                else
                {
                    Console.WriteLine( "isteğiniz reddedildi: Gün sayısı 1 ile 7 arasında olmalıdır.");
                }
            }
        }
    }
}
