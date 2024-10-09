namespace Abstraçao_4
{
    public class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Velocidade { get; set; }

        public int Acelerar { get; set; }

        public int Desacelerar { get; set; }

        public Carro(string marca, string modelo, string velocidade, int acelerar, int desacelerar)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = velocidade;
            Acelerar = acelerar;
            Desacelerar = desacelerar;
        }

        public void acelerar()
        {
            Console.WriteLine($"O carro acelerou até a velocidade maxima em {Acelerar} segundos ");
        }

        public void desacelerar()
        {
            Console.WriteLine($"O carro dasacelerou da velocidade maxima em {Desacelerar} segundos ");
        }
        


    }
}
