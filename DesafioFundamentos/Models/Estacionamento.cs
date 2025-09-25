namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string inputPlaca;

            do
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                inputPlaca = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(inputPlaca));

            veiculos.Add(inputPlaca);
        }
        public void RemoverVeiculo()
        {
            string inputPlaca;

            do
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                inputPlaca = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(inputPlaca));

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == inputPlaca.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(inputPlaca);

                Console.WriteLine($"O veículo {inputPlaca} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                veiculos.ForEach(veiculo => Console.WriteLine(veiculo));
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
