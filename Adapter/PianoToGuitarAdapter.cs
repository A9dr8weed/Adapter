using System;

namespace Adapter
{
    /// <summary>
    /// 'Adapter'
    /// This is a class which implements the ITarget interface and inherits the Adaptee class.
    /// It is responsible for communication between Client and Adaptee.
    /// </summary>
    internal class PianoToGuitarAdapter : IInstrument
    {
        /// <summary>
        /// Reference to the object.
        /// </summary>
        private readonly Piano _piano;

        /// <summary>
        /// Constructor for inicialization object.
        /// </summary>
        /// <param name="piano"> Adaptee object. </param>
        public PianoToGuitarAdapter(Piano piano)
        {
            _piano = piano ?? throw new ArgumentNullException(nameof(piano));

            Console.WriteLine("I am a Adapter.");
        }

        /// <summary>
        /// Realization of client interface.
        /// </summary>
        public void PlayTheInstrument()
        {
            _piano.PlayThePiano();
        }
    }
}