Eplanwiki.Eplan.AddIn.RemovePlaceholder
=======================================

Eplan P8 Add-In mit einer Action zum löschen von Platzhalterobjekten mit einem bestimmten Wertesatznamen

- Actionname:     RemovePlaceholderWithRecord 
- Parameter:      recordname
- Aufrufbeispiel: RemovePlaceholderWithRecord /recordname:"EEC"
- Ergebnis:       Alle Platzhalterobjekte im aktiven Projekt welche einen Wertesatz mit dem Namen EEC haben werden gelöscht.
- Hinweis:        Für das Add-In ist eine API-Lizenz nötig.

Anleitung
- Projekt runterladen und in Projektordner der C# IDE entpacken
- Pfad für die Verweise auf die Eplan Bibliotheken ggf. korrigieren
- Projektmappe erstellen (Kompilieren), Zielplattform sollte auf x86 stehen
- Datei Eplanwiki.Eplan.AddIn.RemovePlaceholder.dll in das Eplan bin\ Verzeichnis kopieren (Schreibrechte notwendig)
- Datei Eplanwiki.Eplan.AddIn.RemovePlaceholder.dll in Eplan als AddIn laden (Dienstprogramme>>Add-Ins..)
- Action wie im Aufrufbeispiel über Toolbar-Button etc. aufrufen.


!!!!ANWENDUNG AUF EIGENE GEFAHR!!!!
Ausführung kann weder abgebrochen noch über die Rückgängig-Funktion reversiert werden.
