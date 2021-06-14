namespace GuidoLib
{
    using System;

    public class Guido
    {
        public static Guid NextGuid()
        {
            return Guid.NewGuid();
        }
    }
}
