using System;
public abstract class Cadastro
{
  public string Nome { get; private set; }
  public string Senha { get; private set; }
  public string Endereco {get; private set;}
  public string Telefone { get; private set; }
	public string Tipo { get; private set; }

  public Cadastro(string nome, string senha, string endereco, string telefone, string tipo){
    Nome = nome;
    Senha = senha;
    Endereco = endereco;
    Telefone = telefone;
    Tipo = tipo;
  }

  public abstract bool Logar(string nome, string senha);

  public abstract void Cadastrar(); 

  public void Logout()
  {
    Console.WriteLine("Tchau!");
    Environment.Exit(0);
  }

	
}