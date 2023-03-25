// Cria a classe pública Lanche, que herda da super classe Categoria
public class Lanche : Categoria
{
    // Cria as propriedades da classe
    public string DescLanche { get; set; }
    // Utiliza o método ToLowerInvariant() para ignorar letras minúsculas e maiúsculas na hora de aplicar o filtro
    private string _NomeLanche;
    public string NomeLanche
    {
        get { return _NomeLanche; }
        set { _NomeLanche = value.ToLowerInvariant(); }
    }
    public double PrecoLanche {get; set;} 
    // Pega a data atual do sistema
    public DateTime DtFabricacao{get; set;} = DateTime.Now;
}