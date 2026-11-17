using IPOO;

int x = 10;
string nome = string.Empty;
char sexo = '\0';

//string LerNome()
//{

//    Console.Write("Digite o nome desejado: ");
//    Console.ReadLine();
//    Console.Clear();
//    return nome;
//}


Pessoa p1 = new("Gabriel", 12, 'M');
Console.WriteLine(p1.ToString());



Console.ReadKey();

