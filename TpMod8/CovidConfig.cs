using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TpMod8
{
    class CovidConfig
    {
        public string satuan_suhu { get; set; } = "celcius";
        public int batas_hari_demam { get; set; } = 14;

        public string pesan_ditolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";

        public string pesan_diterima { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\Praktikum Konstruksi PL\\TpMod8\\TpMod8\\covid_config.json");
            CovidConfig config = JsonSerializer.Deserialize<CovidConfig>(jsonString);

            satuan_suhu = config.satuan_suhu;
            batas_hari_demam = config.batas_hari_demam;
            pesan_ditolak = config.pesan_ditolak;
            pesan_diterima = config.pesan_diterima;
        }

        public void SaveJSON()
        {
            string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("D:\\Praktikum Konstruksi PL\\TpMod8\\TpMod8\\covid_config.json", jsonString);
        }
        public void UbahSatuan()
        {
            satuan_suhu = (satuan_suhu == "celcius") ? "fahrenheit" : "celcius";
            ReadJSON();
        }

    }
}
