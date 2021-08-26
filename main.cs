using System;

class Program {
  public static void Main (string[] args) {
    
    // Cliente
    Cliente alfredo = new Cliente("Alfredo", "admin", "Rua dos Pombais, Madri", "999999999", "18888899946");
    
		// Pet Shop
		petShop BanhoETosa = new petShop("Banho e Tosa", "4586971", "Chacara Parreiral", "2795847621","123456789123");
    
    //Animal
    Animal meuAnimalzinho = new Animal("Bob","Indefinido",2,"Rara","Exotica");

    
		//Metodos petShop
    
		//BanhoETosa.Logar(BanhoETosa.Nome,BanhoETosa.Senha);
    //BanhoETosa.Logout();
    BanhoETosa.Cadastrar();
		BanhoETosa.cadastrarPet(meuAnimalzinho);
    BanhoETosa.visualizarAdocoes();

    //Metodos Cliente

    //alfredo.Logar(alfredo.Nome,alfredo.Senha);
    //alfredo.Logout();
    alfredo.Cadastrar();
    alfredo.VisualizarPet();
    alfredo.AdotarPet(meuAnimalzinho);

    
  }

}