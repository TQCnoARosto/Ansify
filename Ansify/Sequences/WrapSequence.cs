
namespace Ansify.Sequences
{
    public class WrapSequence(string preamble, string epilogue)
    {
        public string Preamble { get; init; } = preamble;
        public string Epilogue { get; init; } = epilogue;

        public void WrapText(string text) { Console.Write($"{Preamble}{text}{Epilogue}"); }
    }
}
