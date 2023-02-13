using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchmarks.SharedConfig;

Console.WriteLine("Hello, World! Welcome to Object Allocations in C Sharp");

BenchmarkRunner.Run<ClassVsStructRecordBenchmark>();

[MemoryDiagnoser]
[Config(typeof(StyleConfig))]
public class ClassVsStructRecordBenchmark
{
    private const string title = "New Blog Post";
    private const string content = "New Blog Post";

    [Params(1, 100, 1000, 10000)]
    public int MAX_CREATION { get; set; }

    [Benchmark(Baseline = true)]
    public void ClassObject()
    {
        for (int i = 0; i < MAX_CREATION; i++)
        {
            _ = new ClassBlog()
            {
                Id = 1,
                Title = title,
                Content = content,
                Category = BlogCategory.Automotive
            };
        }
    }

    [Benchmark]
    public void Struct()
    {
        for (int i = 0; i < MAX_CREATION; i++)
        {
            _ = new StructBlog()
            {
                Id = 1,
                Title = title,
                Content = content,
                Category = BlogCategory.Automotive
            };
        }
    }

    [Benchmark]
    public void Record()
    {
        for (int i = 0; i < MAX_CREATION; i++)
        {
            _ = new RecordBlog
            {
                Id = 1,
                Title = title,
                Content = content,
                Category = BlogCategory.Automotive
            };
        }
    }

    [Benchmark]
    public void BigBadStruct()
    {
        for (int i = 0; i < MAX_CREATION; i++)
        {
            _ = new BigBadStruct()
            {
                Id_A = 1,
                Title_A = title,
                Content_A = content,
                Category_A = "hello world",
                Id_B = 1,
                Title_B = title,
                Content_B = content,
                Category_B = "hello world",
                Id_C = 1,
                Title_C = title,
                Content_C = content,
                Category_C = "hello world",
                Id_D = 1,
                Title_D = title,
                Content_D = content,
                Category_D = "hello world",
            };
        }
    }
}

public class ClassBlog
{
    public int Id { get; init; }

    public string Title { get; init; }

    public string Content { get; init; }

    public BlogCategory Category { get; init; }
}

public struct StructBlog
{
    public int Id { get; init; }

    public string Title { get; init; }

    public string Content { get; init; }

    public BlogCategory Category { get; init; }
}

public struct BigByteArrayStruct
{
    public byte[] PileOfBytes;

    public BigByteArrayStruct()
    {
        PileOfBytes = new byte[40_000];

        for (int i = 0; i < PileOfBytes.Length; i++)
        {
            PileOfBytes[i] = 1;
        }
    }
}

public record RecordBlog
{
    public int Id { get; init; }

    public string Title { get; init; }

    public string Content { get; init; }

    public BlogCategory Category { get; init; }
}

public enum BlogCategory
{
    Automotive,
    Fishing,
    Reading,
    Cooking
}

public struct BigBadStruct
{
    public int Id_A { get; init; }

    public string Title_A { get; init; }

    public string Content_A { get; init; }

    public string Category_A { get; init; }

    public int Id_B { get; init; }

    public string Title_B { get; init; }

    public string Content_B { get; init; }

    public string Category_B { get; init; }

    public int Id_C { get; init; }

    public string Title_C { get; init; }

    public string Content_C { get; init; }

    public string Category_C { get; init; }

    public int Id_D { get; init; }

    public string Title_D { get; init; }

    public string Content_D { get; init; }

    public string Category_D { get; init; }


    public int Id_E { get; init; }

    public string Title_E { get; init; }

    public string Content_E { get; init; }

    public string Category_E { get; init; }

    public int Id_F { get; init; }

    public string Title_F { get; init; }

    public string Content_F { get; init; }

    public string Category_F { get; init; }

    public int Id_G { get; init; }

    public string Title_G { get; init; }

    public string Content_G { get; init; }

    public string Category_G { get; init; }

    public int Id_H { get; init; }

    public string Title_H { get; init; }

    public string Content_H { get; init; }

    public string Category_H { get; init; }


    public int Id_I { get; init; }

    public string Title_I { get; init; }

    public string Content_I { get; init; }

    public string Category_I { get; init; }

    public int Id_J { get; init; }

    public string Title_J { get; init; }

    public string Content_J { get; init; }

    public string Category_J { get; init; }

    public int Id_K { get; init; }

    public string Title_K { get; init; }

    public string Content_K { get; init; }

    public string Category_K { get; init; }


    public int Id_L { get; init; }

    public string Title_L { get; init; }

    public string Content_L { get; init; }

    public string Category_L { get; init; }

    public int Id_M { get; init; }

    public string Title_M { get; init; }

    public string Content_M { get; init; }

    public string Category_M { get; init; }

    public int Id_N { get; init; }

    public string Title_N { get; init; }

    public string Content_N { get; init; }

    public string Category_N { get; init; }

    public int Id_O { get; init; }

    public string Title_O { get; init; }

    public string Content_O { get; init; }

    public string Category_O { get; init; }


}

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

