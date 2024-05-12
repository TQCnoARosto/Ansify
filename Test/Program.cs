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
            Display.SetTitle(sequenceComposer, "CIAOOO1");
            Cursor.Down(sequenceComposer);
            Cursor.Down(sequenceComposer);
            Cursor.Right(sequenceComposer);
            Cursor.Right(sequenceComposer);
            Cursor.Right(sequenceComposer);
            Cursor.Show(sequenceComposer);

            Font.Style(sequenceComposer, StyleType.Italicized);
            Font.SetForegroundColor(sequenceComposer, 255, 0, 0);
            Font.SetBackgroundColor(sequenceComposer, 0, 0, 255);

            Sequence sequence = sequenceComposer.Compose();
            sequence.Use();

            Console.Write("Cacca0");

            Console.ReadKey();
        }
    }
}
