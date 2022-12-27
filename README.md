# DIO - Trilha .NET - Explorando a linguagem C#

## Contexto
Nesse desafio foi solicitado um sistema de hospedagem, podendo ser usado para realizar uma reserva em um hotel. No projeto há a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que faz um relacionamento entre ambos.
O programa cálcula os valores dos métodos da classe Reserva, que traz a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.
