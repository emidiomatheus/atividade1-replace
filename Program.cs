using System;

public class Program
{
    public static void Main()
    {
        List<User> users = new List<User>();

        var endProgram = false;
        while (!endProgram)
        {
            Console.WriteLine("\n====================================\n");
            Console.WriteLine("CADASTRO DE USUÁRIOS \n");
            Console.WriteLine("Menu principal");
            Console.WriteLine("[1] Cadastrar novo usuário\n[2] Listar usuários\n[3] Encerrar programa\n");
            string option;

            Console.Write("Escolha uma opção: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("\n=======================================");
                Console.WriteLine("\nCADASTRO DE USUÁRIOS \n");
                Console.WriteLine("[1] Não digite nada e pressione enter para voltar ao menu principal\n");

                Console.Write("Digite o nome: ");
                var name = Console.ReadLine();

                while (name == "")
                {
                    Console.Write("Nome (Não pode ser vazio): ");
                    name = Console.ReadLine();
                }

                Console.Write("Digite o e-mail: ");
                var email = Console.ReadLine();

                while (email == "")
                {
                    Console.Write("Email (Não pode ser vazio): ");
                    email = Console.ReadLine();
                }

                Console.Write("Digite o telefone: ");
                var phoneNumber = Console.ReadLine();

                long number1 = 0;
                while (!Int64.TryParse(phoneNumber, out number1))
                {
                    Console.Write("Telefone (Digite apenas números): ");
                    phoneNumber = Console.ReadLine();
                }

                Console.Write("Digite a idade: ");
                var age = Console.ReadLine();
                int number2 = 0;
                while (!Int32.TryParse(age, out number2))
                {
                    Console.Write("Idade (Digite apenas números): ");
                    age = Console.ReadLine();
                }

                var user = new User(name, email, phoneNumber, age);

                users.Add(user);
            }

            if (option == "2")
            {
                if (users.Count > 0)
                {
                    Console.WriteLine("\n===========USUÁRIOS CADASTRADOS===========\n");
                    foreach (var user in users)
                    {
                        Console.WriteLine($"Nome: {user.Name}");
                        Console.WriteLine($"E-mail: {user.Email}");
                        Console.WriteLine($"Telefone: {user.PhoneNumber}");
                        Console.WriteLine($"Idade: {user.Age}");
                        Console.WriteLine("");

                        Thread.Sleep(1000);

                        Console.WriteLine("\n[1] Voltar ao menu principal\n");
                        Console.Write("Opção: ");
                        var option2 = Console.ReadLine();

                        if (option2 == "1")
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("Digite uma opção válida: ");
                            option2 = Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nNão há usuários cadastrados\n");
                    Thread.Sleep(1500);
                }
            }

            if (option == "3")
            {
                endProgram = false;
            }
        }
    }
}

public class User
{
    public User()
    {

    }

    public User(string name, string email, string phoneNumber, string age)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Age = age;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Age { get; set; }
}