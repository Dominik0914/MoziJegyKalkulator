string nev=Console.ReadLine();
int kor = Convert.ToInt32(Console.ReadLine());
bool diakigaolvany = false;
int mozijegy = 2800;
int popcorn = Convert.ToInt32(Console.ReadLine());
int popcornar = 1500;
int kedvezmeny = 0.20;

int ossz= mozijegy + (popcorn * popcornar);


if (kor < 18 ||diakigaolvany)
{
    ossz = (int)(ossz * (1 - kedvezmeny));
}