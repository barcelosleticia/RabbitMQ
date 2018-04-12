using System;
using System.Text;
using RabbitMQ.Client;

namespace Publisher
{
    class Program
    {
        static void Main()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "RabbitMQ",
                       durable: false,
                       exclusive: false,
                       autoDelete: false,
                       arguments: null);
                    string message = "Publisher enviou ao Consumer!";
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                            routingKey: "RabbitMQ",
                            basicProperties: null,
                            body: body);
                    Console.WriteLine("Teste rabbitMQ realizado!");
                }

                Console.ReadLine();
            }
        }
    }
}