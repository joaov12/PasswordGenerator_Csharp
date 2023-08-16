using System;

namespace PasswordGenerator
{
    class PasswordGenerator
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string all =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRTSUVWXYZ1234567890[]{}()*;/,._";

            do
            {
                Console.Clear();
                Console.WriteLine(
                    "Qual o tamanho da senha desejada? (Recomendamos mais que 8 caracteres)"
                );
                int length = int.Parse(Console.ReadLine());

                if (length <= 0)
                {
                    Console.WriteLine(
                        "Tamanho da senha inválido. O tamanho deve ser maior que zero."
                    );
                    return;
                }

                // Gera a senha aleatória.
                char[] password = new char[length];
                for (int i = 0; i < length; i++)
                {
                    password[i] = all[random.Next(all.Length)];
                }

                // Converte a senha em uma string e imprime no console.
                var passwordStr = new string(password);
                Console.WriteLine("Senha gerada: " + passwordStr);
                Console.WriteLine();
                Console.WriteLine(
                    "Digite ESC para sair ou qualquer outra tecla para gerar mais senhas!"
                );
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
