using System.Globalization;

namespace ProjetoProduto;

public class Produto{ 
    
    public string? _nome;
    public double Preco{get;private set;}
    public int Quantidade{get;private set;}

//construtor

    public Produto(){

    }
    public Produto(string nome, double preco, int quantidade){
        _nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
    public string Nome{//Properties
        get{
            return _nome; 
        }
        set{
            if(value != null && value.Length > 1){
                    _nome = value;    
        }
        
        }
    }
    public double ValorTotaEmEstoque(){
        return Preco * Quantidade;
    }
    public void AdicionarProdtuos(int quantidade){
        Quantidade += quantidade;
    }
    public void RemoverProdtuos(int quantidade){
        Quantidade -= quantidade;

    }








    public override string ToString(){
        return _nome + ", $ " + Preco.ToString("F2",CultureInfo.InvariantCulture) + " , " + Quantidade + " unidades, Total: $ " + ValorTotaEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
    }

}
