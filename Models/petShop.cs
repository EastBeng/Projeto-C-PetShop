using System.IO;
using System.Text;
using System;
class petShop : Cadastro{
  
	public string Cnpj { get; } 
	public int qtdAdocao { get; private set;}

	public petShop(string nome, string senha, string endereco, string telefone,string cnpj):base(nome,senha,endereco,telefone, "pessoaJuridica"){
		Cnpj = cnpj;
	}
	public void cadastrarPet(Animal animal){
		StreamWriter sw = new StreamWriter("Animais.csv", true);
		
		sw.WriteLine(animal.Nome+";"+animal.Genero+";"+animal.Especie+";"+animal.Idade+";"+animal.Cod+";"+animal.Raca);
		sw.Close();
	}
	public void visualizarAdocoes(){
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
	public override void Cadastrar(){
		StreamWriter sw = new StreamWriter("petShop.csv", true);
		
		sw.WriteLine(Nome+";"+Senha+";"+Endereco+";"+Telefone+";"+Cnpj+";"+Tipo);
		sw.Close();
	}
	public override bool Logar(string nome, string senhas){
		return true;
	}
}