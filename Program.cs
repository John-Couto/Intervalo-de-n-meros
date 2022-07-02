
Console.WriteLine("Intervalos");
var lista = new int[] { 100, 101, 102, 103, 104, 105, 110, 111, 113, 114, 115, 150 };

for (int i = 0; i < lista.Length; i++)
{
    if (lista[i] >= 100  && lista[i] <= 105)
    {
        Console.WriteLine("Lista 100-105");
        var zeroACentoECinco = lista[i];
        Console.WriteLine(zeroACentoECinco);
    }
    else if (lista[i] >= 110 && lista[i] <= 111)
    {
        var centoEDezACentoEQuinze = lista[i];
        Console.WriteLine("Lista 110-111");
        Console.WriteLine(lista[i]);        
    }
    else if (lista[i] >= 113 && lista[i] <= 115)
    {
        var centoEDezAcentoEQuinze = lista[i];
        Console.WriteLine("Lista 113-115");
        Console.WriteLine(lista[i]);        
    } 
    else 
    { 
        var centoECinquenta = lista[i];
        Console.WriteLine("Lista 150");
        Console.WriteLine(lista[i]);        
    }
}