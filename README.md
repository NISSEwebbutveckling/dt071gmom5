
# DT071G 
## Moment5 - projekt
### Nils, nibo1005@student.miun.se
### Programmering i C#.NET


## Notgeneratorn
Denna skoluppgift bestod i att skapa applikation i C# och använda ramverket .NET på ett valfritt sätt.
Studenten fick i uppdrag att hitta någon form av idé till applikation som drar nytta av de teorier och tekniker 
som har lärts ut i kursen.
Applikationen fick vara konsol-, desktop-, webb- eller mobilbaserad.
Fokus skulle vara på kursens lärmoment.

### Syftet med uppgiften är att studenten efter genomförd laboration ska:
 * Tillämpa de kunskaper som lärts ut under kursen för att skapa en mer omfattande och användbar applikation skriven i C#.
 * Eventuellt (frivilligt) använda fler tillägg än bara ramverket .NET för att skapa en applikation.
 * Skapa en en projektrapport som beskriver ditt arbete med projektuppgiften.
 * Skapa en enklare presentation av ditt arbete i videoformat.

### Instruktioner om hur applikationen fungerar, översiktligt
1. Skapar en notgenererare som en konsolapplikation, med möjlighet att slumpvis generera noter (8 stycken/gång) i olika skalor.
Dessa finns då möjlighet att lagra till en post där de lagras i en .json fil lokalt på datorn.
Därefter finns det möjlighet att ta bort en valfri post samt visa alla poster.

2. Ett enklare menysystem hanterar del val som ska kunna genomföras.
* Generera nya noter.
* Ta bort post med noter enligt ett valt index.
* Avsluta programmet.

3. I samband med att de genererade noterna sparas, så får användaren även möjlighet att lämna ett namn eller meddelande, dagens datum läggs till automatiskt.

4. De sparade posterna serialiseras/deserialiseras samt sparas på fil .json, så att tidigare inmatad data finns lagrad.

5. Viss felhantering förekommer, exemeplvis kontroll så att inmatningsfält inte är tomma vid borttagning av en post.

6. Efter varje genomfört menyval ska skärmen skrivas om. Detta sker genom att konsolen "rensas" och sedan ritar/skriver om den.

## Köra applikationen
Genom att i konsolen ange; ”dotnet run”.
Detta förutsätter att du har de program, m.m. installerade som krävs, etc.

### Det finns guider på Internet som förklarar hur du kommer igång med C#, beroende på OS, etc.
Det går att lösa denna uppgift m.h.a. Visual Studio eller genom att använda Visual Studio Code (VSC) inkl. dess behövliga extensions.
Jag kommer inte att gå in på detaljer som berör exempelvis själva installationerna av de olika programvaror som behövs.

### Övrigt
Detta program är skapat i utbildningssyfte. 
(Jag kan inte ta ansvar över vad du åstadkommer om/när du försöker att återskapa detta och jag har inte tid/möjlighet med ev. support.)

