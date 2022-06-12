namespace Exercicios_POOSafra
{
    internal class TestaMetodosGerente
    {
        public void Testar()
        {
            Gerente gerente1 = new("Marcelo Mello", 5000.05);
            Gerente gerente2 = new("Julia Silva", 6000.55);

            gerente1.ConsultarDados();
            Console.WriteLine("-------------------");
            gerente2.ConsultarDados();
        }
    }
}
