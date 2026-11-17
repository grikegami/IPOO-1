using Ex2;


ContaBancaria conta1 = new ContaBancaria();
Console.WriteLine("Informe o nome do Titular da conta: ");
conta1.SetTitular(Console.ReadLine());

Console.WriteLine("Informe o saldo da conta: ");
conta1.SetSaldo(double.Parse(Console.ReadLine()));

conta1.ExibirSaldo(conta1.GetSaldo());

Console.WriteLine("CONTA ATUAL:\n" + conta1.ToString());

Console.ReadKey();