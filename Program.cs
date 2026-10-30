// // 2
// Console.WriteLine("Tempo em minutos:");
// int minutos = int.Parse(Console.ReadLine());
// int horas = 0;

// while (minutos > 60) {
//     minutos = minutos - 60;
//     horas = horas + 1;
// }

// Console.WriteLine($"{horas} Horas e {minutos} minutos");


// // 3
// Console.WriteLine("Digite 3 notas:");
// double[] notas = new double[3];
// double media = 0;

// for (int i = 0; i < 3; i++) {
//     notas[i] = double.Parse(Console.ReadLine());
//     media = media + notas[i];
// }

// media = (media / 3);

// if(media >= 7) {
// Console.WriteLine($"Média {media}, aprovado");
// } else if (media >= 5 && media < 7) {
//     Console.WriteLine($"Média {media}, em recuperação");
// } else {
//     Console.WriteLine($"Média {media}, reprovado");
// }


// // 4
// Console.WriteLine("Digite um número:");
// int numero = int.Parse(Console.ReadLine());

// if(numero % 2 == 0) {
//     Console.WriteLine("Par");
// } else {
//     Console.WriteLine("Ímpar");
// }


// // 5
// Console.WriteLine("Digite as horas:");
// int horas = int.Parse(Console.ReadLine());

// int total = 8 + ((horas - 1) * 5);
// if (horas <= 0) {
//     Console.WriteLine("Número Inválido");
// } else {
//     Console.WriteLine($"Total: {total}");
// }


// // 6
// int[] numeros = new int[3];

// Console.WriteLine("Digite 3 números");
// for(int i = 0; i < 3; i++) {
//     numeros[i] = int.Parse(Console.ReadLine());
// }

// int maior = 0;
// for(int i = 0; i < 3; i++) {
//     if(maior < numeros[i]) {
//         maior = numeros[i];
//     } else {
//         continue;
//     }
// }

// Console.WriteLine($"Maior número: {maior}");


// 10
// string senha = "1234";
// string input = "";

// for(int i = 0; i < 3; i++) {
//     Console.WriteLine("Digite a senha");
//     input = Console.ReadLine();
//     if(input == senha) {
//         Console.WriteLine("Acesso Permitido");
//         break;
//     } else {
//         Console.WriteLine("Acesso Bloqueado");
//     }
// }


// // 11
// Console.WriteLine("Escreva um número");
// int numero = int.Parse(Console.ReadLine());

// if(numero % 2 == 0 || numero % 3 == 0 || numero % 5 == 0 || numero % 7 == 0 || numero <= 1) {
//     Console.WriteLine($"{numero} não é primo");
// } else {
//     Console.WriteLine($"{numero} é primo");
// }


// 12
double[] notas = [100, 50, 20, 10, 5, 2];

Console.WriteLine("Informe o preço");
double preco = double.Parse(Console.ReadLine());

while(preco >= 2) {
    for(int i = 0; i < 6; i++) {
        while(preco >= notas[i]) {
            preco = preco - notas[i];
            Console.Write($"{notas[i]} ");
        }
    }

    Console.WriteLine("\n");
}

if(preco < 2 && preco != 0) {
    Console.WriteLine("Impossível formar o valor exato");
} else {
    Console.WriteLine("Valor Definido");
}