
using Ansify.SequenceComposers;

namespace Ansify.Commands
{
    public enum EraseScreenMode
    {
        AboveCursor,
        BelowCursor,
        Entire
    }

    public enum EraseLineMode
    {
        LeftOfCursor,
        RightOfCursor,
        Entire
    }

    public static class Display
    {
        public static void SetTitle(string title) { Console.Write($"{Utilities.OSC}0;{title}\x07"); }
        public static void SetTitle(StreamWriter writer, string title) { writer.Write($"{Utilities.OSC}0;{title}\x07"); }
        public static void SetTitle(SequenceComposer sequenceComposer, string title) { sequenceComposer.Append($"{Utilities.OSC}0;{title}\x07", startFrom: 2, CommandType.DisplayParameter); }

        public static void DoubleHeightLineTop() { Console.Write($"{Utilities.ESC}#3"); }
        public static void DoubleHeightLineTop(StreamWriter writer) { writer.Write($"{Utilities.ESC}#3"); }
        public static void DoubleHeightLineTop(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}#3", startFrom: 1, CommandType.DisplayEffect); }

        public static void DoubleHeightLineBottom() { Console.Write($"{Utilities.ESC}#4"); }
        public static void DoubleHeightLineBottom(StreamWriter writer) { writer.Write($"{Utilities.ESC}#4"); }
        public static void DoubleHeightLineBottom(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}#4", startFrom: 1, CommandType.DisplayEffect); }

        public static void DoubleWidthLine() { Console.Write($"{Utilities.ESC}#6"); }
        public static void DoubleWidthLine(StreamWriter writer) { writer.Write($"{Utilities.ESC}#6"); }
        public static void DoubleWidthLine(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}#6", startFrom: 1, CommandType.DisplayEffect); }

        public static void Reset() { Console.Write($"{Utilities.ESC}c"); }
        public static void Reset(StreamWriter writer) { writer.Write($"{Utilities.ESC}c"); }
        public static void Reset(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}c", startFrom: 1, CommandType.DisplayBufferModify); }

        public static void ScrollUp(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}T"); }
        public static void ScrollUp(StreamWriter writer, int lines = 1) { writer.Write($"{Utilities.CSI}{lines}T"); }
        public static void ScrollUp(SequenceComposer sequenceComposer, int lines = 1) { sequenceComposer.Append($"{Utilities.CSI}{lines}T", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void ScrollDown(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}S"); }
        public static void ScrollDown(StreamWriter writer, int lines = 1) { writer.Write($"{Utilities.CSI}{lines}S"); }
        public static void ScrollDown(SequenceComposer sequenceComposer, int lines = 1) { sequenceComposer.Append($"{Utilities.CSI}{lines}S", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void DeleteChars(int chars = 1) { Console.Write($"{Utilities.CSI}{chars}P"); }
        public static void DeleteChars(StreamWriter writer, int chars = 1) { writer.Write($"{Utilities.CSI}{chars}P"); }
        public static void DeleteChars(SequenceComposer sequenceComposer, int chars = 1) { sequenceComposer.Append($"{Utilities.CSI}{chars}P", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void EraseChars(int chars = 1) { Console.Write($"{Utilities.CSI}{chars}X"); }
        public static void EraseChars(StreamWriter writer, int chars = 1) { writer.Write($"{Utilities.CSI}{chars}X"); }
        public static void EraseChars(SequenceComposer sequenceComposer, int chars = 1) { sequenceComposer.Append($"{Utilities.CSI}{chars}X", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void InsertLines(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}L"); }
        public static void InsertLines(StreamWriter writer, int lines = 1) { writer.Write($"{Utilities.CSI}{lines}L"); }
        public static void InsertLines(SequenceComposer sequenceComposer, int lines = 1) { sequenceComposer.Append($"{Utilities.CSI}{lines}L", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void DeleteLines(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}M"); }
        public static void DeleteLines(StreamWriter writer, int lines = 1) { writer.Write($"{Utilities.CSI}{lines}M"); }
        public static void DeleteLines(SequenceComposer sequenceComposer, int lines = 1) { sequenceComposer.Append($"{Utilities.CSI}{lines}M", startFrom: 2, CommandType.DisplayBufferModify); }

        #region SCREEN
        internal static void EraseScreenBelowCursor() { Console.Write($"{Utilities.CSI}0J"); }
        internal static void EraseScreenBelowCursor(StreamWriter writer) { writer.Write($"{Utilities.CSI}0J"); }
        internal static void EraseScreenBelowCursor(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}0J", startFrom: 2, CommandType.DisplayBufferModify); }

        internal static void EraseScreenAboveCursor() { Console.Write($"{Utilities.CSI}1J"); }
        internal static void EraseScreenAboveCursor(StreamWriter writer) { writer.Write($"{Utilities.CSI}1J"); }
        internal static void EraseScreenAboveCursor(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}1J", startFrom: 2, CommandType.DisplayBufferModify); }

        internal static void EraseEntireScreen() { Console.Write($"{Utilities.CSI}2J"); }
        internal static void EraseEntireScreen(StreamWriter writer) { writer.Write($"{Utilities.CSI}2J"); }
        internal static void EraseEntireScreen(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}2J", startFrom: 2, CommandType.DisplayBufferModify); }


        public static void EraseDisplay(EraseScreenMode eraseScreenMode)
        {
            switch (eraseScreenMode)
            {
                case EraseScreenMode.AboveCursor: EraseScreenAboveCursor(); break;
                case EraseScreenMode.BelowCursor: EraseScreenBelowCursor(); break;
                case EraseScreenMode.Entire: EraseEntireScreen(); break;
            }
        }

        public static void EraseDisplay(StreamWriter writer, EraseScreenMode eraseScreenMode)
        {
            switch (eraseScreenMode)
            {
                case EraseScreenMode.AboveCursor: EraseScreenAboveCursor(writer); break;
                case EraseScreenMode.BelowCursor: EraseScreenBelowCursor(writer); break;
                case EraseScreenMode.Entire: EraseEntireScreen(writer); break;
            }
        }

        public static void EraseDisplay(SequenceComposer sequenceComposer, EraseScreenMode eraseScreenMode)
        {
            switch (eraseScreenMode)
            {
                case EraseScreenMode.AboveCursor: EraseScreenAboveCursor(sequenceComposer); break;
                case EraseScreenMode.BelowCursor: EraseScreenBelowCursor(sequenceComposer); break;
                case EraseScreenMode.Entire: EraseEntireScreen(sequenceComposer); break;
            }
        }
        #endregion

        #region LINE
        internal static void EraseLineRightOfCursor() { Console.Write($"{Utilities.CSI}0K"); }
        internal static void EraseLineRightOfCursor(StreamWriter writer) { writer.Write($"{Utilities.CSI}0K"); }
        internal static void EraseLineRightOfCursor(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}0K", startFrom: 2, CommandType.DisplayBufferModify); }

        internal static void EraseLineLeftOfCursor() { Console.Write($"{Utilities.CSI}1K"); }
        internal static void EraseLineLeftOfCursor(StreamWriter writer) { writer.Write($"{Utilities.CSI}1K"); }
        internal static void EraseLineLeftOfCursor(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}1K", startFrom: 2, CommandType.DisplayBufferModify); }

        internal static void EraseEntireLine() { Console.Write($"{Utilities.CSI}2K"); }
        internal static void EraseEntireLine(StreamWriter writer) { writer.Write($"{Utilities.CSI}2K"); }
        internal static void EraseEntireLine(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}2K", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void EraseLine(EraseLineMode eraseLineMode)
        {
            switch (eraseLineMode)
            {
                case EraseLineMode.LeftOfCursor: EraseLineLeftOfCursor(); break;
                case EraseLineMode.RightOfCursor: EraseLineRightOfCursor(); break;
                case EraseLineMode.Entire: EraseEntireLine(); break;
            }
        }

        public static void EraseLine(StreamWriter writer, EraseLineMode eraseLineMode)
        {
            switch (eraseLineMode)
            {
                case EraseLineMode.LeftOfCursor: EraseLineLeftOfCursor(writer); break;
                case EraseLineMode.RightOfCursor: EraseLineRightOfCursor(writer); break;
                case EraseLineMode.Entire: EraseEntireLine(writer); break;
            }
        }

        public static void EraseLine(SequenceComposer sequenceComposer, EraseLineMode eraseLineMode)
        {
            switch (eraseLineMode)
            {
                case EraseLineMode.LeftOfCursor: EraseLineLeftOfCursor(sequenceComposer); break;
                case EraseLineMode.RightOfCursor: EraseLineRightOfCursor(sequenceComposer); break;
                case EraseLineMode.Entire: EraseEntireLine(sequenceComposer); break;
            }
        }
        #endregion

        public static void UseTempBuffer() { Console.Write($"{Utilities.CSI}?1049h"); }
        public static void UseTempBuffer(StreamWriter writer) { writer.Write($"{Utilities.CSI}?1049h"); }
        public static void UseTempBuffer(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}?1049h", startFrom: 2, CommandType.DisplayBufferChange); }

        public static void UsePrimaryBuffer() { Console.Write($"{Utilities.CSI}?1049l"); }
        public static void UsePrimaryBuffer(StreamWriter writer) { writer.Write($"{Utilities.CSI}?1049l"); }
        public static void UsePrimaryBuffer(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}?1049l", startFrom: 2, CommandType.DisplayBufferChange); }

    }
}
