
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
        public static void SetTitle(Composer composer, string title) { composer.Append($"{Utilities.OSC}0;{title}\x07", startFrom: 2, CommandType.DisplayParameter); }

        public static void DoubleHeightLineTop() { Console.Write($"{Utilities.ESC}#3"); }
        public static void DoubleHeightLineTop(Composer composer) { composer.Append($"{Utilities.ESC}#3", startFrom: 1, CommandType.DisplayEffect); }

        public static void DoubleHeightLineBottom() { Console.Write($"{Utilities.ESC}#4"); }
        public static void DoubleHeightLineBottom(Composer composer) { composer.Append($"{Utilities.ESC}#4", startFrom: 1, CommandType.DisplayEffect); }

        public static void DoubleWidthLine() { Console.Write($"{Utilities.ESC}#6"); }
        public static void DoubleWidthLine(Composer composer) { composer.Append($"{Utilities.ESC}#6", startFrom: 1, CommandType.DisplayEffect); }

        public static void Reset() { Console.Write($"{Utilities.ESC}c"); }
        public static void Reset(Composer composer) { composer.Append($"{Utilities.ESC}c", startFrom: 1, CommandType.DisplayBufferModify); }

        public static void ScrollUp(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}T"); }
        public static void ScrollUp(Composer composer, int lines = 1) { composer.Append($"{Utilities.CSI}{lines}T", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void ScrollDown(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}S"); }
        public static void ScrollDown(Composer composer, int lines = 1) { composer.Append($"{Utilities.CSI}{lines}S", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void DeleteChars(int chars = 1) { Console.Write($"{Utilities.CSI}{chars}P"); }
        public static void DeleteChars(Composer composer, int chars = 1) { composer.Append($"{Utilities.CSI}{chars}P", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void EraseChars(int chars = 1) { Console.Write($"{Utilities.CSI}{chars}X"); }
        public static void EraseChars(Composer composer, int chars = 1) { composer.Append($"{Utilities.CSI}{chars}X", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void InsertLines(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}L"); }
        public static void InsertLines(Composer composer, int lines = 1) { composer.Append($"{Utilities.CSI}{lines}L", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void DeleteLines(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}M"); }
        public static void DeleteLines(Composer composer, int lines = 1) { composer.Append($"{Utilities.CSI}{lines}M", startFrom: 2, CommandType.DisplayBufferModify); }

        #region SCREEN
        internal static void EraseScreenBelowCursor() { Console.Write($"{Utilities.CSI}0J"); }
        internal static void EraseScreenBelowCursor(Composer composer) { composer.Append($"{Utilities.CSI}0J", startFrom: 2, CommandType.DisplayBufferModify); }

        internal static void EraseScreenAboveCursor() { Console.Write($"{Utilities.CSI}1J"); }
        internal static void EraseScreenAboveCursor(Composer composer) { composer.Append($"{Utilities.CSI}1J", startFrom: 2, CommandType.DisplayBufferModify); }

        internal static void EraseEntireScreen() { Console.Write($"{Utilities.CSI}2J"); }
        internal static void EraseEntireScreen(Composer composer) { composer.Append($"{Utilities.CSI}2J", startFrom: 2, CommandType.DisplayBufferModify); }


        public static void EraseDisplay(EraseScreenMode eraseScreenMode)
        {
            switch (eraseScreenMode)
            {
                case EraseScreenMode.AboveCursor: EraseScreenAboveCursor(); break;
                case EraseScreenMode.BelowCursor: EraseScreenBelowCursor(); break;
                case EraseScreenMode.Entire: EraseEntireScreen(); break;
            }
        }

        public static void EraseDisplay(Composer composer, EraseScreenMode eraseScreenMode)
        {
            switch (eraseScreenMode)
            {
                case EraseScreenMode.AboveCursor: EraseScreenAboveCursor(composer); break;
                case EraseScreenMode.BelowCursor: EraseScreenBelowCursor(composer); break;
                case EraseScreenMode.Entire: EraseEntireScreen(composer); break;
            }
        }
        #endregion

        #region LINE
        internal static void EraseLineRightOfCursor() { Console.Write($"{Utilities.CSI}0K"); }
        internal static void EraseLineRightOfCursor(Composer composer) { composer.Append($"{Utilities.CSI}0K", startFrom: 2, CommandType.DisplayBufferModify); }

        internal static void EraseLineLeftOfCursor() { Console.Write($"{Utilities.CSI}1K"); }
        internal static void EraseLineLeftOfCursor(Composer composer) { composer.Append($"{Utilities.CSI}1K", startFrom: 2, CommandType.DisplayBufferModify); }

        internal static void EraseEntireLine() { Console.Write($"{Utilities.CSI}2K"); }
        internal static void EraseEntireLine(Composer composer) { composer.Append($"{Utilities.CSI}2K", startFrom: 2, CommandType.DisplayBufferModify); }

        public static void EraseLine(EraseLineMode eraseLineMode)
        {
            switch (eraseLineMode)
            {
                case EraseLineMode.LeftOfCursor: EraseLineLeftOfCursor(); break;
                case EraseLineMode.RightOfCursor: EraseLineRightOfCursor(); break;
                case EraseLineMode.Entire: EraseEntireLine(); break;
            }
        }

        public static void EraseLine(Composer composer, EraseLineMode eraseLineMode)
        {
            switch (eraseLineMode)
            {
                case EraseLineMode.LeftOfCursor: EraseLineLeftOfCursor(composer); break;
                case EraseLineMode.RightOfCursor: EraseLineRightOfCursor(composer); break;
                case EraseLineMode.Entire: EraseEntireLine(composer); break;
            }
        }
        #endregion

        public static void UseTempBuffer() { Console.Write($"{Utilities.CSI}?1049h"); }
        public static void UseTempBuffer(Composer composer) { composer.Append($"{Utilities.CSI}?1049h", startFrom: 2, CommandType.DisplayBufferChange); }

        public static void UsePrimaryBuffer() { Console.Write($"{Utilities.CSI}?1049l"); }
        public static void UsePrimaryBuffer(Composer composer) { composer.Append($"{Utilities.CSI}?1049l", startFrom: 2, CommandType.DisplayBufferChange); }

    }
}
