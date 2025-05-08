/* 
1. Registrar entrada de um espectador: solicitar nome, idade, número do ingresso e tipo de ingresso. 
Os dados devem ser armazenados no vetor correspondente à categoria do ingresso, se houver disponibilidade.

2. Registrar saída de um espectador: solicitar o número do ingresso e tipo de ingresso. 
O espectador deve ser removido do vetor correspondente e o ingresso liberado novamente para uso.

3. Consultar ingressos disponíveis: exibir quantos ingressos ainda estão disponíveis em cada uma das categorias, 
considerando a capacidade máxima e o número de entradas registradas nos vetores.

4. Exibir resumo do evento: mostrar:
• Número total de espectadores presentes;
• Quantidade e percentual de espectadores por categoria;
• Ingressos disponíveis por categoria;

5. Listar todos os espectadores presentes: 

exibir os dados (nome, idade, número do  ingresso e tipo de ingresso) de todos os espectadores registrados nos vetores,
organizados por categoria.

6. Sair */

class Program
{
    static void Main()
    {
        string tipo;
        string[] ingVip = new string[3]; // [Quantidade máxima de ingressos]
        string[] ingComum = new string[3]; // [Quantidade máxima de ingressos]
        string[] ingPriori = new string[3]; // [Quantidade máxima de ingressos] 
                                            // em ing... » Vão armazenar o nome de espectador 
        string[] nome = new string[9]; // nome do espectador [quantidade de pessoas possíveis]
        int[] idade = new int[9]; // idade espectador
        int[] numeroIngresso = new int[9]; //n° do ingresso
        int opcao = 0, entradas = 0, contVip = 0, contComum = 0, contPriori = 0;
        // entradas vai ser o índice para quantos espectadores já entraram que deve ser travado quando os contadores atingirem o Length de todos vetores ing
        // cont... é o índice para marcar as posições dentro dos respectivos vetores e também informa quantos já adquiriram o respectivo ingresso

        do
        {
            System.Console.WriteLine("Escolha uma opção:\n1. Registrar entrada de um espectador\n2. Registrar saída de um espectador\nConsultar ingressos disponíveis\n4. Exibir resumo do evento\n5. Listar todos os espectadores presentes\n6. Sair");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: // Entrada de espectador

                    System.Console.WriteLine("Insira o seu nome");
                    nome[entradas] = Console.ReadLine();
                    System.Console.WriteLine("Insira sua idade");
                    idade[entradas] = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Insira o n° do seu ingresso");
                    numeroIngresso[entradas] = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Insira o tipo do seu ingresso (V, C ou P)");
                    tipo = Console.ReadLine();

                    switch (tipo)
                    {
                        case "V":
                            if (contVip < ingVip.Length)
                            {
                                contVip++;
                                entradas++;
                                ingVip[contVip] = nome[entradas];
                            }
                            else
                                System.Console.WriteLine("Não há mais ingressos VIP disponíveis");
                            break;
                        // se o contador de quantos entraram em VIP for menor do que a quantidade de índice de Ingressos Vip, será inserido o nome do espectador em IngVip e aumentará o contador de entradas 

                        case "C":
                            if (contComum < ingComum.Length)
                            {
                                contComum++;
                                entradas++;
                                ingComum[contComum] = nome[entradas];
                            }
                            else
                                System.Console.WriteLine("Não há mais ingressos Comuns disponíveis");
                            break;
                        // se o contador de quantos entraram em Comum for menor do que a quantidade de índice de Ingressos Comuns, será inserido o nome do espectador em ingComum e aumentará o contador de entradas 

                        case "P":
                            if (contPriori < ingPriori.Length)
                            {
                                contPriori++;
                                entradas++;
                                ingPriori[contPriori] = nome[entradas];
                            }
                            else
                                System.Console.WriteLine("Não há mais ingressos Prioritários disponíveis");
                            break;
                            // se o contador de quantos entraram em VIP for menor do que a quantidade de índice de Ingressos Prioritários, será inserido o nome do espectador em IngPriori e aumentará o contador de entradas 
                    }
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:
                    break; //Encerra o menu
            }

        } while (opcao != 6);


    }
}