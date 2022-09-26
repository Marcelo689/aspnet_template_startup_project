namespace challange.Models
{
    public class Teste
    {
        public Teste()
        {
            Nome = MeuNome();
        }
        public string Nome { get; set; }

        public string MeuNome()
        {
            return "Marcelo";
        }
        public List<string> RetornaLinhas()
        {
            var linha = new List<string>();



            return linha;
        }
        public string Sobrenome()
        {
            return "Santos Jaeger";
        }
    }
}
