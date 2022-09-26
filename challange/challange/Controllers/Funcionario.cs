namespace challange.Controllers
{
    
    public class Funcionario
    {
        private string Nome = "";
        private int Matricula;
        private decimal Salario;
        public double dinheiro { get; set; }
        public Funcionario()
        {
            
        }
        public Funcionario(string nome, int matricula, decimal salario)
        {
            Nome = nome;
            Matricula = matricula;
            Salario = salario;

            //decimal 10m
            //float 10.0f
            //double 10.0
        }
        public string getNome()
        {
            return Nome;
        }
        public int getMatricula()
        {
            return Matricula;
        }
        public decimal getSalario()
        {
            return Salario;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public void setMatricula(int numeroMatricula)
        {
            Matricula = numeroMatricula;
        }
        public void setSalario(decimal salario)
        {
            Salario = salario;
        }
        public void MetodoPrincipal()
        {
            var listaFuncionarios = new List<Funcionario>();
            var funcionarioDinheiro = new Funcionario();
            var funcionario1 = new Funcionario("Marcelo1", 22838484, 1500m);
            var funcionario2 = new Funcionario("Marcelo2", 22838484, 1500m);
            var funcionario3 = new Funcionario("Marcelo3", 22838484, 1500m);
            var funcionario4 = new Funcionario("Marcelo4", 22838484, 1500m);

            funcionarioDinheiro.dinheiro = 1000;
            var dinheiro = funcionario1.dinheiro;

            listaFuncionarios.Add(funcionario1);
            listaFuncionarios.Add(funcionario2);
            listaFuncionarios.Add(funcionario3);
            listaFuncionarios.Add(funcionario4);

            decimal total = 0m;
            var numero = 0m;
            foreach(Funcionario funcionario in listaFuncionarios)
            {
                numero = funcionario.getSalario();
                total += funcionario.getSalario();
            }
            var media = total / listaFuncionarios.Count;

            Console.WriteLine(media);   
        }
    }
}
