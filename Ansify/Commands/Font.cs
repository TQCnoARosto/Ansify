
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
        internal static void Reset(Composer composer) { composer.Append($"{Utilities.CSI}0m", startFrom: 2, CommandType.FontStyle); }

        internal static void IncreasedIntensity() { Console.Write($"{Utilities.CSI}1m"); }
        internal static void IncreasedIntensity(Composer composer) { composer.Append($"{Utilities.CSI}1m", startFrom: 2, CommandType.FontStyle); }

        internal static void NormalIntensity() { Console.Write($"{Utilities.CSI}22m"); }
        internal static void NormalIntensity(Composer composer) { composer.Append($"{Utilities.CSI}22m", startFrom: 2, CommandType.FontStyle); }

        internal static void DecreasedIntensity() { Console.Write($"{Utilities.CSI}2m"); }
        internal static void DecreasedIntensity(Composer composer) { composer.Append($"{Utilities.CSI}2m", startFrom: 2, CommandType.FontStyle); }

        internal static void Italicized() { Console.Write($"{Utilities.CSI}3m"); }
        internal static void Italicized(Composer composer) { composer.Append($"{Utilities.CSI}3m", startFrom: 2, CommandType.FontStyle); }

        internal static void NotItalicized() { Console.Write($"{Utilities.CSI}23m"); }
        internal static void NotItalicized(Composer composer) { composer.Append($"{Utilities.CSI}23m", startFrom: 2, CommandType.FontStyle); }

        internal static void DoublyUnderlined() { Console.Write($"{Utilities.CSI}21m"); }
        internal static void DoublyUnderlined(Composer composer) { composer.Append($"{Utilities.CSI}21m", startFrom: 2, CommandType.FontStyle); }

        internal static void Underlined() { Console.Write($"{Utilities.CSI}4m"); }
        internal static void Underlined(Composer composer) { composer.Append($"{Utilities.CSI}4m", startFrom: 2, CommandType.FontStyle); }

        internal static void NotUnderlined() { Console.Write($"{Utilities.CSI}24m"); }
        internal static void NotUnderlined(Composer composer) { composer.Append($"{Utilities.CSI}24m", startFrom: 2, CommandType.FontStyle); }

        internal static void Blink() { Console.Write($"{Utilities.CSI}5m"); }
        internal static void Blink(Composer composer) { composer.Append($"{Utilities.CSI}5m", startFrom: 2, CommandType.FontStyle); }

        internal static void Steady() { Console.Write($"{Utilities.CSI}25m"); }
        internal static void Steady(Composer composer) { composer.Append($"{Utilities.CSI}25m", startFrom: 2, CommandType.FontStyle); }

        internal static void Positive() { Console.Write($"{Utilities.CSI}27m"); }
        internal static void Positive(Composer composer) { composer.Append($"{Utilities.CSI}27m", startFrom: 2, CommandType.FontStyle); }

        internal static void Negative() { Console.Write($"{Utilities.CSI}7m"); }
        internal static void Negative(Composer composer) { composer.Append($"{Utilities.CSI}7m", startFrom: 2, CommandType.FontStyle); }

        internal static void Visible() { Console.Write($"{Utilities.CSI}28m"); }
        internal static void Visible(Composer composer) { composer.Append($"{Utilities.CSI}28m", startFrom: 2, CommandType.FontStyle); }

        internal static void Invisible() { Console.Write($"{Utilities.CSI}8m"); }
        internal static void Invisible(Composer composer) { composer.Append($"{Utilities.CSI}8m", startFrom: 2, CommandType.FontStyle); }

        internal static void CrossedOut() { Console.Write($"{Utilities.CSI}9m"); }
        internal static void CrossedOut(Composer composer) { composer.Append($"{Utilities.CSI}9m", startFrom: 2, CommandType.FontStyle); }

        internal static void NotCrossedOut() { Console.Write($"{Utilities.CSI}29m"); }
        internal static void NotCrossedOut(Composer composer) { composer.Append($"{Utilities.CSI}29m", startFrom: 2, CommandType.FontStyle); }


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

        public static void Style(Composer composer, StyleType styleType)
        {
            switch (styleType)
            {
                case StyleType.Reset: Reset(composer); break;
                case StyleType.IncreasedIntensity: IncreasedIntensity(composer); break;
                case StyleType.NormalIntensity: NormalIntensity(composer); break;
                case StyleType.DecreasedIntensity: DecreasedIntensity(composer); break;
                case StyleType.Italicized: Italicized(composer); break;
                case StyleType.NotItalicized: NotItalicized(composer); break;
                case StyleType.DoublyUnderlined: DoublyUnderlined(composer); break;
                case StyleType.Underlined: Underlined(composer); break;
                case StyleType.NotUnderlined: NotUnderlined(composer); break;
                case StyleType.Blink: Blink(composer); break;
                case StyleType.Steady: Steady(composer); break;
                case StyleType.Positive: Positive(composer); break;
                case StyleType.Negative: Negative(composer); break;
                case StyleType.Visible: Visible(composer); break;
                case StyleType.Invisible: Invisible(composer); break;
                case StyleType.CrossedOut: CrossedOut(composer); break;
                case StyleType.NotCrossedOut: NotCrossedOut(composer); break;
            }
        }

        public static void ResetForegroundColor() { Console.Write($"{Utilities.CSI}39m"); }
        public static void ResetForegroundColor(Composer composer) { composer.Append($"{Utilities.CSI}39m", startFrom: 2, CommandType.FontColor); }

        public static void ResetBackgroundColor() { Console.Write($"{Utilities.CSI}49m"); }
        public static void ResetBackgroundColor(Composer composer) { composer.Append($"{Utilities.CSI}49m", startFrom: 2, CommandType.FontColor); }

        public static void SetForegroundColor(byte r, byte g, byte b) { Console.Write($"{Utilities.CSI}38;2;{r};{g};{b}m"); }
        public static void SetForegroundColor(Composer composer, byte r, byte g, byte b) { composer.Append($"{Utilities.CSI}38;2;{r};{g};{b}m", startFrom: 2, CommandType.FontColor); }

        public static void SetBackgroundColor(byte r, byte g, byte b) { Console.Write($"{Utilities.CSI}48;2;{r};{g};{b}m"); }
        public static void SetBackgroundColor(Composer composer, byte r, byte g, byte b) { composer.Append($"{Utilities.CSI}48;2;{r};{g};{b}m", startFrom: 2, CommandType.FontColor); }
    }
}
