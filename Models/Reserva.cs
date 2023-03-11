namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suite!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            bool quantidadeDias = false;
            decimal valor = DiasReservados * Suite.ValorDiaria;

            quantidadeDias = DiasReservados >= 10;
            valor = quantidadeDias ? valor - (valor * 0.1M) : valor;
            return valor;
        }

        public void ListarHospedes()
        {
            foreach (var hospede in this.Hospedes)
            {
                System.Console.WriteLine(hospede);
            }
        }
    }
}