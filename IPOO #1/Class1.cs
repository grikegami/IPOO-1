

namespace IPOO
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade, char sexo)
        {

            Nome = nome;
            Idade = idade;
            Sexo = sexo;

        }
        public string Nome;
        public int Idade;
        public char Sexo;



        /*     public void SetNome(string nome)
             {
                 Nome = nome;
             }
        */
        
            public override string ToString()
        {

            return "Nome: " + Nome + "\nIdade: " + Idade + "\nSexo: " + Sexo;
        }
    }


}


