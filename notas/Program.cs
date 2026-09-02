int x=0;
while(x==0)
{
    for (int i=0;i<2;i++)
    {
        System.Console.WriteLine($"Ingrese la nota {i+1} ");
        int nota =int.Parse(Console.ReadLine());
    }
    System.Console.WriteLine("¿Deseas ingresar las notas de otro estudiante? S/N");
    char estudiante=char.Parse(Console.ReadLine());
    if (estudiante=='s')x=0;
    else x=1;
}