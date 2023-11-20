using System;
using Code01;

class Git
{
    static void Main ()
    {
      Pessoa pessoa = new Pessoa("Luan de souza", "123456789x");

      Console.WriteLine(pessoa.Nome);
      Console.WriteLine(pessoa.CPF);

      Console.WriteLine("Mais um teste");
    }
}