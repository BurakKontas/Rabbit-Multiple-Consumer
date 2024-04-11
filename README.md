# RabbitMQ Saga Pattern Test

This project is created to test how .NET and RabbitMQ behave with multiple consumers and one publisher, simulating a distributed system using the saga pattern to observe potential message duplication scenarios.

## Getting Started

This project is developed using .NET 8 Preview, .NET Aspire and communicates through RabbitMQ message queue. Access to RabbitMQ is required to run the project.

### Requirements

To run this project, you'll need the following software:

- .NET 8 Preview or later versions
- Access to RabbitMQ broker
- .NET Aspire
- Visual Studio version 17.9.2 or later

### Installation

1. Clone this repository to your local machine:

  ```bash
  git clone https://github.com/BurakKontas/Rabbit-Multiple-Consumer.git
  ```
2. Open with Visual Studio.

3. Start RabbitTestMultiple.AppHost project.

## License

This project is licensed under the MIT License. For more information, see the [LICENSE](LICENSE) file.
