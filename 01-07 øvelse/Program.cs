using _01_07_øvelse.Models;
// Creating a new artist:
// Starting with defining the datatype as an "Artist"
// Naming the variable "RATM"
// And then creating "= new Artist();"
Artist RATM = new Artist();
//Then, as predefined in the class "Artist", I will need to tell what this Artist contains of:
//Name, Description, AmountOfMembers and YearFormed:

//Constructors for "Name", "Description", "AmountOfMembers" and "YearFormed":
//RATM is the name of the variable that I am using to define the band Rage Against The Maschine.
//Starting by choosing ".Name", and that it equals with =
//Then I write the band name "Rage Against The Maschine"  
RATM.Name = "Rage Against The Maschine"; 
//Same way as before, for Description
RATM.Description = "Rage Against the Machine is an American rock band formed in Los Angeles, California, in 1991. " +
    "The band's music combines elements of hip hop, punk rock, and heavy metal, and is known for its politically charged lyrics and activism.";
//Same way as before, for AmountOfMembers
RATM.AmountOfMembers = 4;
//Same way as before, for YearFormed
RATM.YearFormed = 1991;

//Same as above, but now for the band Nirvana
// argumenter - følger reglerne for hvordan man kan oprette en ny instans fra constructoren i klassen Artist
/*Artist Nirvana = new Artist("Nirvana", "DWuwudhuawdhuhdw")*/;
Artist Nirvana = new Artist("Nirvana", "DWuwudhuawdhuhdw", 3, 1987, true);
Nirvana.Name = "Nirvana"; 
Nirvana.Description = "Nirvana was an American rock band formed in Seattle, Washington, in 1987. The band consisted of Kurt Cobain, Krist Novoselic, and Dave Grohl.";
Nirvana.AmountOfMembers = 3;
Nirvana.YearFormed = 1987;
Nirvana.IsActive = false;
Nirvana.PrintArtist();

//Starting with class "User". Naming the variable "brugernavn". = (creating) new user
User brugernavn = new User();
// By using the variable "brugernavn", choosing .UserName, naming the user "Dinusaurus"
brugernavn.UserName = "Dinosaurus";

//Starting with class "Playlist". Naming the variable "DinasPlaylist". = (creating) new playlist
Playlist DinasPlaylist = new Playlist();
//By using the variable "DinasPlaylist", choosing .Name, and then naming the playlist "1. playliste"
DinasPlaylist.Name = "1. playliste";
//By using the variable "DinasPlaylist", choosing .Owner, equals to =, assigning the username called "brugernavn",
//which will show who owns the playlist 
DinasPlaylist.Owner = brugernavn;

//Starting with class "Song". Naming the variable "DinasYndSang". = (creating) new song
Song DinasYndSang = new Song();
//By using the variable "DinasYndSang", choosing .Title, and then naming the song "Killing in the Name"
DinasYndSang.Title = "Killing in the Name";
//By using the variable "DinasYndSang", choosing .Artist, equals to =, assigning the artist called "RATM",
DinasYndSang.Artist = RATM;
//By using the variable "DinasYndSang", choosing .AlbumName, and then naming the album "Rage Against The Mashine"
DinasYndSang.AlbumName = "Rage Against The Mashine";
//By using the variable "DinasYndSang", choosing .ReleaseYear, and then writing the year 1992
DinasYndSang.ReleaseYear = 1992;
//By using the variable "DinasYndSang", choosing .LengthInSeconds, and then writing the length to 277 seconds
DinasYndSang.LengthInSeconds = 277;
//By using the variable "DinasYndSang", choosing .Description, and then writing a description of the song
DinasYndSang.Description = "Killing in the Name is a song by American rock band Rage Against the Machine. It was released as the lead single from their self-titled debut album in 1992. The song is known for its aggressive guitar riffs, politically charged lyrics, and rebellious attitude.";
//By using the variable "DinasYndSang", choosing .Genre, and then writing the genre of the song
DinasYndSang.Genre = "Rap Metal";

//Choosing the variable "DinasPlaylist", choosing .Songs,
//and then using the method .Add to add the song "DinasYndSang" to the playlist
DinasPlaylist.Songs.Add(DinasYndSang);

//Same procedure as "DinasYndSang", but now for the song "Smells Like Teen Spirit" by Nirvana
Song DinasYndSang2 = new Song();
DinasYndSang2.Title = "Smells Like Teen Spirit";
DinasYndSang2.Artist = Nirvana;
DinasYndSang2.AlbumName = "Nevermind";
DinasYndSang2.ReleaseYear = 1991;
DinasYndSang2.LengthInSeconds = 300;
DinasYndSang2.Description = "Smells Like Teen Spirit is a song by American rock band Nirvana. It was released as the lead single from their debut album Nevermind in 1991. The song is known for its grunge sound and iconic music video.";
DinasYndSang2.Genre = "Grunge";
DinasPlaylist.Songs.Add(DinasYndSang2);

//Same procedure as "DinasYndSang", but now for the song "Bulls on Parade" by Rage Against The Machine
Song DinasYndSang3 = new Song();
DinasYndSang3.Title = "Bulls on parade";
DinasYndSang3.Artist = RATM;
DinasYndSang3.AlbumName = "Evil Empire";
DinasYndSang3.ReleaseYear = 1996;
DinasYndSang3.LengthInSeconds = 270;
DinasYndSang3.Description = "Bulls on Parade is a song by American rock band Rage Against the Machine. It was released as the lead single from their second studio album Evil Empire in 1996. The song is known for its politically charged lyrics and heavy guitar riffs.";
DinasYndSang3.Genre = "Rap Metal";
DinasPlaylist.Songs.Add(DinasYndSang3);

//Now, I will print out the following 3 informations about the playlist:
Console.WriteLine();
//1) My playlist, "Min Playliste", and Get the name of the playlist "DinasPlaylist.Name"
Console.WriteLine($"Min Playliste: {DinasPlaylist.Name}");
//2) The amount of numbers of the songs in the playlist "Antallet Af Sange i Min Playliste",
//and Get the amount of numbers of the songs in the playlist "DinasPlaylist.Songs.Count"
Console.WriteLine($"Antallet Af Sange i Min Playliste: {DinasPlaylist.Songs.Count}");
//3) The owner of the playlist "Ejet Af", and Get the username of
//the owner "DinasPlaylist.Owner.UserName"
Console.WriteLine($"Ejet Af: {DinasPlaylist.Owner.UserName}");
Console.WriteLine();

//FOR-loop:
//"for" is the keyword for the loop. "int" is the Datatype name for integer.
//"i = 0" sets the starting point of the loop at zero, which is the first index of the list.
//"i < DinasPlaylist.Songs.Count; i++", means that as long as "i" is less than
//the amount of numbers of the songs in the playlist,
//the loop will keep running. This way all songs will be displayed, no matter
//how many songs are in the playlist.
for (int i = 0; i < DinasPlaylist.Songs.Count; i++)
{
    Console.WriteLine($"Title: {DinasPlaylist.Songs[i].Title}");
    Console.WriteLine($"Artist: {DinasPlaylist.Songs[i].Artist.Name}");
    Console.WriteLine($"BandMembers: {DinasPlaylist.Songs[i].Artist.AmountOfMembers}");
    Console.WriteLine($"Album: {DinasPlaylist.Songs[i].AlbumName}");
    Console.WriteLine($"Release Year: {DinasPlaylist.Songs[i].ReleaseYear}");
    Console.WriteLine($"Length (seconds): {DinasPlaylist.Songs[i].LengthInSeconds}");
    Console.WriteLine($"Description: {DinasPlaylist.Songs[i].Description}");
    Console.WriteLine($"Genre: {DinasPlaylist.Songs[i].Genre}");
    Console.WriteLine();
}