using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using Benchmarks.SharedConfig;

Console.WriteLine("Hello, World! Targeting multiple runtimes!");

BenchmarkRunner.Run<MultipleRuntimesBenchmark>();

[Config(typeof(StyleConfig))]
[SimpleJob(RuntimeMoniker.Net60, baseline: true)]
[SimpleJob(RuntimeMoniker.Net70)]
public class MultipleRuntimesBenchmark
{
    [Benchmark(Baseline = true)]
    public void Hibernate() => Thread.Sleep(100);

    [Benchmark]
    public void HibernateImproved() => Thread.Sleep(10);
}