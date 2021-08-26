using System;

public class Animal{
	public string Nome { get; private set; }
	public string Genero { get; private set; }
	public int Idade { get; private set; }
	public string Cod { get; private set; }
	public string Especie { get; private set; }
	public string Raca { get; private set; }

  private static int _geraCodigo = 1;
	
  public Animal(string nome,string genero,int idade,string especie,string raca){
		Nome = nome;
		Genero = genero;
		Idade = idade;
    Cod = Convert.ToString(_geraCodigo);
		Especie = especie;
		Raca = raca;

    _geraCodigo++;
	}


}