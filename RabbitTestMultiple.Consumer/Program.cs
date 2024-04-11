using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

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

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine(" [x] Received {0}", message);

    //Thread.Sleep(6000);
};

channel.BasicConsume(queue: "message_queue",
    autoAck: true,
    consumer: consumer);


while (true) { }