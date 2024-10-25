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
            int quantidadeHospedesCadastrados = hospedes.Count;
            int capacidadeDaSuite = Suite.Capacidade;

            if (quantidadeHospedesCadastrados <= Suite.Capacidade && quantidadeHospedesCadastrados > 1)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"A Quantidade de {quantidadeHospedesCadastrados} hóspedes excedeu a capacidade de {capacidadeDaSuite} hóspedes da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.10M);
            }

            return valor;
        }
    }
}