int N = int.Parse(Console.ReadLine()); 
int M = int.Parse(Console.ReadLine()); 
int T = int.Parse(Console.ReadLine());
int minutes = N * 60 + M + T;
int hours = (minutes / 60) % 24;
int minuts = minutes % 60;
string itog = $"{hours} : {minuts}";
Console.WriteLine(itog);