
namespace Abstraçao_1
{
    public class livro
        {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public int Anodelançamento { get; set; }

        public livro(string titulo, string autor, string editora, int anodelançamento)
            {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Anodelançamento = anodelançamento;
            }
        }
 }
