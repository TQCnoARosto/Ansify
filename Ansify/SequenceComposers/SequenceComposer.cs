
using Ansify.Commands;
using Ansify.Sequences;
using System.Text;

namespace Ansify.SequenceComposers
{
    public class SequenceComposer : Composer
    {
        internal StringBuilder CommandSequence { get; init; } = new();
        internal CommandType LastCommandType { get; set; } = CommandType.None;

        internal override void Append(ReadOnlySpan<char> commandText, byte startFrom, CommandType type)
        {
            CommandType lastCommandType = LastCommandType;
            Utilities.Append(CommandSequence, ref lastCommandType, commandText, startFrom, type);
            LastCommandType = lastCommandType;
        }

        public override void Append(ReadOnlySpan<char> text)
        {
            CommandType lastCommandType = LastCommandType;
            Utilities.Append(CommandSequence, ref lastCommandType, text, 0, CommandType.None);
            LastCommandType = lastCommandType;
        }

        public Sequence Compose() { return new(CommandSequence.ToString()); }
    }
}
