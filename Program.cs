using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Console.Write("Digite o nome do primeiro hóspede: ");
Pessoa p1 = new Pessoa(nome: Console.ReadLine());

Console.Write("Digite o nome do segundo hóspede: ");
Pessoa p2 = new Pessoa(nome: Console.ReadLine());

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 10, valorDiaria: 100);

// Cria uma nova reserva, passando a suíte e os hóspedes
Console.Write("Digite a quantidade de diárias: ");
Reserva reserva = new Reserva(diasReservados: Convert.ToInt32(Console.ReadLine()));
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.Clear();
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
if(reserva.DiasReservados >= 10)
{
    Console.WriteLine($"Houve um desconto de 10% e o valor diária ficou em: {reserva.CalcularValorDiaria()}");
}
else
{
    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
}
