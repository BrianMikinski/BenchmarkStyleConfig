using BenchmarkDotNet.Running;

Console.WriteLine("Hello, World! Welcome to Object Allocations in C Sharp");

BenchmarkRunner.Run<StructVsStructVsStructBenchmark>();
