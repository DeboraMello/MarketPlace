using System;
using System.Globalization;

namespace MarketPlace
{
    public class Create
    {
        public void CreateUser()
        {
            var random = new Random();
            int randomnumber = random.Next();

            var name = GetName();
            var username = GetUsername();
            var password = GetPassword();
            var birth = GetBirthday();

            var user = new User(randomnumber, name, username, password, birth);
            Console.WriteLine();
            Console.WriteLine($"{name}, seu usuário foi criado com sucesso!");
        }

        public void CreateClient()
        {
            var delivery = GetAddress();
            var billing = GetBillingAddress(delivery);

            var user = new Client(delivery, billing);
            Console.WriteLine();
            Console.WriteLine($"Cliente criado com sucesso!");
        }

        private static string GetName()
        {
            Console.WriteLine("Digite seu nome:");
            return Console.ReadLine();
        }
        private static string GetUsername()
        {
            Console.WriteLine("Digite o usuário que deseja utilizar:");
            return Console.ReadLine();
        }
        private static string GetPassword()
        {
            Console.WriteLine("Digite sua senha:");
            return Console.ReadLine();
        }
        private static DateTime GetBirthday()
        {
            Console.WriteLine("Digite sua data de Nascimento (dd/mm/aaaa):");
            var entrada = Console.ReadLine();
            return Convert.ToDateTime(entrada, new CultureInfo("pt-BR"));
        }
        private static Address GetBillingAddress(Address deliveryAddress)
        {
            Console.WriteLine("O endereço de cobrança será o mesmo endereço de entrega?");
            Console.WriteLine("Digite S para SIM e N para NÃO");
            var choice = Console.ReadLine();

            if (choice == "S") return deliveryAddress;

            return GetAddress();
        }
        private static Address GetAddress()
        {
            Console.WriteLine("Digite seu endereço:");
            var address = Console.ReadLine();

            Console.WriteLine("Digite seu complemento:");
            var secondAddress = Console.ReadLine();

            Console.WriteLine("Digite o número:");
            var number = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o CEP do seu endereço:");
            var zip = Console.ReadLine();

            Console.WriteLine("Digite a cidade:");
            var city = Console.ReadLine();

            Console.WriteLine("Digite o estado:");
            var state = Console.ReadLine();

            Console.WriteLine("Digite o país:");
            var country = Console.ReadLine();

            return new Address()
            {
                address = address,
                secondAddress = secondAddress, 
                number = number,
                zipCode = zip,
                city = city,
                state = state, 
                country = country
            };
        }
    }
}