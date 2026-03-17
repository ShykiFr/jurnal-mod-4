using System.Globalization;

public class KodePaket
{
    public string getKodePaket(string namaPaket)
    {
        string[] namaPaketArr = { "Basic", "Standard", "Premium", "Unlimited", "Gaming", "Streaming", "Family", "Business", "Student", "Traveler" };

        string[] kodePaket = { "P201", "P202", "P203", "P204", "P205", "P206", "P207", "P208", "P209", "P210" };

        for (int i = 0; i < namaPaketArr.Length; i++)
        {
            if (namaPaketArr[i] == namaPaket)
            {
                return kodePaket[i];
            }
        }
        return "Kode paket tidak ditemukan";
    }
};

//public class Program
//{
//    public static void  Main(String[] args)
//    {
//        KodePaket kodePaket = new KodePaket();
//        while (true)
//        {
//            Console.Write("Nama paket: ");
//            string namaPaket = Console.ReadLine();
//            string kode = kodePaket.getKodePaket(namaPaket);

//            Console.WriteLine("Kode Paket: " + kode);
//            Console.WriteLine();
//        }
//    }
//}

public class MesinKopi
{
    enum State { OFF, STANDBY, MAINTENANCE, BREWING };
    public void stateMesinKopi()
    {
        State state = State.OFF;
        Console.WriteLine("State mesin kopi awal: " + state);
        Console.WriteLine("-------------------------------");
        string input;

        while (true)
        {
            switch (state)
            {
                case State.OFF:
                    Console.WriteLine("LIST OPSI " + state + ":");
                    Console.WriteLine("1. POWER_ON");
                    Console.WriteLine();
                    Console.Write("Pilih: ");
                    input = Console.ReadLine();

                    if (input == "POWER_ON")
                    {
                        Console.WriteLine("Mesin Off berubah menjadi Standby.");
                        Console.WriteLine("-");
                        state = State.STANDBY;
                        break;
                    }
                    break;
                case State.STANDBY:
                    Console.WriteLine("LIST OPSI " + state + ":");
                    Console.WriteLine("1. START_BREW\n2. START_MAINTENANCE\n3. POWER_OFF");
                    Console.WriteLine();
                    Console.Write("Pilih: ");
                    input = Console.ReadLine();

                    if (input == "START_BREW")
                    {
                        Console.WriteLine("Mesin Standby berubah menjadi Brewing.");
                        Console.WriteLine("-");
                        state = State.BREWING;
                        break;
                    }

                    if (input == "START_MAINTENANCE")
                    {
                        Console.WriteLine("Mesin Standby berubah menjadi Maintenance.");
                        Console.WriteLine("-");
                        state = State.MAINTENANCE;
                        break;
                    }

                    if (input == "POWER_OFF")
                    {
                        Console.WriteLine("Mesin Standby berubah menjadi Off.");
                        Console.WriteLine("-");
                        state = State.OFF;
                        break;
                    }
                    break;
                case State.BREWING:
                    Console.WriteLine("LIST OPSI " + state + ":");
                    Console.WriteLine("1. FINISH_BREW");
                    Console.WriteLine();
                    Console.Write("Pilih: ");
                    input = Console.ReadLine();

                    if (input == "FINISH_BREW")
                    {
                        Console.WriteLine("Mesin Brew berubah menjadi Standby.");
                        Console.WriteLine("-");
                        state = State.STANDBY;
                        break;
                    }
                    break;
                case State.MAINTENANCE:
                    Console.WriteLine("LIST OPSI " + state + ":");
                    Console.WriteLine("1. FINISH_MAINTENANCE");
                    Console.WriteLine();
                    Console.Write("Pilih: ");
                    input = Console.ReadLine();

                    if (input == "FINISH_MAINTENANCE")
                    {
                        Console.WriteLine("Mesin Maintenance berubah menjadi Standby.");
                        Console.WriteLine("-");
                        state = State.STANDBY;
                        break;
                    }
                    break;
            }
        }
    }
}

public class Program
{
    public static void Main(String[] args)
    {
        MesinKopi mesinKopi = new MesinKopi();
            mesinKopi.stateMesinKopi();
        

    }
}