using _01_07_øvelse.Models;
Artist RATM = new Artist();
RATM.Name = "Rage Against The Maschine";
RATM.Description = "Rage Against the Machine is an American rock band formed in Los Angeles, California, in 1991. The band's music combines elements of hip hop, punk rock, and heavy metal, and is known for its politically charged lyrics and activism.";
RATM.AmountOfMembers = 4;
RATM.YearFormed = 1991;
Artist Nirvana = new Artist();
Nirvana.Name = "Nirvana";
Nirvana.Description = "Nirvana was an American rock band formed in Seattle, Washington, in 1987. The band consisted of Kurt Cobain, Krist Novoselic, and Dave Grohl.";
Nirvana.AmountOfMembers = 3;
Nirvana.YearFormed = 1987;


User brugernavn = new User();
brugernavn.UserName = "Dinosaurus";


Playlist DinasPlaylist = new Playlist();
DinasPlaylist.Name = "1. playliste";
DinasPlaylist.Owner = brugernavn;

Song DinasYndSang = new Song();
DinasYndSang.Title = "Killing in the Name";
DinasYndSang.Artist = RATM;
DinasYndSang.AlbumName = "Rage Against The Mashine";
DinasYndSang.ReleaseYear = 1992;
DinasYndSang.LengthInSeconds = 277;
DinasYndSang.Description = "Killing in the Name is a song by American rock band Rage Against the Machine. It was released as the lead single from their self-titled debut album in 1992. The song is known for its aggressive guitar riffs, politically charged lyrics, and rebellious attitude.";
DinasYndSang.Genre = "Rap Metal";
DinasPlaylist.Songs.Add(DinasYndSang);
Song DinasYndSang2 = new Song();
DinasYndSang2.Title = "Smells Like Teen Spirit";
DinasYndSang2.Artist = Nirvana;
DinasYndSang2.AlbumName = "Nevermind";
DinasYndSang2.ReleaseYear = 1991;
DinasYndSang2.LengthInSeconds = 300;
DinasYndSang2.Description = "Smells Like Teen Spirit is a song by American rock band Nirvana. It was released as the lead single from their debut album Nevermind in 1991. The song is known for its grunge sound and iconic music video.";
DinasYndSang2.Genre = "Grunge";
DinasPlaylist.Songs.Add(DinasYndSang2);
Song DinasYndSang3 = new Song();
DinasYndSang3.Title = "Bulls on parade";
DinasYndSang3.Artist = RATM;
DinasYndSang3.AlbumName = "Evil Empire";
DinasYndSang3.ReleaseYear = 1996;
DinasYndSang3.LengthInSeconds = 270;
DinasYndSang3.Description = "Bulls on Parade is a song by American rock band Rage Against the Machine. It was released as the lead single from their second studio album Evil Empire in 1996. The song is known for its politically charged lyrics and heavy guitar riffs.";
DinasYndSang3.Genre = "Rap Metal";
DinasPlaylist.Songs.Add(DinasYndSang3);
Console.WriteLine();
Console.WriteLine($"Min Liste Af Sange: {DinasPlaylist.Name}");
Console.WriteLine($"Antallet Af Sange i Min Playliste: {DinasPlaylist.Songs.Count}");
Console.WriteLine($"Ejet Af: {DinasPlaylist.Owner.UserName}");
Console.WriteLine();
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