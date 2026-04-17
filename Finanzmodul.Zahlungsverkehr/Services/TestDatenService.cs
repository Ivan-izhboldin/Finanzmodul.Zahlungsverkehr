using System;
using System.IO;
using System.Text;

namespace Finanzmodul.Zahlverkehr.Services
{
    public class TestDatenService
    {
        public void GeneriereTestCsv(string dateipfad)
        {
            // Erstellt 1000 Testdatensätze für die Qualitätssicherung
            var sb = new StringBuilder();
            sb.AppendLine("IBAN;Betrag;Datum");

            var rnd = new Random();

            for (int i = 1; i <= 1000; i++)
            {
                // Jede 5. Zeile ist fehlerhaft für den Validierungstest
                bool istFehlerhaft = (i % 5 == 0);

                string iban = istFehlerhaft ? "RU12345" : $"DE{rnd.Next(10, 99)}700033110011223344";
                string betrag = istFehlerhaft ? "-500,00" : $"{rnd.Next(1, 10000)},50";
                string datum = istFehlerhaft ? "01.01.2030" : DateTime.Now.ToString("dd.MM.yyyy");

                sb.AppendLine($"{iban};{betrag};{datum}");
            }

            File.WriteAllText(dateipfad, sb.ToString(), Encoding.UTF8);
        }
    }
}