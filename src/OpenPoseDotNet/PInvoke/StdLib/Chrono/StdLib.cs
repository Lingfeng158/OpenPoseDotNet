﻿using System;
using System.Runtime.InteropServices;

// ReSharper disable once CheckNamespace
namespace OpenPoseDotNet
{

    internal sealed partial class NativeMethods
    {

        #region string

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void std_chrono_time_point_delete(IntPtr timePoint);

        #endregion

    }

}
