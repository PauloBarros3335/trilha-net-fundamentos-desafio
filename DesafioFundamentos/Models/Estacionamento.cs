// namespace DesafioFundamentos.Models
// {
//     public class Estacionamento
//     {
//         private decimal precoInicial = 0;
//         private decimal precoPorHora = 0;
//         private List<string> veiculos = new List<string>();

//         public Estacionamento(decimal precoInicial, decimal precoPorHora)
//         {
//             this.precoInicial = precoInicial;
//             this.precoPorHora = precoPorHora;
//         }

//         public void AdicionarVeiculo()
//         {
//             // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
//             // *IMPLEMENTE AQUI*
//             Console.WriteLine("Digite a placa do veículo para estacionar:");
//         }

//         public void RemoverVeiculo()
//         {
//             Console.WriteLine("Digite a placa do veículo para remover:");

//             // Pedir para o usuário digitar a placa e armazenar na variável placa
//             // *IMPLEMENTE AQUI*
//             string placa = "";

//             // Verifica se o veículo existe
//             if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
//             {
//                 Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

//                 // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
//                 // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
//                 // *IMPLEMENTE AQUI*
//                 int horas = 0;
//                 decimal valorTotal = 0; 

//                 // TODO: Remover a placa digitada da lista de veículos
//                 // *IMPLEMENTE AQUI*

//                 Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
//             }
//             else
//             {
//                 Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
//             }
//         }

//         public void ListarVeiculos()
//         {
//             // Verifica se há veículos no estacionamento
//             if (veiculos.Any())
//             {
//                 Console.WriteLine("Os veículos estacionados são:");
//                 // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
//                 // *IMPLEMENTE AQUI*
//             }
//             else
//             {
//                 Console.WriteLine("Não há veículos estacionados.");
//             }
//         }
//     }
// }









using System.Linq; 

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>(); // Lista para armazenar as placas dos veículos
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
           
            string? placa = Console.ReadLine(); 

           
            if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine($"Veículo com placa '{placa.ToUpper()}' adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa inválida. Por favor, digite uma placa válida.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            
            string? placa = Console.ReadLine();
           
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                
                if (!int.TryParse(Console.ReadLine(), out horas) || horas <= 0)
                {
                    Console.WriteLine("Quantidade de horas inválida. Por favor, digite um número inteiro maior que zero.");
                    return; 
                }

                
                decimal valorTotal = precoInicial + (precoPorHora * horas);

               
                veiculos.Remove(placa.ToUpper());

     
                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
               
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos estacionados
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Itera sobre a lista de veículos e os exibe
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"Vaga {i + 1}: {veiculos[i]}"); // Exibe a vaga e a placa
                }
            }
            else
            {
                // Mensagem caso não haja veículos estacionados
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}











