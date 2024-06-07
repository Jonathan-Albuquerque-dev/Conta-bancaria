using System.Globalization;

namespace ContaBancaria {
    internal class User {
        public int NumConta {  get; private set; }
        public string Name { get; private set; }
        public double Saldo { get; private set; }

        public User(int numConta , string name) {
            this.NumConta = numConta;
            this.Name = name;
        }

        public User(int numConta, string name, double depositoInicial) : this(numConta, name) {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito) {
            this.Saldo += deposito;
        }

        public void Saque(double saque) {
            this.Saldo -= saque+5;
        }

        public override string ToString() {
            return $"Conta {NumConta}, Titular: {Name}, Saldo : {Saldo.ToString("F2")}R$";
        }

    }
}
