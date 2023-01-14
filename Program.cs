/*
Dt071g, Moment5 -projekt, Nils
nibo1005@student.miun.se

//////BAKGRUND////////////////////
Denna skoluppgift bestod i att skapa applikation i C# och använda ramverket .NET på ett valfritt sätt.
Studenten fick i uppdrag att hitta någon form av idé till applikation som drar nytta av de teorier och tekniker 
som har lärts ut i kursen.
Applikationen fick vara konsol-, desktop-, webb- eller mobilbaserad.
Fokus skulle vara att få med kursens lärmoment i uppgiften.

Syftet med uppgiften är att studenten ska:
    
    -Tillämpa de kunskaper som lärts ut under kursen för att skapa en mer omfattande och användbar applikation skriven i C#.
    -Eventuellt (frivilligt) använda fler tillägg än bara ramverket .NET för att skapa en applikation.
    -Skapa en en projektrapport som beskriver ditt arbete med projektuppgiften.
    -Skapa en enklare presentation av ditt arbete i videoformat.

Lösningen innehåller viss felhantering, vilken bl.a. kontrollerar om korrekt inmatat värde finns vid borttagning av en post.
Klasser som förekommer som egna filer är, Note.cs samt NoterStore.cs.

///////////TEORI//////////////
Lite teori som inspirerat/underlättat till lösning av den här uppgiften:
https://play.miun.se/media/DT071G_Projektintro_H22/0_kketokpi
https://play.miun.se/media/DT071G_OOP_Introduktion_H22/0_r7uuyur4
https://play.miun.se/media/DT071G_C_OOP_uppf%C3%B6ljning/0_z8tu5drv
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop
https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?view=windowsdesktop-7.0
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings#possible-null-assigned-to-a-nonnullable-reference
*/

//////PROGRAMMET/////////////////////////////////////////////////////////////////////
//C#, Notgeneratorn//

//using System, innebär att du använder "System library" i projektet. 
using System;

//Namespaces används i C# för att organisera och ge en nivå av separerade koder.
namespace notgeneratorn
{
//Huvudprogrammet, class Program.
class Program
{
//Statisk metod, Main, denna körs.
static void Main(string[] args)
{
//////DETTA KAN SES SOM INTRODELEN/////////////////
//Ändrar lite färger, inspiration från nedan källa:
//https://www.geeksforgeeks.org/c-sharp-how-to-change-foreground-color-of-text-in-console/   
Console.ForegroundColor
= ConsoleColor.Blue;
Console.BackgroundColor
= ConsoleColor.Black;   

//Tömmer konsolen.
Console.Clear();Console.CursorVisible = false;
//Nedan procentfkn. fyller egentligen ingen fkn. Den förekommer i appl. mest för att skapa en intressantare anv.upplevelse.
Procent();

//Tömmer konsolen.
Console.Clear();Console.CursorVisible = false;
static void Procent()
{
//Några radbrytningen, sedan for-loop, börjar på 40 går till 98.
Console.Write("\n\n\n\n");
  for (int ii = 40; ii <= 98; ii++)
  {
//$ Markerar string literal som en interpolated string.
//carriage return, \r
Console.Write("" + $"\r     Laddar in applikationen: {ii}%   ");
//Tillfälligt stoppar nuvarande execute av thread i antal milliseconds.
Thread.Sleep(50);
}
// Clear console (tömmer konsolen).
Console.Clear();Console.CursorVisible = false;
//   \n, new line.
Console.Write("  NOTGENERATORN \n  NILS\n  2023\n  (c)");
Console.Write("\n\n\n\n\n\n");
for (int ii = 10; ii <= 98; ii++)
{    
//För att skriva ut någonannanstan på konsolen än t.v.
//Insiration enligt nedan länk:
//https://stackoverflow.com/questions/6913563/c-sharp-align-text-right-in-console
Console.Write("{1, 20} {1,40}", $"\rLaddar in: {ii}%   ", "*******  **********  ***********");
//Tillfälligt stoppar nuvarande execute av thread i antal milliseconds.
Thread.Sleep(50);
}
}
//////HÄR SLUTAR INTRODELEN/////////////////


//////INNE i APPLIKATIONEN, MENEYN LADDAS IN, TIDIGARE PSOTER, M:M:///////////////
//Färghantering
Console.BackgroundColor
= ConsoleColor.Black;   
//Instansiera, "mgm-class", NoteStore => Tillgånt till addNote, delNote, etc.
NoteStore notesstore = new NoteStore();
//Nollar i.
int i=0;
//Slinga, meny och val.
while(true){
//Tömmer konsolen).
Console.Clear();Console.CursorVisible = false;
//Färghantering.
Console.ForegroundColor
= ConsoleColor.Yellow;
Console.BackgroundColor
= ConsoleColor.DarkMagenta;
//Felhantering. try/catch. Inspiration från nedan källa:
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch
try
{
//Ändra bakrungdfsfärg.
Console.BackgroundColor
= ConsoleColor.Black;
//Färghantering.
Console.ForegroundColor
= ConsoleColor.DarkGreen;
//Skriver ut rubriken.
Console.WriteLine("\n *_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*");
Console.WriteLine("\n*    Notgeneratorn (dt071g, moment5 - projekt)          *");
Console.WriteLine("\n *_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_* ");
//Delay, inspiration från nedan:
//https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-7.0
int milliseconds = 500;
Thread.Sleep(milliseconds);
//Färghantering.
Console.ForegroundColor
= ConsoleColor.Yellow;
//Instruktionsdelen, inkl menyval.
Console.WriteLine("_______________________________________________________\n");
Console.WriteLine("\n   INSTRUKTIONER\n");
//Delay
Thread.Sleep(milliseconds);
//Skriver ut menyn, alternativ
Console.WriteLine("   [<-]-tangent | För att generera ny notserie.\n");
Console.WriteLine("   [->]-tangent | Ta bort tidigare notgenerering.\n");
Console.WriteLine("   [esc]-tangent | Avsluta.\n");
Console.WriteLine("_______________________________________________________\n");
//Delay
Thread.Sleep(milliseconds);  
//Ändra bakrungdfsfärg.
Console.ForegroundColor = ConsoleColor.White;
 Console.WriteLine("   SPARADE NOTSERIER");   
//Skriver ut poster.
//Index, (vart befinner sig), nollställs, i=0.
i=0;
//Loop, för varje element, flytta över obj. till var.notes, så att det går att "jobba" med denna. Skriver sedan ut i++ notes.Noter, resp. notes.Namn.
foreach(Note notes in notesstore.getNotes()){
//Lagrat skrivs ut, samtliga poster.
    Console.WriteLine("\n   [" + i++ + "] " + "Genererade noter: "  + notes.Noter + " \n " + "   Datum / notis: " + notes.Namn + "");
    Console.WriteLine("_____________________________________________________");
}
//Ändrar textfärg.
Console.ForegroundColor
= ConsoleColor.Yellow;
//Ändrar bakrungdfsfärg.
Console.BackgroundColor
= ConsoleColor.Black;
//Färghantering
Console.ForegroundColor
= ConsoleColor.DarkGreen;
//Datumhantering, inspiration från nedan länk:
//https://learn.microsoft.com/en-us/dotnet/api/system.datetime.today?view=net-7.0
{
// Bef datum..
DateTime thisDay = DateTime.Today;
// Visar datum.   
    Console.WriteLine("\n\n\n\n________________________________________________________\n");
    Console.WriteLine("   Dagens datum: " + thisDay.ToString("d"));
}

Console.WriteLine("________________________________________________________\n");   
//ReadKey, inväntar tangenttryck.
int inp = (int) Console.ReadKey(true).Key;
//Ändrar textfärg.
Console.ForegroundColor
= ConsoleColor.Yellow;

//Case-switch, för menyval-tangenter. <- RESP -> samt esc.
switch (inp) {
//37= <-tangent.
case 37:
Console.CursorVisible = true; 
//////HÄR SLUTAR, INNE i APPLIKATIONEN, MENEYN LADDAS IN, TIDIGARE PSOTER, M:M:///////////////


//////DAGS ATT GENERERA NOTER///////////////
//Ändrar bakrundfsfärg.
Console.BackgroundColor
= ConsoleColor.DarkMagenta;
//Deklarerar nedan var.
String svar;
//Tömmer konsolen
Console.Clear();Console.CursorVisible = false;
//Instruktioner
{
Console.WriteLine("\n\n\n\n__________________________________________________________________\n");
Console.WriteLine("\n   Välj vilken skala som du vill generera noter från. \n\n   Tryck [F]-tangent för F-durskalan, annars [C]-tangent eller valfri tangent för C-durskalan. ");
Console.WriteLine("\n   (Detta är demoversionen, vilken endast har två skalor att välja mellan.) ");
Console.WriteLine("\n____________________________________________________________________\n");
//ReadKey, inväntar tangenttryck.
int inp2 = (int) Console.ReadKey(true).Key;
//Deklarerar.
String NotCF;
//IF-sats där användare får göra val vilken skala som ska tillämpas.
//Sträng tilldelas ett antal tecken, beroende på valet.
//https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?redirectedfrom=MSDN&view=windowsdesktop-7.0
if (inp2 == 70) 
{ 
//Tilldelar värde
NotCF="FGAbCDEF";
//Console.WriteLine(NotCF);
} 
else {
//Tilldelar värde
NotCF = "CDEFGABC";
//Console.WriteLine(NotCF);
} 
//Nedan genereras 8 st. "noter", ur en sträng. 
//För slumpgen.
 Random randomNote = new Random();
//Sträng som bestämmer vilka noter som ska ingå i det som senare ska slumpgenereras.
String noter = NotCF;
//Antal körningar.
int length = 8;             
//"Nollar"
String generate = ""; 
//For-lopp, räknar upp till körningar utförda.   
for(int it =0; it<length; it++)
 {
//Next() method in C# används för return non-negative random integer.
int a = randomNote.Next(8);
//ElementAt() är System.Linq metod i C#, används för att visa element vid visst index.
generate = generate + noter.ElementAt(a);
}
//Meddelande ang. sparad post, samt delay.
//Console.WriteLine("\nPosten har sparats, tillbaka till startläget.");
//Delay
int milliseconds3 = 100;
Thread.Sleep(milliseconds3);
//Tömmer konsolen
Console.Clear();Console.CursorVisible = false;
//Räknar upp procent, för användarupplevelsen.
Console.Write("\n\n\n\n\n\n");
for (int ii = 55; ii <= 100; ii++)
{
//If- sats som påverkar vad som skrivs ut på skärm m.a.p. på vilken skala som användaren har valt.              
string skala;
if (inp2 == 70) {
skala = "(från F-skalan).";
} else
{
skala = "(från C-skalan).";
}
//$ Markerar string literal som en interpolated string.
//carriage return, \r
Console.Write("  " + $"\r   Genererar notserie: {ii}% " + skala);
//Tillfälligt stoppar nuvarande execute av thread i antal milliseconds.
Thread.Sleep(50);
}
Console.Write(" \n\n");
//Skriver ut resultatet.
Console.WriteLine("\n   Genererade noter är: {0}", generate + "."+"");
Console.WriteLine("                       __________\n\n");
//Lagrar i sträng nedan för användning senare.
svar = generate;       
 }
//Skriver ut meddelanden.
Console.WriteLine("   Nu kan du skriva ett namn eller notis för att spara detta. Alt. lämna fältet tomt. \n");
Console.Write("   Skriv ett namn eller en notis, följt av [Enter]: ");
//Input från användare.
string namn1 = Console.ReadLine()!;
  DateTime thisDay = DateTime.Today;
string daten = thisDay.ToString("d");
//SKriv ut meddelande.
Console.Write("\n   Notgenereringen kommer att sparas som: " + namn1 + ".");
string namn = daten + " / " + namn1;
/////////
//Instansiera nytt obj.
Note obj = new Note();
//"Sätter" värdena.
obj.Noter = svar;
obj.Namn = namn;
{           
//If-sats för att kolla input value.
//Kollar om tomma fält, annars lägg till.
if(!String.IsNullOrEmpty(svar) && !String.IsNullOrEmpty(namn)) {notesstore.addNote(obj);
//Delay
int milliseconds4 = 2000;
Thread.Sleep(milliseconds4);
//Meddelande ang. sparad post, samt delay.
Console.WriteLine("\n\n   Sparat!\n\n   Du förflyttas strax tillbaka till startläget.................\n");
//Delay
int milliseconds2 = 6000;
Thread.Sleep(milliseconds2);
}
else {
//Felmeddelande, m.m.
//Ändra bakrungdfsfärg.
Console.BackgroundColor
= ConsoleColor.Red;
//Delay
int milliseconds22 = 3000;
Console.WriteLine("\n   Något blev fel vid sparandet.\n");
Thread.Sleep(milliseconds22);
Console.WriteLine("   Programmet kommer att avslutas.\n");        
Thread.Sleep(milliseconds22);
//Avslutar programmet, samt meddelande.
Console.WriteLine("   Hejdå!\n");  
//Avslutar
Environment.Exit(0);
break;
}
}
//Ändra bakrungdfsfärg.
Console.BackgroundColor
= ConsoleColor.Black;
break;         
//////HÄR SLUTAR, DAGS ATT GENERERA NOTER///////////////


/////TA BORT POST//////////
//Nästa switch
//39 = -> 
case 39: 
//Ändra bakrungdfsfärg.
Console.BackgroundColor
= ConsoleColor.DarkRed;
Console.CursorVisible = true;
Console.Write("   Ange post [index] att radera (går ej att ångra), följt av [Enter]: ");
//Ändrar bakrungdfsfärg.
Console.BackgroundColor
= ConsoleColor.Black;                  
//Läser inmatning.
string index = Console.ReadLine()!;
//Tar bort, gör om till heltal.
notesstore.delNote(Convert.ToInt32(index));
//Meddelande ang. borttagen post.            
Console.WriteLine("\n   Posten har raderats.");
//Delay
int milliseconds222 = 3000;
Thread.Sleep(milliseconds222);
break;
/////HÄR SLUTAR, TA BORT POST//////////


////FÖR ATT AVSLUTA/////////////
//Sista switch
//27 = esq
case 27: 
//Avslutar programmet, samt meddelande.
Console.WriteLine("   Hejdå!\n");
Environment.Exit(0);
break;
////HÄR SLUTAR, FÖR ATT AVSLUTA/////////////
}
}


/////DIVERSE FELHANTERING///////////
//Felhantering. catch/try, inspiration från nedan länk.
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch
catch(ArgumentOutOfRangeException )
//catch(ArgumentOutOfRangeException  e)
{
//Färg.
Console.BackgroundColor
= ConsoleColor.Red;
//Meddelande lagras i string.
string Message = "\n   Angivet nummer finns ej. \n   Vänligen, testa med ett nytt nummer nästa gång du kör programmet.";
//Skriver ut meddelande.
Console.Write(Message);
//Delay
int milliseconds3 = 3000;
Thread.Sleep(milliseconds3);
//Avslutar programmet.
Console.WriteLine("\n\n   Programmet kommer att avslutas.\n");
//Delay
Thread.Sleep(milliseconds3);
//Avslutar programmet, samt meddelande.
Console.WriteLine("   Hejdå!\n");
//Avslutar programmet.
Environment.Exit(0);
break;
}
//Nästa catch.
catch
{
//Färg.
Console.BackgroundColor
= ConsoleColor.Red;
//Delay
int milliseconds4 = 3000;
//Meddelande skrivs ut direkt, ej lagrat i string.
Console.Write("\n   Ett fel uppstod eftersom att du har matat in annat än en siffra eller har lämnat fältet tomt. \n   Vänligen, ange en korrekt inmatning nästa gång du kör programmet.");
//Delay
Thread.Sleep(milliseconds4);
Console.WriteLine("\n\n   Programmet kommer att avslutas.\n");
Thread.Sleep(milliseconds4);
//Avslutar programmet, samt meddelande.
Console.WriteLine("   Hejdå!\n");
//Avslutar programmet.
Environment.Exit(0);
break;
}
}
}
}
}
