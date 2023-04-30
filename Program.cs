string recado;
Console.WriteLine("O obijeto esta em movimento(S/N)? ");
bool EstaMovimentando = Convert.ToBoolean(Console.ReadLine()!.Substring(0,1).ToUpper() == "S");


Console.WriteLine("Deveria?");
bool deveria = Convert.ToBoolean(Console.ReadLine());
if (EstaMovimentando)
{
    if (deveria)
    {
        recado = "Perfeito !";
    }
    else
    {
        recado = "Use WD-40.";
    }
}
else 
{
    if (deveria)
    {
        recado = "Perfeito !";
    }
    else 
    {
        recado = "Use Silver Tape.";
    }
}
Console.WriteLine(recado);
