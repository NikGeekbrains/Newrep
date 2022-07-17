//case 13
Console.WriteLine("Введите число");
int chislo = Convert.ToInt32(Console.ReadLine());
void proc (int x)
{
    int save = x;
double length = 0;
    while (x > 0)
    {
        x/=10;
        length++;
    }

double itog = Math.Pow(10, length-3);
    int rez = (save/Convert.ToInt32(itog))%10;
    Console.WriteLine(rez);
}

try
{
proc(chislo);
}
catch{ Console.WriteLine("Нет третьей цифры");}

//case 15

Console.WriteLine("Введите день недели");
int den = Convert.ToInt32(Console.ReadLine());
void proc2(int index)
{
    string [] nedelya = new string[7];
for (int i = 0; i < nedelya.Length; i++)
{
    if (i < 5)
    {
        nedelya[i] = "Нет";
    }
    else
    {
        nedelya[i] = "Да";
    }
}

Console.WriteLine(nedelya[index-1]);
}

proc2(den);