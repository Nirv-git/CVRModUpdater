﻿using System;

namespace CVRModUpdater.Utils
{
    public static class StringUtils
    {
        public static string AsHexString(this IntPtr ptr) =>
            string.Format("{0:X}", ptr.ToInt64());
    }
}
