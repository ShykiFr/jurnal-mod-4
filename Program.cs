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

public class Program
{
    public static void  Main(String[] args)
    {
        KodePaket kodePaket = new KodePaket();
        while (true)
        {
            Console.Write("Nama paket: ");
            string namaPaket = Console.ReadLine();
            string kode = kodePaket.getKodePaket(namaPaket);

            Console.WriteLine("Kode Paket: " + kode);
            Console.WriteLine();
        }
    }
}
