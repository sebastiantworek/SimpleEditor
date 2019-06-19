using System;

namespace Utils
{
    public static class RandomUtils
    {
        private static readonly Random _random = new Random();

        public static ulong GenerateID()
        {
            byte[] buf = new byte[8];
            _random.NextBytes(buf);
            return (ulong)BitConverter.ToInt64(buf, 0);
        }
    }
}
