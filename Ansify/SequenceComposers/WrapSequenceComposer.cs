
using Ansify.Commands;
using Ansify.Sequences;
using System.Text;

namespace Ansify.SequenceComposers
{
    public enum WrapSequenceComposerMode
    {
        Preamble,
        Epilogue
    }

    public class WrapSequenceComposer
    {
        internal StringBuilder Preamble { get; init; } = new();
        internal StringBuilder Epilogue { get; init; } = new();

        internal CommandType LastPreambleCommandType { get; set; } = CommandType.None;
        internal CommandType LastEpilogueCommandType { get; set; } = CommandType.None;

        public WrapSequenceComposerMode WrapSequenceComposerMode { get; set; } = WrapSequenceComposerMode.Preamble;

        internal void Append(ReadOnlySpan<char> commandText, byte startFrom, CommandType type)
        {
            CommandType lastCommandType;

            switch (WrapSequenceComposerMode)
            {
                case WrapSequenceComposerMode.Preamble:
                    lastCommandType = LastPreambleCommandType;
                    Utilities.Append(Preamble, ref lastCommandType, commandText, startFrom, type);
                    LastPreambleCommandType = lastCommandType;
                    break;
                case WrapSequenceComposerMode.Epilogue:
                    lastCommandType = LastEpilogueCommandType;
                    Utilities.Append(Epilogue, ref lastCommandType, commandText, startFrom, type);
                    LastEpilogueCommandType = lastCommandType;
                    break;
            }
        }

        public void Append(ReadOnlySpan<char> text)
        {
            CommandType lastCommandType;

            switch (WrapSequenceComposerMode)
            {
                case WrapSequenceComposerMode.Preamble:
                    lastCommandType = LastPreambleCommandType;
                    Utilities.Append(Preamble, ref lastCommandType, text, 0, CommandType.None);
                    LastPreambleCommandType = lastCommandType;
                    break;
                case WrapSequenceComposerMode.Epilogue:
                    lastCommandType = LastEpilogueCommandType;
                    Utilities.Append(Epilogue, ref lastCommandType, text, 0, CommandType.None);
                    LastEpilogueCommandType = lastCommandType;
                    break;
            }
        }

        public WrapSequence Compose() { return new(Preamble.ToString(), Epilogue.ToString()); }
    }
}
