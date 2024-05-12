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
