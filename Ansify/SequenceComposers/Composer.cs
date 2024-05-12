
using Ansify.Commands;

namespace Ansify.SequenceComposers
{
    public abstract class Composer
    {
        internal abstract void Append(ReadOnlySpan<char> commandText, byte startFrom, CommandType type);
        public abstract void Append(ReadOnlySpan<char> text);
    }
}
