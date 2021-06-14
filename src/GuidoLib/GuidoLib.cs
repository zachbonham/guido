using System;

namespace GuidoLib
{
    public class Guido
    {
        public static Guid NextGuid() 
        {
            return Guid.NewGuid();
        }
    }
}
