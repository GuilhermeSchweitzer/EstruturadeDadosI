public class Imovel
{
    public string Nome { get; set; } = "";
    public string Descricao { get; set; } = "";
    public decimal Valor { get; set; }
    public int NumeroComodos { get; set; }
    public List<string> Imagens { get; set; } = new List<string>();

    public Categoria Categoria { get; set; }
    public Localidade Localidade { get; set; }
    public Negocio Negocio { get; set; }
}
