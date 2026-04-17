using Finanzmodul.Zahlungsverkehr.Models;
using Finanzmodul.Zahlungsverkehr.Services;
using Finanzmodul.Zahlverkehr.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Finanzmodul.Zahlungsverkehr
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Phase 4: Automatische Generierung von Testdaten fuer die Qualitaetssicherung
            InitializeTestData();
        }

        private void InitializeTestData()
        {
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test_1000.csv");
                if (!File.Exists(path))
                {
                    var testService = new TestDatenService();
                    testService.GeneriereTestCsv(path);
                }
            }
            catch
            {
                // Fehler bei Testgenerierung werden ignoriert
            }
        }

        private void BtnImport_Click(object sender, RoutedEventArgs e)
        {
            // Initialisierung des Dateidialogs fuer den CSV-Import
            OpenFileDialog dialog = new OpenFileDialog { Filter = "CSV Dateien (*.csv)|*.csv" };

            if (dialog.ShowDialog() == true)
            {
                try
                {
                    var loader = new CsvService();
                    var validator = new ValidationService();

                    // Phase 3: Implementierung der Import-Funktion und Validierungslogik
                    List<Transaktion> daten = loader.ImportiereAusCsv(dialog.FileName);

                    foreach (var item in daten)
                    {
                        validator.Validieren(item);
                    }

                    // Datenbindung an das DataGrid zur Anzeige der Ergebnisse
                    DgvTransaktionen.ItemsSource = daten;
                    TxtStatus.Text = $"{daten.Count} Datensaetze erfolgreich verarbeitet.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Importvorgang: " + ex.Message, "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}