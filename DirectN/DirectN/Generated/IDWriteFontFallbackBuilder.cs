﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_2.h(575,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Builder used to create a font fallback definition by appending a series of fallback mappings, followed by a creation call.  <remarks> This object may not be thread-safe. </remarks>
    /// </summary>
    [Guid("fd882d06-8aba-4fb8-b849-8be8b73e14de"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFallbackBuilder
    {
        [PreserveSig]
        HRESULT AddMapping(/* _In_reads_(rangesCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_UNICODE_RANGE[] ranges, uint rangesCount, /* _In_reads_(targetFamilyNamesCount) */ out char[] targetFamilyNames, uint targetFamilyNamesCount, /* _In_opt_ */ ref IDWriteFontCollection fontCollection, /* _In_opt_z_ */ ref char localeName, /* _In_opt_z_ */ ref char baseFamilyName, float scale);
        
        [PreserveSig]
        HRESULT AddMappings(IDWriteFontFallback fontFallback);
        
        [PreserveSig]
        HRESULT CreateFontFallback(/* _COM_Outptr_ */ out IDWriteFontFallback fontFallback);
    }
}