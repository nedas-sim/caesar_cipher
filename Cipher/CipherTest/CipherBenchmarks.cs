using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Cipher;

namespace CipherTest
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class CipherBenchmarks
    {
        private string TestString = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
        private int ShiftValue = -3;

        [Benchmark] public string WithStringBuilder() => Ciphers.WithStringBuilder(TestString, ShiftValue);
        [Benchmark] public string AppendToString() => Ciphers.AppendToString(TestString, ShiftValue);
        [Benchmark] public string AppendToEmptyString() => Ciphers.AppendToEmptyString(TestString, ShiftValue);
        [Benchmark] public string WithLinq() => Ciphers.WithLinq(TestString, ShiftValue);
        [Benchmark] public string WithLinqStringConstructor() => Ciphers.WithLinqStringConstructor(TestString, ShiftValue);
        [Benchmark] public string StringBuilderLinqToArray() => Ciphers.StringBuilderLinqToArray(TestString, ShiftValue);
    }
}
