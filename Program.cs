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

exibir os dados (nome, idade, número do ingresso e tipo de ingresso) de todos os espectadores registrados nos vetores,
organizados por categoria.

6. Sair */

class Program
{
    static void Main()
    {
        string tipo;
        string[] ingVip = new string[3]; // [Quantidade máxima de ingressos de cada tipo]
        string[] ingComum = new string[3]; // [Quantidade máxima de ingressos de cada tipo]
        string[] ingPriori = new string[3]; // [Quantidade máxima de ingressos de cada tipo] 
        string[] nome = new string[9]; // nome do espectador que entrou [quantidade de pessoas possíveis]
        int[] idade = new int[9]; // idade espectador que entrou
        int[] numeroIngresso = new int[9]; //n° do ingresso do espectador que entrou
        string[] tipoIngresso = new string[9]; // tipo do ingresso do espectador que entrou
        int opcao = 0, entradas = 0, contVip = 0, contComum = 0, contPriori = 0;
        // opcao é a resposta do menu
        // entradas vai ser o índice para quantos espectadores já entraram que deve ser travado quando os contadores atingirem o Length de todos vetores ing
        // em ing... » Vão armazenar o nome de espectador 
        // cont... é o índice para marcar as posições dentro dos respectivos vetores e também informa quantos já adquiriram o respectivo ingresso

        do
        {
            System.Console.WriteLine("Escolha uma opção:\n1. Registrar entrada de um espectador\n2. Registrar saída de um espectador\n3. Consultar ingressos disponíveis\n4. Exibir resumo do evento\n5. Listar todos os espectadores presentes\n6. Sair");
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
                                ingVip[contVip] = nome[entradas];
                                tipoIngresso[entradas] = "VIP";
                                contVip++;
                                entradas++;
                            }
                            else
                                System.Console.WriteLine("Não há mais ingressos VIP disponíveis");
                            break;
                        // se o contador de quantos entraram em VIP for menor do que a quantidade de índice de Ingressos Vip, será inserido o nome do espectador em IngVip e aumentará o contador de entradas 

                        case "C":
                            if (contComum < ingComum.Length)
                            {
                                ingComum[contComum] = nome[entradas];
                                tipoIngresso[entradas] = "Comum";
                                entradas++;
                                contComum++;
                            }
                            else
                                System.Console.WriteLine("Não há mais ingressos Comuns disponíveis");
                            break;
                        // se o contador de quantos entraram em Comum for menor do que a quantidade de índice de Ingressos Comuns, será inserido o nome do espectador em ingComum e aumentará o contador de entradas 

                        case "P":
                            if (contPriori < ingPriori.Length)
                            {
                                ingPriori[contPriori] = nome[entradas];
                                tipoIngresso[entradas] = "Prioritário";
                                entradas++;
                                contPriori++;
                            }
                            else
                                System.Console.WriteLine("Não há mais ingressos Prioritários disponíveis");
                            break;
                            // se o contador de quantos entraram em VIP for menor do que a quantidade de índice de Ingressos Prioritários, será inserido o nome do espectador em IngPriori e aumentará o contador de entradas 
                    }
                    break;

                case 2: //Saída espectador

                    //Solicitar número do ingresso
                    System.Console.WriteLine("Insira o n° do seu ingresso");
                    numeroIngresso[entradas] = int.Parse(Console.ReadLine()); //erro por ter [entradas]

                    //Solicitar o tipo de ingresso
                    System.Console.WriteLine("Insira o tipo do seu ingresso");
                    tipoIngresso[entradas] = Console.ReadLine();//erro por ser tipoIngresso

                    //Criar um for para percorrer, conferir se o numero do ingresso esta no tipo do ingresso
                    //Diminuir entradas, diminuir contadores, nome recebe aspas, numero recebe zero (pessoa saindo)
                    //Apagar o nome do espectador (ex.: nomeEspectador[i] = ""). Zerar o número do ingresso (ex.: numeroIngresso[i] = 0). Apagar o tipo de ingresso (ex.: tipoIngresso[i] = ""). (Opcional) Diminuir o contador de entradas, se o controle do seu programa exigir isso.

                    //Fazer a busca no cadastro
                    bool encontrado = false;
                    
                    for (int i = 0; i < entradas; i++)
                    {
                        //Verificar se o número e tipo de ingresso conferem
                        if (numeroIngresso[i] == numeroIngresso && tipoIngresso[i] == tipo) //colocar os tipos (tipo == "V" && tipoIngresso[i] == "VIP") ||..
                        {
                            System.Console.WriteLine($"Ingresso encontrado para {nome[i]}.");

                            //Função que libera o ingresso
                            nome[i] = " ";
                            numeroIngresso[i] = 0;
                            tipoIngresso[i] = " ";

                            System.Console.WriteLine("Ingresso liberado.");

                            encontrado = true; //Marcar que foi encontado (função bool)
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        System.Console.WriteLine("Ingresso não encontrado.");
                        return;
                    }

                    System.Console.WriteLine("\nSituação atual dos ingressos: ");

                    for (int i = 0; i < entradas; i++)
                    {
                        System.Console.WriteLine($"Posição {i} - Nome: {nome[i]}, Número: {numeroIngresso[i]}, Tipo: {tipoIngresso[i]}");
                    }
                    break;

                case 3: // Consultar ingressos disponíveis 

                    System.Console.WriteLine("Ainda estão disponíveis:\nVips: " + (ingVip.Length - contVip) + "\nComuns: " + (ingComum.Length - contComum) + "\nPrioritários: " + (ingPriori.Length - contPriori));

                    break;

                case 4:

                    // Exibir resumo do evento: 
                    // • Número total de espectadores presentes; - Usar contador entradas que e o indicie de espectadores (soma)
                    // • Quantidade e percentual de espectadores por categoria; 
                    // • Ingressos disponíveis por categoria - Verificar a quantidade maxima de cada um dos tipo de ingressos diponives;

                    int totalPresentes = contVip + contComum + contPriori; 

                    System.Console.WriteLine("\n===== RESUMO DO EVENTO =====");

                    System.Console.WriteLine($"Número total de espectadores presentes: {totalPresentes}");

                    if (totalPresentes > 0) //Verifica se há pelo menos um espectador presente
                    {
                        double percVip = (contVip * 100.0) / totalPresentes;
                        double percComum = (contComum * 100.0) / totalPresentes;
                        double percPriori = (contPriori * 100.0) / totalPresentes;

                        System.Console.WriteLine("\nQuantidade e percentual por categoria:"); //Exibe os dados de quantidade e percentual
                        System.Console.WriteLine($"VIP: {contVip} ({percVip:F2}%)");
                        System.Console.WriteLine($"Comum: {contComum} ({percComum:F2}%)");
                        System.Console.WriteLine($"Prioritário: {contPriori} ({percPriori:F2}%)");
                    }
                    else
                    {
                        System.Console.WriteLine("Nenhum espectador presente no momento.");
                    }

                    System.Console.WriteLine("\nIngressos disponíveis por categoria:"); //Mostra a quantidadede ingressos ainda disponíveis
                    System.Console.WriteLine($"VIP: {ingVip.Length - contVip}");
                    System.Console.WriteLine($"Comum: {ingComum.Length - contComum}");
                    System.Console.WriteLine($"Prioritário: {ingPriori.Length - contPriori}");

                    break;

                case 5: // Listar todos os espectadores presentes
                    for (int i = 0; i < entradas; i++)

                        System.Console.WriteLine($"Espectador {i + 1}: {nome[i]}, {idade[i]} anos,  ingresso n° {numeroIngresso[i]}, do tipo {tipoIngresso[i]}");

                    break;

                case 6: //Encerra o menu

                    System.Console.WriteLine("Encerrando o programa. Obrigado por utilizar!");

                    break;

                default:

                    System.Console.WriteLine("Insira uma opção válida!");

                    break;
            }

        } while (opcao != 6);
    }
}