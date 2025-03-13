using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace  JurnalMod4_103022300097
{
    class KodeProduk
    {
        private static readonly Dictionary<string, string> kodeProDict = new Dictionary<string, string>()
    {
        {"Laptop", "E100"},
        {"Smartphone", "E101"},
        {"Tablet", "E102"},
        {"Headset", "E103"},
        {"Keyboard", "E104"},
        {"Mouse", "E105"},
        {"Printer", "E106"},
        {"Monitor", "E107"},
        {"Smartwatch", "E108"},
        {"Kamera", "E109"}
    };
        public static string getKodeProduk(string namaProduk)
        {
            if (kodeProDict.ContainsKey(namaProduk))
            {
                return kodeProDict[namaProduk];
            }
            else
            {
                return "Produk tidak ditemukan";
            }
        }
    }
}

