
namespace Abstraçao_2
{
    public class Aluno
    {
        public DateTime Nascimento { get; set; }

        public string Nome { get; set; }

        public int RM { get; set; }

        public string Email { get; set; }

        public Aluno(DateTime nascimento, string nome, int rM, string email)
        {
            Nascimento = nascimento;
            Nome = nome;
            RM = rM;
            Email = email;
        }

        public Aluno(DateTime nascimento)
        {
            Nascimento = nascimento;
        }
    }
}
