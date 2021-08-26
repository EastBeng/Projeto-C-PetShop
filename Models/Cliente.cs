using System;
using System.IO;
using System.Text;
public class Cliente : Cadastro
{
  public string CPF { get; }

  public Cliente(string nome, string senha, string endereco, string telefone, string cpf)
    : base(nome, senha, endereco, telefone, "pessoaFisica")
  {
    CPF = cpf;
  }

  public override void Cadastrar(){
			StreamWriter sw = new StreamWriter("Clientes.csv",true);
			sw.WriteLine(Nome +  ';' + Senha +  ';' + Endereco + ';' + Telefone + ';' + CPF + ';' + Tipo);
			sw.Close();
			
	}
  

	public override bool Logar(string nome, string senhas){
		return true;
	}

  public void VisualizarPet()
  {
		string line;
    StreamReader sr = new StreamReader("Animais.csv");
    
    line = sr.ReadLine();

    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    
    sr.Close();
    
  }
  
  public void AdotarPet(Animal codigoAnimal)
  {

			string line;
			StreamReader sr = new StreamReader("Animais.csv");
			
			line = sr.ReadLine();

			while (line != null)
			{
					string[] animal = line.Split(";");

					if(line[4].ToString() == codigoAnimal.Cod){
						StreamWriter sw = new StreamWriter("Adocao.csv",true);
						sw.WriteLine(line[0] +  ';' + line[1] +  ';' + line[2] + ';' + line[3] + ';' + line[4] + ';' + line[5]);
						sw.Close();
					}
					line = sr.ReadLine();
			}
			
			sr.Close();    	
  }
}