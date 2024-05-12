
using System.Text;

namespace Ansify.Commands
{
    internal static class Utilities
    {
        public const string ESC = "\x1B";
        public const string CSI = $"{ESC}[";
        public const string OSC = $"{ESC}]";

        public static void Append(StringBuilder builder, ref CommandType lastCommandType, ReadOnlySpan<char> commandText, byte startFrom, CommandType currentCommandType)
        {
            if (lastCommandType != currentCommandType)
            {
                builder.Append(commandText);
                lastCommandType = currentCommandType;
                return;
            }

            // TODO try to optimize sequence of opposite commands e.g. "left + right + up  + down" = ""

            switch (currentCommandType)
            {
                case CommandType.FontStyle:
                    builder.Append(';');
                    builder.Append(commandText[startFrom..]);
                    break;
                default: builder.Append(commandText); break;
            }
        }
    }
}
