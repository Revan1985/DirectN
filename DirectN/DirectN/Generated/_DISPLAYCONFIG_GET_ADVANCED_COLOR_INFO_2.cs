﻿// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
        public _DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2__union_0 __union_1;
        public _DISPLAYCONFIG_COLOR_ENCODING colorEncoding;
        public uint bitsPerColorChannel;
        public _DISPLAYCONFIG_ADVANCED_COLOR_MODE activeColorMode;
    }
}
