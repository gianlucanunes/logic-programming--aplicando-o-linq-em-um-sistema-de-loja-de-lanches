// Cria a classe e herda a herança da classe Categoria.
public class Lanche : Categoria
{

    private string _NomeLanche;
    public string NomeLanche
    {
        get { return _NomeLanche; }
        set { _NomeLanche = value.ToLowerInvariant(); }
    }


    public string DescLanche {get; set;} // Descrição.

    public double PrecoLanche {get; set;} // Preço.

    public DateTime DtFabricacao{get; set;} = DateTime.Now; // Data de fabricação sendo a data atual do sistema.

    // De acordo com o diagrama, a classe não necessita de métodos.

}