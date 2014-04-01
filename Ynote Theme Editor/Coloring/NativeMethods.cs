﻿using System;
using System.Runtime.InteropServices;

namespace Cyotek.Windows.Forms
{
    // Cyotek Color Picker controls library
    // Copyright © 2013 Cyotek. All Rights Reserved.
    // http://cyotek.com/blog/tag/colorpicker

    // If you use this code in your applications, donations or attribution are welcome

    internal class NativeMethods
    {
        #region Constants

        public const int R2_NOT = 6; // Inverted drawing mode

        #endregion

        #region Constructors

        protected NativeMethods()
        {
        }

        #endregion

        #region Class Members

        [DllImport("user32.dll", EntryPoint = "GetDC", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll", EntryPoint = "LineTo", CallingConvention = CallingConvention.StdCall)]
        public static extern bool LineTo(IntPtr hdc, int x, int y);

        [DllImport("gdi32.dll", EntryPoint = "MoveToEx", CallingConvention = CallingConvention.StdCall)]
        public static extern bool MoveToEx(IntPtr hdc, int x, int y, IntPtr lpPoint);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", EntryPoint = "SetROP2", CallingConvention = CallingConvention.StdCall)]
        public static extern int SetROP2(IntPtr hdc, int fnDrawMode);

        #endregion

        // ReSharper disable InconsistentNaming

        // ReSharper restore InconsistentNaming
    }
}