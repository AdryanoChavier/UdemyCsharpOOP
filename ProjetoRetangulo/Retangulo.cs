namespace ProjetoRetangulo;

public class Retangulo
{
    public double Largura;
    public double Altura;

    public double Area(){
        return Largura * Altura
    }
    public double Perimetro(){
        return Largura * 2 + Altura * 2
    }

    public double Diagonal(){
        return Math.sqrt(Math.pow(Largura, 2) + Math.pow(Altura, 2));
         
    }


}
