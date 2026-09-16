///2.feladat
string nev=Console.ReadLine();
int kor = Convert.ToInt32(Console.ReadLine());
bool diakigaolvany = true;
string diakigaolvanyInput = Console.ReadLine();
if (diakigaolvanyInput == "igen")
{
    diakigaolvany = true;
}
else
{ diakigaolvany = false; }
int mozijegy = 2800;
int mozijegyosz = Convert.ToInt32(Console.ReadLine());
int popcorn = Convert.ToInt32(Console.ReadLine());
int popcornar = 1500;
double kedvezmeny = 0.20;
int ujossz=0;
int ossz= (mozijegy * mozijegyosz) + (popcorn * popcornar);
///3.feladat
    if (kor < 18 || diakigaolvany == true)
    {
        ujossz = (int)(ossz * (1 - kedvezmeny));
    }


    ///4.feladat

    Console.WriteLine($"Vásárló neve: {nev}");
Console.WriteLine($"rendelés: {mozijegyosz}db mozijegy + {popcorn}db popcorn");
Console.WriteLine($"Alap összeg: {ossz} Ft");
Console.WriteLine($"Fizetendő végösszeg: {ujossz} Ft");
if (kor < 18 || diakigaolvany == true)
{
        Console.WriteLine($"Státusz: {kedvezmeny * 100}% os kedvezmény érvényesítve");
}