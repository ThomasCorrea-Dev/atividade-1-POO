/* Aluno 1 */

using Abstraçao_2;

Aluno aluno1 = new Aluno(new DateTime(2007, 9, 18), "Thomas Correa", 1983, "thomas.correa@portalsesisp");


Console.WriteLine("O aluno nasceu em:" + aluno1.Nascimento);
Console.WriteLine("O nome do aluno é:" + aluno1.Nome);
Console.WriteLine("O RM do aluno é:" + aluno1.RM);
Console.WriteLine("O email do aluno é:" + aluno1.Email);

/* Aluno 2 */

Aluno aluno2 = new Aluno(new DateTime(2008, 3, 11), "Vitoria Bougleux", 1972, "Vitoria.bxbx@portalsesisp");


Console.WriteLine("\nO aluno nasceu em:" + aluno2.Nascimento);
Console.WriteLine("O nome do aluno é:" + aluno2.Nome);
Console.WriteLine("O RM do aluno é:" + aluno2.RM);
Console.WriteLine("O email do aluno é:" + aluno2.Email);

/* Aluno 3 */

Aluno aluno3 = new Aluno(new DateTime(2006, 9, 5), "Caua Leite", 1925, "Caua.Leite@portalsesisp");


Console.WriteLine("\nO aluno nasceu em:" + aluno3.Nascimento);
Console.WriteLine("O nome do aluno é:" + aluno3.Nome);
Console.WriteLine("O RM do aluno é:" + aluno3.RM);
Console.WriteLine("O email do aluno é:" + aluno3.Email);


Console.ReadLine();