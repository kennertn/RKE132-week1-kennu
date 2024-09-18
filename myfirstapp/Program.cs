// this is a comment to my code

//rakendus küsib kasutajal sisestada tema nime
//2 tervitabkasutajat nimepidi

Console.WriteLine("Enter your name:"); //Output
//string - sõne
string userName = Console.ReadLine(); //Input

Console.WriteLine("Hello" + ", " + userName + "!"); //Output

//string interpolation
Console.WriteLine($"Hello, {userName} !"); //Output
