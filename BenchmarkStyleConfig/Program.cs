using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<BearBenchmark>();

/// <summary>
/// Benchmarking files
/// </summary>
[Config(typeof(StyleConfig))]
public class BearBenchmark
{
    [Benchmark(Baseline = true)]
    public void Hibernate() => Thread.Sleep(10);

    [Benchmark]
    public void HibernateImproved() => Thread.Sleep(5);

    [Benchmark]
    public void HibernateSuperImproved() => Thread.Sleep(2);
}


/// <summary>
/// Style config for baseline summary style
/// </summary>
public class StyleConfig : ManualConfig
{
    public StyleConfig()
    {
        SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Trend);
    }
}
