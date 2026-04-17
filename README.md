Financial Module: Payment Transaction Validation

This project is a C#-based desktop application developed as part of a final project for the "Fachinformatiker Anwendungsentwicklung" qualification. It provides an automated solution for validating and processing large volumes of payment transaction data.
Key Features

    Automated CSV Import: Efficiently parses transaction lists in CSV format.

    Comprehensive Data Validation: * IBAN Check: Verification of country codes and checksums according to ISO 7064.

        Amount Verification: Logical checks for valid numerical values.

        Date Validation: Checks for plausible transaction dates (no future dates).

    WPF-based GUI: A modern user interface using Windows Presentation Foundation (WPF) with a DataGrid for real-time visualization.

    Visual Error Highlighting: Invalid records are automatically highlighted in red for quick identification.

    GDPR Compliance: The application operates entirely offline and locally to ensure the protection of sensitive financial data.

Technical Stack

    Language: C# 

    Framework: .NET / WPF 

    Architecture: MVVM (Model-View-ViewModel) for clean separation of logic and UI.

    Testing: Unit Tests implemented with xUnit.

    
    
    
    
    Finanzmodul: Validierung von Zahlungsverkehrsdaten

Dieses Projekt ist eine C#-basierte Desktop-Anwendung, die im Rahmen der Abschlussprüfung zum Fachinformatiker für Anwendungsentwicklung realisiert wurde. Es dient der automatisierten Validierung und Verarbeitung von umfangreichen Zahlungsverkehrsdaten.
Hauptfunktionen

    Automatisierter CSV-Import: Robustes Einlesen von Transaktionslisten im CSV-Format.

    Umfangreiche Datenvalidierung:

        IBAN-Prüfung: Validierung nach ISO 7064 (Ländercode und Prüfziffer).

        Betragsprüfung: Logische Prüfung auf valide numerische Werte.

        Datumsprüfung: Validierung auf fachliche Plausibilität (keine Zukunftswerte).

    WPF-Benutzeroberfläche: Moderne GUI mittels Windows Presentation Foundation (WPF) zur performanten Darstellung der Daten im DataGrid.

    Optische Fehlerhervorhebung: Fehlerhafte Datensätze werden automatisch farblich (rot) markiert.

    DSGVO-Konformität: Die Anwendung arbeitet vollständig lokal und offline, um den Schutz sensibler Finanzdaten zu gewährleisten.

Technologien

    Sprache: C# 

    Framework: .NET / WPF 

    Architektur: MVVM-Muster (Model-View-ViewModel) zur sauberen Trennung von Geschäftslogik und UI.

    Qualitätssicherung: Modultests mittels xUnit.