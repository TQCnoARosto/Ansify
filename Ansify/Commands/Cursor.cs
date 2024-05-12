
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
        public static void Home(StreamWriter writer) { writer.Write($"{Utilities.CSI}H"); }
        public static void Home(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}H", startFrom: 2, CommandType.CursorPosition); }

        public static void End() { Console.Write($"{Utilities.CSI}F"); }
        public static void End(StreamWriter writer) { writer.Write($"{Utilities.CSI}F"); }
        public static void End(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}F", startFrom: 2, CommandType.CursorPosition); }

        public static void To(int line, int column) { Console.Write($"{Utilities.CSI}{line + 1};{column + 1}H"); }
        public static void To(StreamWriter writer, int line, int column) { writer.Write($"{Utilities.CSI}{line + 1};{column + 1}H"); }
        public static void To(SequenceComposer sequenceComposer, int line, int column) { sequenceComposer.Append($"{Utilities.CSI}{line + 1};{column + 1}H", startFrom: 2, CommandType.CursorPosition); }

        #region TAB
        public static void TabForward(int times = 1) { Console.Write($"{Utilities.CSI}{times}I"); }
        public static void TabForward(StreamWriter writer, int times = 1) { writer.Write($"{Utilities.CSI}{times}I"); }
        public static void TabForward(SequenceComposer sequenceComposer, int times = 1) { sequenceComposer.Append($"{Utilities.CSI}{times}I", startFrom: 2, CommandType.CursorPosition); }

        public static void TabBackward(int times = 1) { Console.Write($"{Utilities.CSI}{times}Z"); }
        public static void TabBackward(StreamWriter writer, int times = 1) { writer.Write($"{Utilities.CSI}{times}Z"); }
        public static void TabBackward(SequenceComposer sequenceComposer, int times = 1) { sequenceComposer.Append($"{Utilities.CSI}{times}Z", startFrom: 2, CommandType.CursorPosition); }

        public static void Tab(TabDirection tabDirection, int times = 1)
        {
            switch (tabDirection)
            {
                case TabDirection.Forward: TabForward(times); break;
                case TabDirection.Backward: TabBackward(times); break;
            }
        }

        public static void Tab(StreamWriter writer, TabDirection tabDirection, int times = 1)
        {
            switch (tabDirection)
            {
                case TabDirection.Forward: TabForward(writer, times); break;
                case TabDirection.Backward: TabBackward(writer, times); break;
            }
        }

        public static void Tab(SequenceComposer sequenceComposer, TabDirection tabDirection, int times = 1)
        {
            switch (tabDirection)
            {
                case TabDirection.Forward: TabForward(sequenceComposer, times); break;
                case TabDirection.Backward: TabBackward(sequenceComposer, times); break;
            }
        }
        #endregion

        #region Move
        public static void Up(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}A"); }
        public static void Up(StreamWriter writer, int lines = 1) { writer.Write($"{Utilities.CSI}{lines}A"); }
        public static void Up(SequenceComposer sequenceComposer, int lines = 1) { sequenceComposer.Append($"{Utilities.CSI}{lines}A", startFrom: 2, CommandType.CursorPosition); }

        public static void Down(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}B"); }
        public static void Down(StreamWriter writer, int lines = 1) { writer.Write($"{Utilities.CSI}{lines}B"); }
        public static void Down(SequenceComposer sequenceComposer, int lines = 1) { sequenceComposer.Append($"{Utilities.CSI}{lines}B", startFrom: 2, CommandType.CursorPosition); }

        public static void Right(int columns = 1) { Console.Write($"{Utilities.CSI}{columns}C"); }
        public static void Right(StreamWriter writer, int columns = 1) { writer.Write($"{Utilities.CSI}{columns}C"); }
        public static void Right(SequenceComposer sequenceComposer, int columns = 1) { sequenceComposer.Append($"{Utilities.CSI}{columns}C", startFrom: 2, CommandType.CursorPosition); }

        public static void Left(int columns = 1) { Console.Write($"{Utilities.CSI}{columns}D"); }
        public static void Left(StreamWriter writer, int columns = 1) { writer.Write($"{Utilities.CSI}{columns}D"); }
        public static void Left(SequenceComposer sequenceComposer, int columns = 1) { sequenceComposer.Append($"{Utilities.CSI}{columns}D", startFrom: 2, CommandType.CursorPosition); }

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

        public static void Move(StreamWriter writer, MoveDirection moveDirection, int times = 1)
        {
            switch (moveDirection)
            {
                case MoveDirection.Up: Up(writer, times); break;
                case MoveDirection.Down: Down(writer, times); break;
                case MoveDirection.Left: Left(writer, times); break;
                case MoveDirection.Right: Right(writer, times); break;
            }
        }

        public static void Move(SequenceComposer sequenceComposer, MoveDirection moveDirection, int times = 1)
        {
            switch (moveDirection)
            {
                case MoveDirection.Up: Up(sequenceComposer, times); break;
                case MoveDirection.Down: Down(sequenceComposer, times); break;
                case MoveDirection.Left: Left(sequenceComposer, times); break;
                case MoveDirection.Right: Right(sequenceComposer, times); break;
            }
        }
        #endregion

        public static void NextLine(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}E"); }
        public static void NextLine(StreamWriter writer, int lines = 1) { writer.Write($"{Utilities.CSI}{lines}E"); }
        public static void NextLine(SequenceComposer sequenceComposer, int lines = 1) { sequenceComposer.Append($"{Utilities.CSI}{lines}E", startFrom: 2, CommandType.CursorPosition); }

        public static void PreviousLine(int lines = 1) { Console.Write($"{Utilities.CSI}{lines}F"); }
        public static void PreviousLine(StreamWriter writer, int lines = 1) { writer.Write($"{Utilities.CSI}{lines}F"); }
        public static void PreviousLine(SequenceComposer sequenceComposer, int lines = 1) { sequenceComposer.Append($"{Utilities.CSI}{lines}F", startFrom: 2, CommandType.CursorPosition); }

        public static void HorizontalAbsolute(int column) { Console.Write($"{Utilities.CSI}{column + 1}G"); }
        public static void HorizontalAbsolute(StreamWriter writer, int column) { writer.Write($"{Utilities.CSI}{column + 1}G"); }
        public static void HorizontalAbsolute(SequenceComposer sequenceComposer, int column) { sequenceComposer.Append($"{Utilities.CSI}{column + 1}G", startFrom: 2, CommandType.CursorPosition); }

        public static void VerticalAbsolute(int line) { Console.Write($"{Utilities.CSI}{line + 1}d"); }
        public static void VerticalAbsolute(StreamWriter writer, int line) { writer.Write($"{Utilities.CSI}{line + 1}d"); }
        public static void VerticalAbsolute(SequenceComposer sequenceComposer, int line) { sequenceComposer.Append($"{Utilities.CSI}{line + 1}d", startFrom: 2, CommandType.CursorPosition); }

        public static void SavePosition() { Console.Write($"{Utilities.ESC}7"); }
        public static void SavePosition(StreamWriter writer) { writer.Write($"{Utilities.ESC}7"); }
        public static void SavePosition(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}7", startFrom: 1, CommandType.CursorPosition); }

        public static void RestorePosition() { Console.Write($"{Utilities.ESC}8"); }
        public static void RestorePosition(StreamWriter writer) { writer.Write($"{Utilities.ESC}8"); }
        public static void RestorePosition(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}8", startFrom: 1, CommandType.CursorPosition); }

        public static void EnableBlinking() { Console.Write($"{Utilities.CSI}?12h"); }
        public static void EnableBlinking(StreamWriter writer) { writer.Write($"{Utilities.CSI}?12h"); }
        public static void EnableBlinking(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}?12h", startFrom: 2, CommandType.CursorEffect); }

        public static void DisableBlinking() { Console.Write($"{Utilities.CSI}?12l"); }
        public static void DisableBlinking(StreamWriter writer) { writer.Write($"{Utilities.CSI}?12l"); }
        public static void DisableBlinking(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}?12l", startFrom: 2, CommandType.CursorEffect); }

        public static void Show() { Console.Write($"{Utilities.CSI}?25h"); }
        public static void Show(StreamWriter writer) { writer.Write($"{Utilities.CSI}?25h"); }
        public static void Show(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}?25h", startFrom: 2, CommandType.CursorEffect); }

        public static void Hide() { Console.Write($"{Utilities.CSI}?25l"); }
        public static void Hide(StreamWriter writer) { writer.Write($"{Utilities.CSI}?25l"); }
        public static void Hide(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}?25l", startFrom: 2, CommandType.CursorEffect); }

        #region SHAPE
        internal static void SetUserShape() { Console.Write($"{Utilities.ESC}0SPq"); }
        internal static void SetUserShape(StreamWriter writer) { writer.Write($"{Utilities.ESC}0SPq"); }
        internal static void SetUserShape(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}0SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetBlinkingBlockShape() { Console.Write($"{Utilities.ESC}1SPq"); }
        internal static void SetBlinkingBlockShape(StreamWriter writer) { writer.Write($"{Utilities.ESC}1SPq"); }
        internal static void SetBlinkingBlockShape(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}1SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetSteadyBlockShape() { Console.Write($"{Utilities.ESC}2SPq"); }
        internal static void SetSteadyBlockShape(StreamWriter writer) { writer.Write($"{Utilities.ESC}2SPq"); }
        internal static void SetSteadyBlockShape(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}2SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetBlinkingUnderlineShape() { Console.Write($"{Utilities.ESC}3SPq"); }
        internal static void SetBlinkingUnderlineShape(StreamWriter writer) { writer.Write($"{Utilities.ESC}3SPq"); }
        internal static void SetBlinkingUnderlineShape(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}3SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetSteadyUnderlineShape() { Console.Write($"{Utilities.ESC}4SPq"); }
        internal static void SetSteadyUnderlineShape(StreamWriter writer) { writer.Write($"{Utilities.ESC}4SPq"); }
        internal static void SetSteadyUnderlineShape(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}4SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetBlinkingBarShape() { Console.Write($"{Utilities.ESC}5SPq"); }
        internal static void SetBlinkingBarShape(StreamWriter writer) { writer.Write($"{Utilities.ESC}5SPq"); }
        internal static void SetBlinkingBarShape(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}5SPq", startFrom: 1, CommandType.CursorShape); }

        internal static void SetSteadyBarShape() { Console.Write($"{Utilities.ESC}6SPq"); }
        internal static void SetSteadyBarShape(StreamWriter writer) { writer.Write($"{Utilities.ESC}6SPq"); }
        internal static void SetSteadyBarShape(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.ESC}6SPq", startFrom: 1, CommandType.CursorShape); }

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

        public static void SetShape(StreamWriter writer, Shape cursorShape)
        {
            switch (cursorShape)
            {
                case Shape.User: SetUserShape(writer); break;
                case Shape.BlinkingBlock: SetBlinkingBlockShape(writer); break;
                case Shape.SteadyBlock: SetSteadyBlockShape(); break;
                case Shape.BlinkingUnderline: SetBlinkingUnderlineShape(writer); break;
                case Shape.SteadyUnderline: SetSteadyUnderlineShape(writer); break;
                case Shape.BlinkingBar: SetBlinkingBarShape(writer); break;
                case Shape.SteadyBar: SetSteadyBarShape(writer); break;
            }
        }

        public static void SetShape(SequenceComposer sequenceComposer, Shape cursorShape)
        {
            switch (cursorShape)
            {
                case Shape.User: SetUserShape(sequenceComposer); break;
                case Shape.BlinkingBlock: SetBlinkingBlockShape(sequenceComposer); break;
                case Shape.SteadyBlock: SetSteadyBlockShape(sequenceComposer); break;
                case Shape.BlinkingUnderline: SetBlinkingUnderlineShape(sequenceComposer); break;
                case Shape.SteadyUnderline: SetSteadyUnderlineShape(sequenceComposer); break;
                case Shape.BlinkingBar: SetBlinkingBarShape(sequenceComposer); break;
                case Shape.SteadyBar: SetSteadyBarShape(sequenceComposer); break;
            }
        }
        #endregion
    }
}
