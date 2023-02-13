using BenchmarkDotNet.Attributes;
using Benchmarks.SharedConfig;

[MemoryDiagnoser]
[Config(typeof(StyleConfig))]
public class StructVsStructVsStructBenchmark
{
    [Params(1, 100, 1000, 10000)]
    public int MAX_CREATION { get; set; }

    [Benchmark]
    public void Struct()
    {
        for (int i = 0; i < MAX_CREATION; i++)
        {
            _ = new StructBlog();
        }
    }

    [Benchmark]
    public void StructByteArray()
    {
        for (int i = 0; i < MAX_CREATION; i++)
        {
            _ = new BigByteArrayStruct();
        }
    }

    [Benchmark]
    public void BigBadStruct()
    {
        for (int i = 0; i < MAX_CREATION; i++)
        {
            _ = new BigBadStruct();
        }
    }
}
