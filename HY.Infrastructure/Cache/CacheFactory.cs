﻿
namespace HY.Infrastructure
{
    public class CacheFactory
    {
        public static ICache Cache()
        {
            return new Cache();
        }
    }
}
