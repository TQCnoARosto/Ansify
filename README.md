Simple library containing most (not all) escape commands.

Some of the commands are used for:
* Change cursor position.
* Change cursor effect (enable/disable blinking or show/hide).
* Change cursor shape.
* Possibility to display text twice as wide or twice as tall than normal.
* Possibility to scroll/modify the console buffer.
* Possibility to swap between primary and temp buffer.
* Change the font style (e.g. Italicized, Underlined, Blink, ...).
* Change foreground/background text color.

## Examples
1. Change aplication title.
```cs
using Ansify.Commands;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display.SetTitle("HELOOO!");
        }
    }
}
```

2. Change cursor position.
```cs
using Ansify.Commands;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cursor.Down(lines: 2);
            Cursor.Right(columns: 4);

            Console.WriteLine(":)");
        }
    }
}
```

3. Change font style.
```cs
using Ansify.Commands;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Font.Style(StyleType.Italicized);
            Font.Style(StyleType.Blink);
            Font.SetForegroundColor(255, 0, 0);
            Font.SetBackgroundColor(0, 0, 255);
            Console.WriteLine(":)");
            Font.Style(StyleType.Reset);
        }
    }
}
```

4. Use commands together.
```cs
using Ansify.Commands;
using Ansify.SequenceComposers;
using Ansify.Sequences;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SequenceComposer sequenceComposer = new();

            Cursor.Hide(sequenceComposer);

            Cursor.Down(sequenceComposer, lines: 2);
            Cursor.Right(sequenceComposer, columns: 4);

            Font.Style(sequenceComposer, StyleType.Italicized);
            Font.Style(sequenceComposer, StyleType.Blink);
            Font.SetForegroundColor(sequenceComposer, 255, 0, 0);
            Font.SetBackgroundColor(sequenceComposer, 0, 0, 255);
            sequenceComposer.Append(":)");
            Font.Style(sequenceComposer, StyleType.Reset);

            Cursor.Show(sequenceComposer);

            Sequence sequence = sequenceComposer.Compose();
            sequence.Use();
            sequence.Use();
        }
    }
}
```
5. Use commands together.
```cs
using Ansify.Commands;
using Ansify.SequenceComposers;
using Ansify.Sequences;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WrapSequenceComposer wrapSequenceComposer = new();

            wrapSequenceComposer.WrapSequenceComposerMode = WrapSequenceComposerMode.Preamble;
            Cursor.Home(wrapSequenceComposer);
            wrapSequenceComposer.Append("[");
            Font.SetForegroundColor(wrapSequenceComposer, 0, 255, 255);

            wrapSequenceComposer.WrapSequenceComposerMode = WrapSequenceComposerMode.Epilogue;
            Font.ResetForegroundColor(wrapSequenceComposer);
            wrapSequenceComposer.Append("]");

            WrapSequence wrapSequence = wrapSequenceComposer.Compose();
            Cursor.Hide();

            for (int i = 0; i <= 10; i++)
            {
                string progress = $"{new('=', i)}{new(' ', 10 - i)}";
                wrapSequence.WrapText(progress);

                int time = Random.Shared.Next(200, 1000);
                Task.Delay(time).Wait();
            }
        }
    }
}
```
