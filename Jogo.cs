// void JogoAdivinha() {
//   int numeroAleatorio = geraNumeroAleatorio();
//   Console.WriteLine(numeroAleatorio);
//   compararNumeros(numeroAleatorio);
// }

// void compararNumeros(int numeroAleatorio)
// {
//   int chute;
//     do
//     {
//       Console.Write("Digite um número entre 1 e 100: ");
//       string inputUsuario = Console.ReadLine()!;

//       if (int.TryParse(inputUsuario, out chute))
//       {
//         switch (chute.CompareTo(numeroAleatorio))
//         {
//           case -1:
//             Console.WriteLine($"{chute} é menor.");
//             break;
//           case 0:
//             Console.WriteLine("Parabéns! Você acertou o número.");
//             break;
//           case 1:
//             Console.WriteLine($"{chute} é maior.");
//             break;
//           default:
//             Console.WriteLine("Valor inválido!");
//             break;
//         }
//       } else
//       {
//         Console.WriteLine("Entrada inválida. Digite um número inteiro válido.");
//       }
//     } while (chute != numeroAleatorio);
// }

// int geraNumeroAleatorio()
// {
//   Random aleatorio = new Random();
//   return aleatorio.Next(1, 101);
// }

// void Jogar()
// {
//   JogoAdivinha();
// }

// Jogar();
