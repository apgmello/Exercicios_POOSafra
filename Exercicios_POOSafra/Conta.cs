namespace Exercicios_POOSafra
{
    internal class Conta
    {
        //atributo
        private int numero; 
        private double saldo;
        private List<double> extrato = new List<double>();

        public Conta(int numero, double saldo) //construtor
        {
            this.numero = numero;
            this.saldo = saldo;
            extrato.Add(saldo);
        }
        public void Depositar(double valor) //metodo
        {
            this.saldo += valor;
            this.extrato.Add(valor);
        }

        public void Sacar(double valor)
        {
            if (saldo < valor)
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            this.saldo -= valor;
            this.extrato.Add(valor * -1);
        }

        public void Extrato()
        {
            Console.WriteLine($"Saldo inicial: {extrato[0]}");

            for (int i = 1; i < extrato.Count; i++)
            {
                Console.WriteLine($"{(extrato[i] < 0 ? "Saque:" : "Depósito:")} {extrato[i]}");
            }
            Saldo();
        }
        public void Saldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
    }
}
