namespace Abstraçao_3
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public int Estoque { get; set; }

        public string Preço { get; set; }

        public Produto(int codigo, string nome, int estoque, string preço)
        {
            Codigo = codigo;
            Nome = nome;
            Estoque = estoque;
            Preço = preço;
        }

        public void Valor()
        {
            Console.WriteLine($"O valor em estoque é: {Estoque} ");
        }
    }
}
