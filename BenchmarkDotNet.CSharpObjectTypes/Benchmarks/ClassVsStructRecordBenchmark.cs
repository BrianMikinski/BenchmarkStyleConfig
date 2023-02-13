using BenchmarkDotNet.Attributes;
using Benchmarks.SharedConfig;

[MemoryDiagnoser]
[Config(typeof(StyleConfig))]
public class ClassVsStructRecordBenchmark
{

    [Params(1, 100, 1000, 10000)]
    public int MAX_CREATION { get; set; }

    [Benchmark(Baseline = true)]
    public void ClassObject()
    {
        for (int i = 0; i < MAX_CREATION; i++)
        {
            _ = new ClassBlog();
        }
    }

    [Benchmark]
    public void Struct()
    {
        for (int i = 0; i < MAX_CREATION; i++)
        {
            _ = new StructBlog();
        }
    }

    [Benchmark]
    public void Record()
    {
        for (int i = 0; i < MAX_CREATION; i++)
        {
            _ = new RecordBlog();
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
