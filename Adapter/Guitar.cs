using System;

namespace Adapter
{
    /// <summary>
    /// A guitar class that implements an interface (ITarget).
    /// </summary>
    public class Guitar : IInstrument
    {
        public void PlayTheInstrument()
        {
            Console.WriteLine("Now I play the guitar.");
        }
    }
}