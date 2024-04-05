double percentualDeBonus, percentualDeRetorno;
double pontosATranferir, pontosAReduzir, pontosAAcrecentar;

Console.Clear();
Console.WriteLine("---Milhas Bumerangue ---\n");

Console.Write("Percentual de bônus.....:");
percentualDeBonus = Convert.ToDouble(Console.ReadLine());

Console.Write("Percentual de retorno.....:");
percentualDeRetorno = Convert.ToDouble(Console.ReadLine());

Console.Write("Pontos a transferir.....:");
pontosATranferir = Convert.ToDouble(Console.ReadLine());

pontosAReduzir = pontosATranferir - (pontosATranferir * percentualDeRetorno) / 100;
pontosAAcrecentar = pontosATranferir + (pontosATranferir * percentualDeBonus) / 100;

Console.WriteLine();
Console.WriteLine ($"Pontos a reduzir na origem.........: {pontosAReduzir}");
Console.WriteLine ($"Pontos a acrescentar no destino....: {pontosAAcrecentar}");
