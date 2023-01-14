/*
Dt071g, Moment5 -projekt, Nils
nibo1005@student.miun.se
*/

//Här finns class, Note.

/////////////////////
//Få bort s.k. null ref-meddelanden, inspiration av nedan länk. "add the null forgiving operator, ! to the right-hand side."
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings#possible-null-assigned-to-a-nonnullable-reference
/////////////////

//using System, innebär att du använder "System library" i projektet. 
using System;

//Namespaces används i C# för att organisera och ge en nivå av separerade koder.
namespace notgeneratorn
{
//Nedan används bl.a. vid ny post. //Denna class, Note, är publik och då nåbar överallt.
//Denna innehåller noter och namn, vilka är private, 
//innebär då att att endast Note kan nå denna, dessa i sin tur innehåller s.k. setters, och getters.
public class Note
{
//Obj.
//Default!, används nedan för att få bort warning:
//warning CS8618: Non-nullable property 'Noter' must contain a non-null value when exiting constructor. 
//Consider declaring the property as nullable.
public string Noter
{get; set;} = default!;
/*
{
//Get/set är "åtkomstmodifierare" till property. Get läser fältet. Set anger property-värdet.
//Nedan tips från Lars:
//"Kolla upp automatic properties eller short hand properties som det också kallas."
//Har även för mig att det nämnts på nedan FÖ.
//https://play.miun.se/media/NET+MAUI/0_17kzndt4
//
*/

//Se ovan.
public string Namn
{get; set;} = default!;
}
}
