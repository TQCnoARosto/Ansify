
using BenchmarkDotNet.Attributes;
using System.Text;

namespace Test.Benchmarks
{
    public class Formatting_Builder
    {
        private string TEMP;
        private Random Random;

        [Params(1, 100)]
        public int TIMES;

        [GlobalSetup]
        public void Setup()
        {
            Random = new(42);
        }

        [Benchmark]
        public void Formatting()
        {
            const string FORMAT = $"\x1B[38;2;{{0}};{{1}};{{1}}m";
            Span<byte> colors = stackalloc byte[3];

            for (int i = 0; i < TIMES; i++)
            {
                Random.NextBytes(colors);
                TEMP = string.Format(FORMAT, colors[0], colors[1], colors[2]);
            }
        }

        [Benchmark]
        public void Builder1()
        {
            Span<byte> colors = stackalloc byte[3];
            StringBuilder builder = new();

            for (int i = 0; i < TIMES; i++)
            {
                Random.NextBytes(colors);
                builder.Append("\x1B[38;2;");

                builder.Append(colors[0]);
                builder.Append(';');
                builder.Append(colors[1]);
                builder.Append(';');
                builder.Append(colors[2]);
                builder.Append('m');

                TEMP = builder.ToString();
                builder.Clear();
            }
        }

        [Benchmark]
        public void Builder2()
        {
            Span<byte> colors = stackalloc byte[3];
            const string str = "\x1B[38;2;;;m";
            StringBuilder builder = new(str.Length);
            builder.Append(str);

            for (int i = 0; i < TIMES; i++)
            {
                string r = colors[0].ToString();
                string g = colors[1].ToString();
                string b = colors[2].ToString();

                builder.Insert(7, r);
                builder.Insert(8 + r.Length, g);
                builder.Insert(9 + g.Length, b);

                Random.NextBytes(colors);
                TEMP = builder.ToString();

                builder.Length = str.Length;
                builder[7] = ';';
                builder[8] = ';';
                builder[9] = 'm';
            }
        }
    }
}
