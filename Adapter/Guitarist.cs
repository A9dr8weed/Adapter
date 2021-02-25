namespace Adapter
{
    public class Guitarist
    {
        public void Play(IInstrument instrument)
        {
            instrument.PlayTheInstrument();
        }
    }
}