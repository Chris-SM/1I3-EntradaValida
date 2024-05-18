Console.ForegroundColor = ConsoleColor.Gray;
Console.BackgroundColor = ConsoleColor.White;
Console.Write("------ Entrada Válida ------");
Console.ResetColor();
Console.WriteLine("\n\n");
string Sair = "";
bool Sai = true;
while(Sai)
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
    Sair = Console.ReadLine()!;
    if(Sair == "1")
    {Sai = false;}
    else if(Sair == "2")
    {Sai = false;}
    else if(Sair == "3")
    {Sai = false;}
    else if(Sair == "4")
    {Sai = false;}
    else if(Sair == "5")
    {Sai = false;}
    else if(Sair == "6")
    {Sai = false;}
    else if(Sair == "7")
    {Sai = false;}
    else if(Sair == "8")
    {Sai = false;}
    else if(Sair == "9")
    {Sai = false;}
    else if(Sair == "0")
    {Sai = false;}
}

if(Sair != "0")
{
    Console.Write($"Número selecionado = {Sair}");
}
else
{
    Console.Write("Operação cancelada.");
}
Console.Write("\n\nVolte sempre!");