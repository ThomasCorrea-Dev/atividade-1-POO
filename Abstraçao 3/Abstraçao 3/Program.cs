/* Produto 1 */

using Abstraçao_3;

Produto produto1 = new Produto(204998, "Notebook", 10, "1.782,00");

Console.WriteLine("O codigo do produto é:" + produto1.Codigo);
Console.WriteLine("O nome do produto é:" + produto1.Nome);
produto1.Valor();
Console.WriteLine("O preço do produto é:" + produto1.Preço);

/* Produto 2 */

Produto produto2 = new Produto(203898, "Mouse", 32, "180,00");

Console.WriteLine("\nO codigo do produto é:" + produto2.Codigo);
Console.WriteLine("O nome do produto é:" + produto2.Nome);
produto2.Valor();
Console.WriteLine("O preço do produto é:" + produto2.Preço);

/* Produto 3 */

Produto produto3 = new Produto(300089, "Teclado", 21, "209,99");

Console.WriteLine("\nO codigo do produto é:" + produto3.Codigo);
Console.WriteLine("O nome do produto é:" + produto3.Nome);
produto3.Valor();
Console.WriteLine("O preço do produto é:" + produto3.Preço);




















Console.ReadLine();
