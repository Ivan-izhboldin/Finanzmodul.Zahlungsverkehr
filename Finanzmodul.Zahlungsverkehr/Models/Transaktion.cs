using System;

namespace Finanzmodul.Zahlungsverkehr.Models
{
    public class Transaktion
    {
        public string Iban { get; set; } = string.Empty;
        public decimal Betrag { get; set; }
        public DateTime Datum { get; set; }
        public bool IstValide { get; set; } = true;
        public string ValidierungsMeldung { get; set; } = string.Empty;
    }
}