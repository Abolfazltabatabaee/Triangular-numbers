// See https://aka.ms/new-console-template for more information
//AbuTabatabaee


int n = 1;
int m;
int q = 0;
Console.Write("enter a NO.: ");
m = int.Parse(Console.ReadLine());
for (int x = 1; x <= m; x++)

{
    q = (x * (x + 1)) / 2;

    Console.WriteLine(q);
}
