using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace Benchmarks.SharedConfig;

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