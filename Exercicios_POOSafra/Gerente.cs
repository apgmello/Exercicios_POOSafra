namespace Exercicios_POOSafra
{
    internal class Gerente
    {
        private string? nome;
        private double salario;

        public Gerente(string? nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public void ImprimirSalario()
        {
            Console.WriteLine($"Salário: {salario}");
        }
        public void ConsultarDados()
        {
            Console.WriteLine($"Nome: {nome}");
            ImprimirSalario();
        }
    }
}
