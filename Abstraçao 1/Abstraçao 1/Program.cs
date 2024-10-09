/* livro 1 */

using Abstraçao_1;

livro livro1 = new livro("Memorias postumas", "machado de assis", "Sesi-sp", 1881);

Console.WriteLine("O nome do livro é:" + livro1.Titulo);
Console.WriteLine("O autor do livro é:" + livro1.Autor);
Console.WriteLine("A editora do livro é:" + livro1.Editora);
Console.WriteLine("O livro foi lançado em:" + livro1.Anodelançamento);

/* livro 2 */

livro livro2 = new livro("Quincas borba", "machado de assis", "Sesi-sp", 1891);

Console.WriteLine("\nO nome do livro é:" + livro2.Titulo);
Console.WriteLine("O autor do livro é:" + livro2.Autor);
Console.WriteLine("A editora do livro é:" + livro2.Editora);
Console.WriteLine("O livro foi lançado em:" + livro2.Anodelançamento);

/* livro 3 */

livro livro3 = new livro("Dom casmurro", "machado de assis", "Sesi-sp", 1899);

Console.WriteLine("\nO nome do livro é:" + livro3.Titulo);
Console.WriteLine("O autor do livro é:" + livro3.Autor);
Console.WriteLine("A editora do livro é:" + livro3.Editora);
Console.WriteLine("O livro foi lançado em:" + livro3.Anodelançamento);




Console.ReadLine();

