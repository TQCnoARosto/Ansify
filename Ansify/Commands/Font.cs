
using Ansify.SequenceComposers;

namespace Ansify.Commands
{
    public enum StyleType
    {
        Reset,

        IncreasedIntensity,
        NormalIntensity,
        DecreasedIntensity,

        Italicized,
        NotItalicized,

        DoublyUnderlined,
        Underlined,
        NotUnderlined,

        Blink,
        Steady,

        Positive,
        Negative,
        
        Visible,
        Invisible,

        CrossedOut,
        NotCrossedOut
    }

    public enum Target
    {
        Foreground,
        BackGround
    }

    public static class Font
    {
        internal static void Reset() { Console.Write($"{Utilities.CSI}0m"); }
        internal static void Reset(StreamWriter writer) { writer.Write($"{Utilities.CSI}0m"); }
        internal static void Reset(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}0m", startFrom: 2, CommandType.FontStyle); }

        internal static void IncreasedIntensity() { Console.Write($"{Utilities.CSI}1m"); }
        internal static void IncreasedIntensity(StreamWriter writer) { writer.Write($"{Utilities.CSI}1m"); }
        internal static void IncreasedIntensity(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}1m", startFrom: 2, CommandType.FontStyle); }

        internal static void NormalIntensity() { Console.Write($"{Utilities.CSI}22m"); }
        internal static void NormalIntensity(StreamWriter writer) { writer.Write($"{Utilities.CSI}22m"); }
        internal static void NormalIntensity(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}22m", startFrom: 2, CommandType.FontStyle); }

        internal static void DecreasedIntensity() { Console.Write($"{Utilities.CSI}2m"); }
        internal static void DecreasedIntensity(StreamWriter writer) { writer.Write($"{Utilities.CSI}2m"); }
        internal static void DecreasedIntensity(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}2m", startFrom: 2, CommandType.FontStyle); }

        internal static void Italicized() { Console.Write($"{Utilities.CSI}3m"); }
        internal static void Italicized(StreamWriter writer) { writer.Write($"{Utilities.CSI}3m"); }
        internal static void Italicized(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}3m", startFrom: 2, CommandType.FontStyle); }

        internal static void NotItalicized() { Console.Write($"{Utilities.CSI}23m"); }
        internal static void NotItalicized(StreamWriter writer) { writer.Write($"{Utilities.CSI}23m"); }
        internal static void NotItalicized(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}23m", startFrom: 2, CommandType.FontStyle); }

        internal static void DoublyUnderlined() { Console.Write($"{Utilities.CSI}21m"); }
        internal static void DoublyUnderlined(StreamWriter writer) { writer.Write($"{Utilities.CSI}21m"); }
        internal static void DoublyUnderlined(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}21m", startFrom: 2, CommandType.FontStyle); }

        internal static void Underlined() { Console.Write($"{Utilities.CSI}4m"); }
        internal static void Underlined(StreamWriter writer) { writer.Write($"{Utilities.CSI}4m"); }
        internal static void Underlined(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}4m", startFrom: 2, CommandType.FontStyle); }

        internal static void NotUnderlined() { Console.Write($"{Utilities.CSI}24m"); }
        internal static void NotUnderlined(StreamWriter writer) { writer.Write($"{Utilities.CSI}24m"); }
        internal static void NotUnderlined(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}24m", startFrom: 2, CommandType.FontStyle); }

        internal static void Blink() { Console.Write($"{Utilities.CSI}5m"); }
        internal static void Blink(StreamWriter writer) { writer.Write($"{Utilities.CSI}5m"); }
        internal static void Blink(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}5m", startFrom: 2, CommandType.FontStyle); }

        internal static void Steady() { Console.Write($"{Utilities.CSI}25m"); }
        internal static void Steady(StreamWriter writer) { writer.Write($"{Utilities.CSI}25m"); }
        internal static void Steady(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}25m", startFrom: 2, CommandType.FontStyle); }

        internal static void Positive() { Console.Write($"{Utilities.CSI}27m"); }
        internal static void Positive(StreamWriter writer) { writer.Write($"{Utilities.CSI}27m"); }
        internal static void Positive(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}27m", startFrom: 2, CommandType.FontStyle); }

        internal static void Negative() { Console.Write($"{Utilities.CSI}7m"); }
        internal static void Negative(StreamWriter writer) { writer.Write($"{Utilities.CSI}7m"); }
        internal static void Negative(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}7m", startFrom: 2, CommandType.FontStyle); }

        internal static void Visible() { Console.Write($"{Utilities.CSI}28m"); }
        internal static void Visible(StreamWriter writer) { writer.Write($"{Utilities.CSI}28m"); }
        internal static void Visible(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}28m", startFrom: 2, CommandType.FontStyle); }

        internal static void Invisible() { Console.Write($"{Utilities.CSI}8m"); }
        internal static void Invisible(StreamWriter writer) { writer.Write($"{Utilities.CSI}8m"); }
        internal static void Invisible(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}8m", startFrom: 2, CommandType.FontStyle); }

        internal static void CrossedOut() { Console.Write($"{Utilities.CSI}9m"); }
        internal static void CrossedOut(StreamWriter writer) { writer.Write($"{Utilities.CSI}9m"); }
        internal static void CrossedOut(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}9m", startFrom: 2, CommandType.FontStyle); }

        internal static void NotCrossedOut() { Console.Write($"{Utilities.CSI}29m"); }
        internal static void NotCrossedOut(StreamWriter writer) { writer.Write($"{Utilities.CSI}29m"); }
        internal static void NotCrossedOut(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}29m", startFrom: 2, CommandType.FontStyle); }


        public static void Style(StyleType styleType)
        {
            switch (styleType)
            {
                case StyleType.Reset: Reset(); break;
                case StyleType.IncreasedIntensity: IncreasedIntensity(); break;
                case StyleType.NormalIntensity: NormalIntensity(); break;
                case StyleType.DecreasedIntensity: DecreasedIntensity(); break;
                case StyleType.Italicized: Italicized(); break;
                case StyleType.NotItalicized: NotItalicized(); break;
                case StyleType.DoublyUnderlined: DoublyUnderlined(); break;
                case StyleType.Underlined: Underlined(); break;
                case StyleType.NotUnderlined: NotUnderlined(); break;
                case StyleType.Blink: Blink(); break;
                case StyleType.Steady: Steady(); break;
                case StyleType.Positive: Positive(); break;
                case StyleType.Negative: Negative(); break;
                case StyleType.Visible: Visible(); break;
                case StyleType.Invisible: Invisible(); break;
                case StyleType.CrossedOut: CrossedOut(); break;
                case StyleType.NotCrossedOut: NotCrossedOut(); break;
            }
        }

        public static void Style(StreamWriter writer, StyleType styleType)
        {
            switch (styleType)
            {
                case StyleType.Reset: Reset(writer); break;
                case StyleType.IncreasedIntensity: IncreasedIntensity(writer); break;
                case StyleType.NormalIntensity: NormalIntensity(writer); break;
                case StyleType.DecreasedIntensity: DecreasedIntensity(writer); break;
                case StyleType.Italicized: Italicized(writer); break;
                case StyleType.NotItalicized: NotItalicized(writer); break;
                case StyleType.DoublyUnderlined: DoublyUnderlined(writer); break;
                case StyleType.Underlined: Underlined(writer); break;
                case StyleType.NotUnderlined: NotUnderlined(writer); break;
                case StyleType.Blink: Blink(writer); break;
                case StyleType.Steady: Steady(writer); break;
                case StyleType.Positive: Positive(writer); break;
                case StyleType.Negative: Negative(writer); break;
                case StyleType.Visible: Visible(writer); break;
                case StyleType.Invisible: Invisible(writer); break;
                case StyleType.CrossedOut: CrossedOut(writer); break;
                case StyleType.NotCrossedOut: NotCrossedOut(writer); break;
            }
        }

        public static void Style(SequenceComposer sequenceComposer, StyleType styleType)
        {
            switch (styleType)
            {
                case StyleType.Reset: Reset(sequenceComposer); break;
                case StyleType.IncreasedIntensity: IncreasedIntensity(sequenceComposer); break;
                case StyleType.NormalIntensity: NormalIntensity(sequenceComposer); break;
                case StyleType.DecreasedIntensity: DecreasedIntensity(sequenceComposer); break;
                case StyleType.Italicized: Italicized(sequenceComposer); break;
                case StyleType.NotItalicized: NotItalicized(sequenceComposer); break;
                case StyleType.DoublyUnderlined: DoublyUnderlined(sequenceComposer); break;
                case StyleType.Underlined: Underlined(sequenceComposer); break;
                case StyleType.NotUnderlined: NotUnderlined(sequenceComposer); break;
                case StyleType.Blink: Blink(sequenceComposer); break;
                case StyleType.Steady: Steady(sequenceComposer); break;
                case StyleType.Positive: Positive(sequenceComposer); break;
                case StyleType.Negative: Negative(sequenceComposer); break;
                case StyleType.Visible: Visible(sequenceComposer); break;
                case StyleType.Invisible: Invisible(sequenceComposer); break;
                case StyleType.CrossedOut: CrossedOut(sequenceComposer); break;
                case StyleType.NotCrossedOut: NotCrossedOut(sequenceComposer); break;
            }
        }

        public static void ResetForegroundColor() { Console.Write($"{Utilities.CSI}39m"); }
        public static void ResetForegroundColor(StreamWriter writer) { writer.Write($"{Utilities.CSI}39m"); }
        public static void ResetForegroundColor(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}39m", startFrom: 2, CommandType.FontColor); }

        public static void ResetBackgroundColor() { Console.Write($"{Utilities.CSI}49m"); }
        public static void ResetBackgroundColor(StreamWriter writer) { writer.Write($"{Utilities.CSI}49m"); }
        public static void ResetBackgroundColor(SequenceComposer sequenceComposer) { sequenceComposer.Append($"{Utilities.CSI}49m", startFrom: 2, CommandType.FontColor); }

        public static void SetForegroundColor(byte r, byte g, byte b) { Console.Write($"{Utilities.CSI}38;2;{r};{g};{b}m"); }
        public static void SetForegroundColor(StreamWriter writer, byte r, byte g, byte b) { writer.Write($"{Utilities.CSI}38;2;{r};{g};{b}m"); }
        public static void SetForegroundColor(SequenceComposer sequenceComposer, byte r, byte g, byte b) { sequenceComposer.Append($"{Utilities.CSI}38;2;{r};{g};{b}m", startFrom: 2, CommandType.FontColor); }

        public static void SetBackgroundColor(byte r, byte g, byte b) { Console.Write($"{Utilities.CSI}48;2;{r};{g};{b}m"); }
        public static void SetBackgroundColor(StreamWriter writer, byte r, byte g, byte b) { writer.Write($"{Utilities.CSI}48;2;{r};{g};{b}m"); }
        public static void SetBackgroundColor(SequenceComposer sequenceComposer, byte r, byte g, byte b) { sequenceComposer.Append($"{Utilities.CSI}48;2;{r};{g};{b}m", startFrom: 2, CommandType.FontColor); }
    }
}
