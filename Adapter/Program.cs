namespace Adapter
{
    public static class Program
    {
        private static void Main()
        {
            // Guitarist.
            Guitarist guitarist = new Guitarist();
            // Interface object.
            IInstrument guitarInstrument = new Guitar();
            // Piano.
            Piano piano = new Piano();

            // Using the adapter.
            IInstrument pianoInstrument = new PianoToGuitarAdapter(piano);

            // Calling both objects without conflicts.
            guitarist.Play(pianoInstrument);
            guitarist.Play(guitarInstrument);
        }
    }
}