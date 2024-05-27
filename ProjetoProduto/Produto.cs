namespace ProjetoProduto;

public class Produto{ 
    
    public string Nome;
    public double Preco;
    public int Quantidade;


    public double ValorTotaEmEstoque(){
        return Preco * Quantidade;
    }
}
