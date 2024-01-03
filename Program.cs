using System.Diagnostics;
using Projeto30.Models;

string nome = string.Empty;
int idade = 0;

string maisVelho = string.Empty;
int maiorIdade = 0;

for(int i=1; i<=3; i++){ // loop para inserção dos dados
    idade = 0; // a idade deve zerar para que a validação dela seja feita
    Console.Clear();
    Console.Write($"\nInsira o nome {i}: ");
    nome = Console.ReadLine();

    while(idade <= 0){ // loop de validação da idade inserida
        Console.Write($"Insira a idade de {nome}: ");
        idade = Convert.ToInt32(Console.ReadLine());
        if (idade <= 0){
            Console.WriteLine("\nIdade inválida!\n");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }   

    // a primeira idade inserida será a maior para que depois seja comparada com as outras
    if(maiorIdade == 0){
        maisVelho = nome;
        maiorIdade = idade;
    }

    switch(i){
        case 1:
            Pessoa p1 = new Pessoa(nome, idade); // instanciando a primeira pessoa e recebendo seus dados
            if(p1.idade>maiorIdade){ // verificando se a idade da primeira pessoa é a maior
                maisVelho = p1.nome;
                maiorIdade = p1.idade;
            }
            break;

        case 2:
            Pessoa p2 = new Pessoa(nome, idade); // instanciando a segunda pessoa e recebendo seus dados
            if(p2.idade>maiorIdade){ // verificando se a idade da segunda pessoa é a maior
                maisVelho = p2.nome;
                maiorIdade = p2.idade;
            }
            break;

        case 3:
            Pessoa p3 = new Pessoa(nome, idade); // instanciando a terceira pessoa e recebendo seus dados
            if(p3.idade>maiorIdade){ // verificando se a idade da terceira pessoa é a maior
                maisVelho = p3.nome;
                maiorIdade = p3.idade;
            }
            break;

        default:
            break;
    }
}

Console.WriteLine($"\nMais velho: {maisVelho}, com {maiorIdade} anos\n");

