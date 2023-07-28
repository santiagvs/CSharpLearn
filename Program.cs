﻿// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>();

void ExibirLogo()
{
  Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
  ");
  Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas as bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média uma banda");
  Console.WriteLine("Digite 0 para sair");

  Console.Write("\nDigite a sua opção: ");
  string opcaoEscolhida = Console.ReadLine()!;
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

  switch (opcaoEscolhidaNumerica)
  {
    case 1: RegistrarBanda();
      break;
    case 2: MostrarBandas();
      break;
    case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
      break;
    case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
      break;
    case 0: Console.WriteLine("Tchau tchau");
      break;
    default: Console.WriteLine("Opção inválida");
      break;
  }
}

void RegistrarBanda()
{
  Console.Clear();
  Console.WriteLine("Registro de bandas");
  Console.Write("Digite o nome da banda que deseja registrar: ");
  string nomeDaBanda = Console.ReadLine()!;
  listaDasBandas.Add(nomeDaBanda);
  Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
  Thread.Sleep(2000);
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void MostrarBandas()
{
  Console.WriteLine("Nomes das bandas registradas: ");
  foreach (string nomeDaBanda in listaDasBandas)
  {
    Console.WriteLine("- " + nomeDaBanda);
  }
}

ExibirOpcoesDoMenu();
