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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (string.IsNullOrEmpty(placa))
            {
                System.Console.WriteLine("Atenção, placa não informada, verifique!");
            }
            else if (placa.Length < 8 || placa.Length > 8)
            {
                System.Console.WriteLine("Atenção, placa incorreta, verifique!");                
            }
            else if (veiculos.Any(v => v.Equals(placa.ToUpper())))
            {
                System.Console.WriteLine("Veúculo já existe, verificque!");
            }
            else
            {
                veiculos.Add(placa.ToUpper());
                System.Console.WriteLine("Veículo estacionado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {
  
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = 0; 
                valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string item in veiculos)
                {
                    System.Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

    }
}
