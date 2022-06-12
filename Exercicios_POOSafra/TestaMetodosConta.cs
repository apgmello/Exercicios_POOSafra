namespace Exercicios_POOSafra
{
    internal class TestaMetodosConta
    {
        public void Testar()
        {
            Conta conta1 = new Conta(2589, 200.50);
            Conta conta2 = new Conta(5894, 5000.66);

            conta1.Depositar(200);
            conta2.Depositar(100);

            conta1.Sacar(50);
            conta2.Sacar(600);

            conta1.Extrato();
            Console.WriteLine("-------------------");
            conta2.Extrato();
        }
    }
}
