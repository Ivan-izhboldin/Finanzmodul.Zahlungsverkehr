using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Finanzmodul.Zahlungsverkehr.Models;

namespace Finanzmodul.Zahlungsverkehr.Services
{
    public class CsvService
    {
        public List<Transaktion> ImportiereAusCsv(string dateipfad)
        {
            var liste = new List<Transaktion>();

            // Öffnet die Datei zum Lesen
            using (var reader = new StreamReader(dateipfad))
            {
                // Überspringe die Kopfzeile (Header)
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var zeile = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(zeile)) continue;

                    var spalten = zeile.Split(';');

                    // Erstellung des Objekts aus den CSV-Spalten
                    var t = new Transaktion
                    {
                        Iban = spalten[0],
                        // Nutzt InvariantCulture für universelles Zahlenformat (Punkt/Komma)
                        Betrag = decimal.Parse(spalten[1], CultureInfo.InvariantCulture),
                        Datum = DateTime.Parse(spalten[2])
                    };

                    liste.Add(t);
                }
            }
            return liste;
        }
    }
}