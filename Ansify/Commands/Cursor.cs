
using Ansify.SequenceComposers;

namespace Ansify.Commands
{
    public static class Cursor
    {
        public enum TabDirection
        {
            Forward,
            Backward,
        }

        public enum MoveDirection
        {
            Up,
            Down,
            Left,
            Right,
        }

        public enum Shape
        {
            User,
            BlinkingBlock,
            SteadyBlock,
            BlinkingUnderline,
            SteadyUnderline,
            BlinkingBar,
            SteadyBar,
        }

        public static void Home() { Console.Write($"{Utilities.CSI}H"); }
        public static void Home(Composer composer) { composer.Append($"{Utilities.CSI}H", startFrom: 2, CommandType.CursorPosition); }

        public static void End() { Console.Write($"{Utilities.CSI}F"); }
        public static void End(Composer composer) { composer.Append($"{Utilities.CSI}F", startFrom: 2, CommandType.CursorPosition); }

        public static void To(int line, int column) { Console.Write($"{Utilities.CSI}{line + 1};{column + 1}H"); }
        public static void To(Composer composer, int line, int column) { composer.Append($"{Utilities.CSI}{line + 1};{column + 1}H", startFrom: 2, CommandType.CursorPosition); }

        #region TAB
        public static void TabForward(int times = 1) { Console.Write($"{Utilities.CSI}{times}I"); }
        public static void TabForward(Composer composer, int times = 1) { composer.Append($"{Utilities.CSI}{times}I", startFrom: 2, CommandType.CursorPosition); }

        public static void TabBackward(int times = 1) { Console.Write($"{Utilities.CSI}{times}Z"); }
        public static void TabBackward(Composer composer, int times = 1) { composer.Append($"{Utilities.CSI}{times}Z", startFrom: 2, CommandType.CursorPosition); }

        public static void Tab(TabDirection tabDirection, int times = 1)
        {
            switch (tabDirection)
            {
                case TabDirection.Forward: TabForward(times); break;
                case TabDirection.Backward: TabBackward(times); break;
            }
        }

        public static void Tab(Composer composer, TabDirection tabDirection, int times = 1)
        {
            switch (tabDirection)
            {
                case TabDirection.Forward: TabForward(composer, times); break;
                case TabDirection.Backward: TabBackward(composer, times); break;
            }
        }
        #endregion

        #region Move
        public static void Up(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}A"); }
        public static void Up(Composer composer, int lines = 1) { composer.Append($"{Utilities.CSI}{lines}A", startFrom: 2, CommandType.CursorPosition); }

        public static void Down(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}B"); }
        public static void Down(Composer composer, int lines = 1) { composer.Append($"{Utilities.CSI}{lines}B", startFrom: 2, CommandType.CursorPosition); }

        public static void Right(int columns = 1) { Console.Write($"{Utilities.CSI}{columns}C"); }
        public static void Right(Composer composer, int columns = 1) { composer.Append($"{Utilities.CSI}{columns}C", startFrom: 2, CommandType.CursorPosition); }

        public static void Left(int columns = 1) { Console.Write($"{Utilities.CSI}{columns}D"); }
        public static void Left(Composer composer, int columns = 1) { composer.Append($"{Utilities.CSI}{columns}D", startFrom: 2, CommandType.CursorPosition); }

        public static void Move(MoveDirection moveDirection, int times = 1)
        {
            switch (moveDirection)
            {
                case MoveDirection.Up: Up(times); break;
                case MoveDirection.Down: Down(times); break;
                case MoveDirection.Left: Left(times); break;
                case MoveDirection.Right: Right(times); break;
            }
        }

        public static void Move(Composer composer, MoveDirection moveDirection, int times = 1)
        {
            switch (moveDirection)
            {
                case MoveDirection.Up: Up(composer, times); break;
                case MoveDirection.Down: Down(composer, times); break;
                case MoveDirection.Left: Left(composer, times); break;
                case MoveDirection.Right: Right(composer, times); break;
            }
        }
        #endregion

        public static void NextLine(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}E"); }
        public static void NextLine(Composer composer, int lines = 1) { composer.Append($"{Utilities.CSI}{lines}E", startFrom: 2, CommandType.CursorPosition); }

        public static void PreviousLine(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}F"); }
        public static void PreviousLine(Composer composer, int lines = 1) { composer.Append($"{Utilities.CSI}{lines}F", startFrom: 2, CommandType.CursorPosition); }

        public static void HorizontalAbsolute(int column) { Console.Write($"{Utilities.CSI}{column + 1}G"); }
        public static void HorizontalAbsolute(Composer composer, int column) { composer.Append($"{Utilities.CSI}{column + 1}G", startFrom: 2, CommandType.CursorPosition); }

        public static void VerticalAbsolute(int line) { Console.Write($"{Utilities.CSI}{line + 1}d"); }
        public static void VerticalAbsolute(Composer composer, int line) { composer.Append($"{Utilities.CSI}{line + 1}d", startFrom: 2, CommandType.CursorPosition); }

        public static void SavePosition() { Console.Write($"{Utilities.ESC}7"); }
        public static void SavePosition(Composer composer) { composer.Append($"{Utilities.ESC}7", startFrom: 1, CommandType.CursorPosition); }

        public static void RestorePosition() { Console.Write($"{Utilities.ESC}8"); }
        public static void RestorePosition(Composer composer) { composer.Append($"{Utilities.ESC}8", startFrom: 1, CommandType.CursorPosition); }

        public static void EnableBlinking() { Console.Write($"{Utilities.CSI}?12h"); }
        public static void EnableBlinking(Composer composer) { composer.Append($"{Utilities.CSI}?12h", startFrom: 2, CommandType.CursorEffect); }

        public static void DisableBlinking() { Console.Write($"{Utilities.CSI}?12l"); }
        public static void DisableBlinking(Composer composer) { composer.Append($"{Utilities.CSI}?12l", startFrom: 2, CommandType.CursorEffect); }

        public static void Show() { Console.Write($"{Utilities.CSI}?25h"); }
        public static void Show(Composer composer) { composer.Append($"{Utilities.CSI}?25h", startFrom: 2, CommandType.CursorEffect); }

        public static void Hide() { Console.Write($"{Utilities.CSI}?25l"); }
        public static void Hide(Composer composer) { composer.Append($"{Utilities.CSI}?25l", startFrom: 2, CommandType.CursorEffect); }

        #region SHAPE
        internal static void SetUserShape() { Console.Write($"{Utilities.ESC}0SPq"); }
        internal static void SetUserShape(Composer composer) { composer.Append($"{Utilities.ESC}0SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetBlinkingBlockShape() { Console.Write($"{Utilities.ESC}1SPq"); }
        internal static void SetBlinkingBlockShape(Composer composer) { composer.Append($"{Utilities.ESC}1SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetSteadyBlockShape() { Console.Write($"{Utilities.ESC}2SPq"); }
        internal static void SetSteadyBlockShape(Composer composer) { composer.Append($"{Utilities.ESC}2SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetBlinkingUnderlineShape() { Console.Write($"{Utilities.ESC}3SPq"); }
        internal static void SetBlinkingUnderlineShape(Composer composer) { composer.Append($"{Utilities.ESC}3SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetSteadyUnderlineShape() { Console.Write($"{Utilities.ESC}4SPq"); }
        internal static void SetSteadyUnderlineShape(Composer composer) { composer.Append($"{Utilities.ESC}4SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetBlinkingBarShape() { Console.Write($"{Utilities.ESC}5SPq"); }
        internal static void SetBlinkingBarShape(Composer composer) { composer.Append($"{Utilities.ESC}5SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetSteadyBarShape() { Console.Write($"{Utilities.ESC}6SPq"); }
        internal static void SetSteadyBarShape(Composer composer) { composer.Append($"{Utilities.ESC}6SPq", startFrom: 1, CommandType.CursorShape); }

        public static void SetShape(Shape cursorShape)
        {
            switch (cursorShape)
            {
                case Shape.User: SetUserShape(); break;
                case Shape.BlinkingBlock: SetBlinkingBlockShape(); break;
                case Shape.SteadyBlock: SetSteadyBlockShape(); break;
                case Shape.BlinkingUnderline: SetBlinkingUnderlineShape(); break;
                case Shape.SteadyUnderline: SetSteadyUnderlineShape(); break;
                case Shape.BlinkingBar: SetBlinkingBarShape(); break;
                case Shape.SteadyBar: SetSteadyBarShape(); break;
            }
        }

        public static void SetShape(Composer composer, Shape cursorShape)
        {
            switch (cursorShape)
            {
                case Shape.User: SetUserShape(composer); break;
                case Shape.BlinkingBlock: SetBlinkingBlockShape(composer); break;
                case Shape.SteadyBlock: SetSteadyBlockShape(composer); break;
                case Shape.BlinkingUnderline: SetBlinkingUnderlineShape(composer); break;
                case Shape.SteadyUnderline: SetSteadyUnderlineShape(composer); break;
                case Shape.BlinkingBar: SetBlinkingBarShape(composer); break;
                case Shape.SteadyBar: SetSteadyBarShape(composer); break;
            }
        }
        #endregion
    }
}
