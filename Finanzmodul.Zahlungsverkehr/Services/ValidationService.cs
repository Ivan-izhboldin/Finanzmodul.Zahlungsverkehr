using System;
using System.Text.RegularExpressions;
using Finanzmodul.Zahlungsverkehr.Models;

namespace Finanzmodul.Zahlungsverkehr.Services
{
    public class ValidationService
    {
        public void Validieren(Transaktion t)
        {
            // 1. IBAN Check (Einfaches Muster für DE + 20 Ziffern)
            var ibanRegex = new Regex(@"^DE\d{20}$");
            if (string.IsNullOrWhiteSpace(t.Iban) || !ibanRegex.IsMatch(t.Iban))
            {
                SetzeFehler(t, "Ungültiges IBAN-Format");
                return;
            }

            // 2. Betrag Check
            if (t.Betrag <= 0)
            {
                SetzeFehler(t, "Betrag muss größer als 0 sein");
                return;
            }

            // 3. Datum Check (Darf nicht in der Zukunft liegen)
            if (t.Datum > DateTime.Now)
            {
                SetzeFehler(t, "Datum liegt in der Zukunft");
                return;
            }

            // Wenn alles okay ist
            t.IstValide = true;
            t.ValidierungsMeldung = "OK";
        }

        private void SetzeFehler(Transaktion t, string meldung)
        {
            t.IstValide = false;
            t.ValidierungsMeldung = meldung;
        }
    }
}