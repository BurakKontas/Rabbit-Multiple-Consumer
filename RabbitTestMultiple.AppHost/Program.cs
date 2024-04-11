var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.RabbitTestMultiple_Consumer>("consumer")
    .WithReplicas(3);

builder.AddProject<Projects.RabbitTestMultiple_Publisher>("publisher");

builder.Build().Run();
