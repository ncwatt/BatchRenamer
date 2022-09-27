// See https://aka.ms/new-console-template for more information

string dir = @"F:\Mac Transfer\Add to Plex\";

string[] files = Directory.GetFiles(dir, "The.Big.Bang.Theory*", SearchOption.TopDirectoryOnly);

//iterate the array
for (int i = 0; i < files.Length; i++)
{
    string[] parts = files[i].Replace(dir, "").Split(".");

    string fileName = "";
    
    if (parts.Length == 9) {
        fileName = parts[0] + " " + parts[1] + " " + parts[2] + " " + parts[3] + " - " + parts[4] + "." + parts[8];
    }

    if (parts.Length == 10) {
        fileName = parts[0] + " " + parts[1] + " " + parts[2] + " " + parts[3] + " - " + parts[4] + "." + parts[9];
    }

    Console.WriteLine(files[i] + " -> " + dir + fileName);
    System.IO.File.Move(files[i], dir + fileName);
}
