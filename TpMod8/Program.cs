// See https://aka.ms/new-console-template for more information
using TpMod8;

class Program
{
    static void Main()
    {
        CovidConfig config = new CovidConfig();
        config.UbahSatuan();

        Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai<celcius>");
        double suhu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int hari = Convert.ToInt32(Console.ReadLine());

        bool kondisiSesuai = false;
        if (config.satuan_suhu == "celcius")
        {
            kondisiSesuai = suhu >= 36.5 && suhu <= 37.5;
        }
        else if (config.satuan_suhu == "fahrenheit")
        {
            kondisiSesuai = suhu >= 97.7 && suhu <= 99.5;
        }

        if (kondisiSesuai && hari < config.batas_hari_demam)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }
    }

}