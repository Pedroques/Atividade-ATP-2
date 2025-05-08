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
        string[] ingVip = new string[3]; // [Quantidade máxima de ingressos]
        string[] ingComum = new string[3]; // [Quantidade máxima de ingressos]
        string[] ingPriori = new string[3]; // [Quantidade máxima de ingressos]
        string[] nome = new string[9]; // nome do espectador [quantidade de pessoas possíveis]
        int[] idade = new int[9]; // idade espectador
        int[] numeroIngresso = new int[9]; //n° do ingresso
        string[] tipoIngresso = new string[9]; // tipo do ingresso


    }
}