# ProgettoFinale — Gestione Università (WinForms, .NET 8)

Desktop app per la gestione **studenti, docenti, corsi ed esami** sviluppata con **Windows Forms** su **.NET 8**.  
I dati sono salvati su semplici file **JSON** (vedi cartella `Progetto/Universita`).

> 🇮🇹 Questo README è in italiano per coerenza con i nomi delle form. Se vuoi, posso generare anche la versione 🇬🇧 in inglese.

## ✨ Funzionalità principali

- **Studenti**: creazione, modifica, eliminazione, consultazione
- **Docenti**: creazione, modifica, eliminazione, consultazione
- **Corsi**: registrazione/assegnazione, modifica dettagli, archivio
- **Esami**: gestione sessioni e appelli
- **Archivio**: consultazione storica dei dati
- **Storage**: persistenza su file JSON (`Universita/*.json`)

_Form principali rilevate:_ `Main Menu`, `Registrazione`, `Registrazione Corso`, `Modifica Studenti`, `Modifica Docenti`, `Modifica Corso`, `Dettagli Corso`, `Gestione Esami`, `Archivio`.

## 🧱 Tech stack

- **.NET 8** (SDK 8.x)
- **Windows Forms**
- **C# 12**
- **System.Text.Json** per la serializzazione su file

## 🖥️ Requisiti

- **Windows 10/11**
- **Visual Studio 2022** (consigliato 17.8+) con workload **.NET Desktop Development**  
  _oppure_ **.NET SDK 8** per build da CLI
- Permessi di lettura/scrittura sulla cartella `Universita/`

## 🚀 Avvio rapido

### Opzione A: Visual Studio
1. Clona o scarica il progetto.
2. Apri la soluzione:  
   `Progetto/Progetto Finale/ProgettoFinale/ProgettoFinale.sln`
3. Imposta **ProgettoFinale** come progetto di avvio (se non già impostato).
4. **F5** per eseguire.

### Opzione B: .NET CLI
```bash
# Posizionati nella cartella del progetto WinForms
cd "Progetto/Progetto Finale/ProgettoFinale/ProgettoFinale"

# Ripristino e build
dotnet restore
dotnet build -c Release

# Esecuzione
dotnet run
```

> Assicurati che la cartella `Universita/` sia **allo stesso livello** di `Progetto Finale/` (come nel pacchetto originale), così il programma trova i file JSON.

## 📂 Struttura del repository

```
Progetto/
  Progetto Finale/
    ProgettoFinale/
      ProgettoFinale.sln
      ProgettoFinale/
        ProgettoFinale.csproj
        Program.cs
        Main Menu.cs
        Gestione Esami.cs
        Registrazione.cs
        Registrazione Corso.cs
        Modifica Studenti.cs
        Modifica Docenti.cs
        Modifica Corso.cs
        Dettagli Corso.cs
        Archivio.cs
        *.Designer.cs
        *.resx
  Universita/
    Studenti.json
    Docenti.json
    Corsi.json
    Esame.json
```

## 📁 Dati (JSON)

I file dati si trovano in `Progetto/Universita/`:
- `Studenti.json`
- `Docenti.json`
- `Corsi.json`
- `Esame.json`

Sono editabili a mano (UTF‑8). Fai sempre un backup prima di modificare.

## 🔧 Configurazione & Note

- Il progetto usa il **target framework**: `net8.0-windows` e **UseWindowsForms=true** (`ProgettoFinale.csproj`).
- Se sposti le cartelle, verifica eventuali **percorsi relativi** usati per i JSON (in caso, aggiorna il codice dove vengono letti/scritti).
- Se Visual Studio segnala errori di designer, chiudi e riapri la soluzione e assicurati di avere l’SDK 8 installato.

## 🧪 Build di produzione

```bash
cd "Progetto/Progetto Finale/ProgettoFinale/ProgettoFinale"
dotnet publish -c Release -r win-x64 --self-contained false -p:PublishSingleFile=true -o ./publish
```
L’eseguibile sarà in `publish/`. Distribuisci anche la cartella `Universita/` con i JSON.

## 🗺️ Roadmap (idee)
- Validazioni avanzate dei campi (email, telefono, duplicati)
- Ricerca e filtri per liste studenti/docenti/corsi
- Backup/restore automatico dei JSON
- Esportazione report (CSV/PDF)
- Logging degli errori
- Passaggio a un database leggero (es. SQLite) mantenendo compatibilità

## 🐞 Problemi noti
- Se la cartella `Universita/` non è presente o accessibile, le operazioni di lettura/scrittura falliranno.
- Alcune form potrebbero dipendere da risorse del designer: non rinominare arbitrariamente i file `*.Designer.cs`/`*.resx`.

## 🤝 Contributi
1. Fai un fork
2. Crea un branch: `git checkout -b feature/nome-feature`
3. Commit: `git commit -m "Aggiunge XYZ"`
4. Push: `git push origin feature/nome-feature`
5. Apri una Pull Request

##Author
Abdelrahman Salaheldin
