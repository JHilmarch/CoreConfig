using System;
using Microsoft.Extensions.Configuration;

namespace CoreConfig.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json");
            configurationBuilder.AddCommandLine(args);
            configurationBuilder.AddEnvironmentVariables();
            var configuration = configurationBuilder.Build();

            var backgroundColor = (ConsoleColor) short.Parse(configuration["Console:Background:Color"]);
            var foregroundColor = (ConsoleColor) short.Parse(configuration["Console:Foreground:Color"]);

            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;

            Console.WriteLine($"The foreground color is {foregroundColor}");
            Console.WriteLine($"The background color is {backgroundColor}");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press 'Enter' to exit...");
            Console.ReadLine();
        }
    }
}
