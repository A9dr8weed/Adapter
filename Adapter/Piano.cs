using System;

namespace Adapter
{
    /// <summary>
    /// 'Adaptee'
    /// This is a class which has the functionality required by the client.
    /// However, its interface is not compatible with the client.
    /// </summary>
    public class Piano : IPiano
    {
        public void PlayThePiano()
        {
            Console.WriteLine("Now I need to play the piano.");
        }
    }
}