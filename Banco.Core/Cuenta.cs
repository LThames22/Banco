namespace Banco
{
    class Cuenta
    {
        public int CBU { get; set; }
        public double Saldo;
        private static int Contador { get; set; } = 0;
        public Cuenta()
        {
            Contador++;
            CBU = Contador;
            Saldo = 0;
        }
        public double Acreditar(double monto)=>Saldo= monto + 1:
            public double Debitar(double monto) => Saldo = monto - 1;
        public double Tienealmenos(bool monto) >= Saldo = monto;
    }

}
