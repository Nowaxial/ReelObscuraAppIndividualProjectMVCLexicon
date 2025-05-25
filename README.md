# Reel Obscura 🎬

> En modern webbapplikation för att hantera din personliga filmsamling

![Reel Obscura Logo](ReelObscuraAppIndividualProjectMVCLexicon\ReelObscuraApp.Web\wwwroot\images\Reel_Obscura.png)

## Översikt

Reel Obscura är en intuitiv webbapplikation som låter dig organisera och hantera din filmsamling. Med en filmtematisk design och modern funktionalitet kan du enkelt lägga till, visa, redigera och organisera dina favoritfilmer.

## ✨ Huvudfunktioner

### Filmhantering
- **Lägg till filmer** med komplett metadata (titel, år, skådespelare, beskrivning)
- **Visa filmsamling** i responsivt rutnät eller listformat
- **Detaljerade filmvyer** med trailers, IMDB-länkar och skådespelarinformation
- **Redigera filminformation** med förfylld data
- **Ta bort filmer** med bekräftelse

### Användarupplevelse
- 📱 **Responsiv design** för alla enheter
- 🎨 **Filmtematisk UI** med Bootstrap 5
- ✅ **Formulärvalidering** med tydliga felmeddelanden
- 🚨 **Anpassad felhantering** för 404 och 500-fel

## 🚀 Kom igång

### Förutsättningar
- .NET 6.0 SDK eller senare
- Modern webbläsare (Chrome, Firefox, Safari, Edge)

### Installation

#### Alternativ 1: Git Clone + Visual Studio 2022

1. **Klona projektet**
   ```bash
   git clone [repository-url]
   cd reel-obscura
   ```

2. **Öppna i Visual Studio 2022**
   - Starta Visual Studio 2022
   - Välj `File > Open > Project/Solution`
   - Navigera till projektmappen och öppna `ReelObscuraApp.Web.csproj`

3. **Starta applikationen**
   - Tryck `F5` eller klicka på Start-knappen (grön pil)
   - Applikationen öppnas automatiskt i webbläsaren på `http://localhost:5000`

#### Alternativ 2: Klona direkt i Visual Studio 2022

1. **Klona via Visual Studio**
   - Starta Visual Studio 2022
   - Välj `Clone a repository` på startskärmen
   - Klistra in repository-URL:en
   - Välj lokal mapp och klicka `Clone`

2. **Öppna projektet**
   - Visual Studio öppnar automatiskt lösningen
   - Om inte, dubbelklicka på `ReelObscuraApp.Web.csproj` i Solution Explorer

3. **Starta applikationen**
   - Tryck `F5` eller klicka på Start-knappen
   - Applikationen startar i din standardwebbläsare

#### Alternativ 3: Visual Studio Code

1. **Klona projektet**
   ```bash
   git clone [repository-url]
   cd reel-obscura
   ```

2. **Öppna i VS Code**
   ```bash
   code .
   ```
   Eller öppna VS Code och välj `File > Open Folder` och välj projektmappen

3. **Installera C# extension** (om inte redan installerad)
   - Gå till Extensions (Ctrl+Shift+X)
   - Sök efter "C# Dev Kit" och installera

4. **Starta applikationen**
   - Öppna terminalen i VS Code (`Ctrl+` `)
   - Kör följande kommando:
   ```bash
   dotnet run
   ```
   - Öppna webbläsaren och gå till `http://localhost:5000`

#### Alternativ 4: Klona direkt i VS Code

1. **Klona via VS Code**
   - Öppna VS Code
   - Tryck `Ctrl+Shift+P` och skriv "Git: Clone"
   - Klistra in repository-URL:en
   - Välj lokal mapp för projektet

2. **Öppna projektet**
   - VS Code frågar om du vill öppna det klonade projektet - välj "Yes"
   - Installera C# Dev Kit extension om prompted

3. **Starta applikationen**
   - Öppna terminalen (`Ctrl+` `)
   - Kör: `dotnet run`
   - Besök `http://localhost:5000` i webbläsaren

> 💡 **Tips:** 
> - **Visual Studio 2022:** Bäst för fullständig .NET-utveckling med IntelliSense och debugging
> - **VS Code:** Lättviktigt alternativ, perfekt för mindre redigeringar och utveckling
> - Om du stöter på portproblem, kontrollera terminal/output-fönstret för mer information

## 📋 Användning

| Funktion | Beskrivning |
|----------|-------------|
| **Startsida** | Visa alla filmer i din samling som ett snyggt rutnät |
| **Filmdetaljer** | Klicka på en film för fullständig information |
| **Lägg till film** | Använd "Add Movie"-knappen för att lägga till nya filmer |
| **Redigera** | Klicka "Edit" på filmdetaljsidan |
| **Ta bort** | Klicka "Delete" med bekräftelse |

## 🔧 API-referens

| Metod | Endpoint | Beskrivning |
|-------|----------|-------------|
| `GET` | `/` | Lista alla filmer |
| `GET` | `/details/{id}` | Visa filmdetaljer |
| `GET` | `/create` | Formulär för ny film |
| `POST` | `/create` | Skapa ny film |
| `GET` | `/edit/{id}` | Redigeringsformulär |
| `POST` | `/edit/{id}` | Uppdatera film |
| `GET` | `/delete/{id}` | Bekräfta borttagning |
| `POST` | `/delete/{id}` | Ta bort film |
| `GET` | `/Error/{statusCode}` | Felhanteringssida |
| `GET` | `/trigger-error` | Testa felhantering |

> 🔒 Alla POST-förfrågningar använder CSRF-skydd

## 📊 Datamodell

```csharp
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ReleaseYear { get; set; } = null!;
    public string TrailerUrl { get; set; } = null!;
    public string MoviePoster { get; set; } = null!;
    public string ImdbUrl { get; set; } = null!;
    public string[] Actors { get; set; } = null!;
}
```

## 🛠️ Teknisk stack

- **Backend:** ASP.NET Core MVC
- **Frontend:** Bootstrap 5, jQuery
- **Datalagring:** Minnesbaserad (utökningsbar till databas)
- **Validering:** Client- och server-side validation
- **Styling:** Custom CSS med filmtematisk design

## 🚨 Felhantering

Applikationen har robust felhantering med anpassade felsidor:

### Testa felhantering

**500 Serverfel:**
```
Besök: /trigger-error
```
- Simulerar serverfel
- Visar anpassad 500-sida
- Loggar fel med unikt ID

**404 Sida ej funnen:**
```
Besök: /nonexistent-page
Försök: /details/9999
```
- Visar anpassad 404-sida
- Tillhandahåller navigation tillbaka

### Felhanteringsflöde
1. Fel upptäcks av systemet
2. ErrorController aktiveras
3. Lämplig felvy visas
4. Fel loggas för felsökning
5. Användaren guidas tillbaka

## 📝 Validering

Alla formulär inkluderar omfattande validering:

- ✅ **Obligatoriska fält** - Titel, beskrivning, år
- 🔗 **URL-validering** - IMDB-länkar, trailers, filmomslag
- 🎯 **Realtidsvalidering** - Både klient och server
- 📢 **Tydliga felmeddelanden** - Användardata presenteras vänligt

## 🎯 Projektstruktur

```
ReelObscuraApp.Web/
├── Controllers/       # MVC Controllers
├── Models/            # Datamodeller
├── Services/          # Business logic och datahantering
├── Views/             # Razor Views
├── wwwroot/           # Statiska filer
│   ├── css/           # Custom styling
│   ├── lib/           # JavaScript bibliotek
│   └── images/        # Bilder och ikoner
└── Program.cs         # Applikationsstartpunkt
```

## 📈 Framtida förbättringar

- 🗄️ Databasintegration (Entity Framework)
- 🔐 Användarautentisering
- 🔍 Sök- och filterfunktioner
- ⭐ Betygsystem
- 📱 PWA-funktionalitet
- 🌐 API för externa integrationer



## 📄 Licens

Detta är ett **utbildningsprojekt** skapat för lärandesyften. Koden är tillgänglig för studier och referens.

**Obs:** Detta projekt är inte avsett för kommersiell användning.

---

**Skapad med ❤️ för filmälskare**