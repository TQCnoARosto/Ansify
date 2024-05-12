
namespace Ansify.Sequences
{
    public class Sequence(string sequenceString)
    {
        internal string SequenceString { get; init; } = sequenceString;

        public void Use() { Console.Write(SequenceString); }
    }
}
