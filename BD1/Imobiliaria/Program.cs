
class Prog
{
    static void Main(string[] args)
    {
        Imovel casa = new Imovel
        {
            Nome = "Casa no Centro",
            Descricao = "Casa no centro, próximo a loja Caramelo. Uma sala, uma cozinha, dois quanrtos e uma lavanderia",
            Valor = 335000,
            NumeroComodos = 6,
            Imagens = new List<string> { "imagem1.jpg", "imagem2.jpg" },
            Categoria = Categoria.Casa,
            Localidade = Localidade.Urbano,
            Negocio = Negocio.Venda
        };

    }
}