using System.Globalization;

namespace ProjetoProduto;

public class Produto{ 
    
    public string Nome;
    public double Preco;
    public int Quantidade;


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
        return Nome + ", $ " + Preco.ToString("F2",CultureInfo.InvariantCulture) + " , " + Quantidade + " unidades, Total: $ " + ValorTotaEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
    }

}
