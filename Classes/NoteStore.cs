/*
Dt071g, Moment5 - projekt, Nils
nibo1005@student.miun.se*/
////////////////

//Här finns class, NoteStore.
//using System, innebär att du använder "System library" i projektet.
using System;
//Using, se ovan.
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
//Namespaces används i C# för att organisera och ge en nivå av separerade koder.
namespace notgeneratorn
{
//"Manageclass", Notestore.
public class NoteStore
    {
//Filnamn json.fil. Filename pekar på jsonfil där datan lagras.
private string filename = @"notestore.json";
//List innehåller samtliga element som lagras.
//Gömd som private i klassen Notestore.
private List<Note> notes = new List<Note>();
//Konstruerare, public NoteStore, tar in arg. 
//Konstruerare instansierar Notestore och kollar om json-filen finnes.
//Om så är fallet, så läses denna in  och deserialiseras.
public NoteStore(){ 
// If-sats, om lagrad json-data finns, then read.
if(File.Exists(@"notestore.json")==true){ 
//Get json och deserialize. 
string jsonString = File.ReadAllText(filename);
//<Note>, namnet på vektorn.
//Note kan innehålla många obj. av typen note.
//Läggs in i array, notes.
notes = JsonSerializer.Deserialize<List<Note>>(jsonString)!;
}
}
//Metod, lägg till.
//Skickar med obj. av typen Note
public Note addNote(Note note){
//Add, metod som används när jobbar med listor. (Som push.)
notes.Add(note);
//Marshal, innebär att datan serialiseras för lagring(textform innan lagring).
marshalling();         
//Returnerar
return note;
}

//Metod, ta bort.
//Skickar med ett index (int, ex. 1 ,2, 3 etc.),
public int delNote(int index){
//RemoveAt samt berört index..
notes.RemoveAt(index);
//Spara nu, sparas efter elem. ändrats.
marshalling();
//returnerar
return index;
}

//Metod, listan
//Returnerar hela arrayen, så att alla element i denna kan bearbetas.
public List<Note> getNotes(){
return notes;
}
//Marshal
private void marshalling()
{
// Serialize objekt och spara till fil.
var jsonString = JsonSerializer.Serialize(notes);
//Filename=notestore.json.
File.WriteAllText(filename, jsonString);
}
}
}
