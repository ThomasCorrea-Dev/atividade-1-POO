/* Carro 1 */

using Abstraçao_4;

Carro carro1 = new Carro("Mazda", "RX-7", "200KM/H", 12, 10);

Console.WriteLine("O seu carro é da marca:" + carro1.Marca);
Console.WriteLine("Do modelo:" + carro1.Modelo);
Console.WriteLine("A velocidade maxima dele é de:" + carro1.Velocidade);
carro1.acelerar();
carro1.desacelerar();

/* Carro 2 */

Carro carro2 = new Carro("corvette", "Z06", "280KM/H", 7, 9);

Console.WriteLine("\nO seu carro é da marca:" + carro2.Marca);
Console.WriteLine("Do modelo:" + carro2.Modelo);
Console.WriteLine("A velocidade maxima dele é de:" + carro2.Velocidade);
carro2.acelerar();
carro2.desacelerar();

/* Carro 3 */

Carro carro3 = new Carro("McLaren", "F1", "290KM/H", 6, 12);

Console.WriteLine("\nO seu carro é da marca:" + carro3.Marca);
Console.WriteLine("Do modelo:" + carro3.Modelo);
Console.WriteLine("A velocidade maxima dele é de:" + carro3.Velocidade);
carro3.acelerar();
carro3.desacelerar();

Console.ReadLine();