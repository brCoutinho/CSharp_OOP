


namespace _06___ByteBank
{
    public class ContaCorrente
    {
        private Cliente Titular { get; set; }
        private int Agencia { get; set; }
        private int Numero { get; set; }
        private double saldo = 100;


        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                this.saldo = value;
            }
        }

       
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

