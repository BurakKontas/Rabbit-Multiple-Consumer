using System.Text;
using RabbitMQ.Client;

const string connectionString = "amqps://ttntprdm:ACv9GGKys1PH0EXUobGiwnEUxAxJy8TW@chimpanzee.rmq.cloudamqp.com/ttntprdm";

var factory = new ConnectionFactory
{
    Uri = new Uri(connectionString)
};

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "message_queue",
    durable: false,
    exclusive: false,
    autoDelete: false,
    arguments: null);

while (true)
{
    var message = "Hello RabbitMQ! " + Guid.NewGuid();
    var body = Encoding.UTF8.GetBytes(message);

    channel.BasicPublish(exchange: "",
        routingKey: "message_queue",
        basicProperties: null,
        body: body);
    Console.WriteLine(" [x] Sent {0}", message);

    Thread.Sleep(2000);
}