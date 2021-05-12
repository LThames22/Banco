namespace Banco
{
    class Cliente
    {
        public Cuenta Cuenta { get; private set; }
        
        public string nombre;
        public string apelldio;
        public bool efetivo;
        public int CBU { get; set; }
        public double Saldo;
    }
}