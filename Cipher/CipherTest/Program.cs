using BenchmarkDotNet.Running;

namespace CipherTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // For benchmark to work, this project has to be built as Release, not Debug.
            // All cipher methods pass unit tests.
            // Doing benchmark test to find out which method is best in terms of speed and memory.
            // Benchmark results:
            /*
             
            |                    Method |       Mean |    Error |   StdDev |  Gen 0 | Allocated |
            |-------------------------- |-----------:|---------:|---------:|-------:|----------:|
            |         WithStringBuilder |   439.6 ns |  8.73 ns | 11.95 ns | 0.1106 |     349 B |
            | WithLinqStringConstructor | 1,194.0 ns |  5.86 ns |  5.19 ns | 0.1926 |     609 B |
            |  StringBuilderLinqToArray | 1,314.6 ns |  4.81 ns |  4.02 ns | 0.2460 |     777 B |
            |       AppendToEmptyString | 2,174.3 ns | 11.59 ns |  9.68 ns | 1.0185 |   3,213 B |
            |            AppendToString | 2,179.1 ns |  7.59 ns |  6.34 ns | 1.0185 |   3,213 B |
            |                  WithLinq | 2,725.3 ns | 53.03 ns | 65.13 ns | 0.5531 |   1,751 B |

            */
            // Method 'WithStringBuilder' is best by speed and memory allocation.
            // This method is therefore used in CaesarCipher object.
            BenchmarkRunner.Run<CipherBenchmarks>();
        }
    }
}
