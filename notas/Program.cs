int x=0;
while(x==0)
{
    for (int i=0;i<3;i++)
    {
        System.Console.WriteLine($"Ingrese la nota {i+1} ");
        int nota =int.Parse(Console.ReadLine());

        while (nota<0||nota>20)
        {
            System.Console.WriteLine("Nota inválida. Por favor ingrese una nota entre 0 y 20: ");
            nota=int.Parse(Console.ReadLine());
        }
    }
    System.Console.WriteLine("¿Deseas ingresar las notas de otro estudiante? S/N");
    char estudiante=char.Parse(Console.ReadLine());
    if (estudiante=='s')x=0;
    else x=1;
}