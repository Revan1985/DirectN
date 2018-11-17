﻿using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;

namespace DirectN
{
    [Guid("41343a53-e41a-49a2-91cd-21793bbb62e5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1BitmapBrush1 : ID2D1BitmapBrush
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1Brush
        [PreserveSig]
        new void SetOpacity(float opacity);

        [PreserveSig]
        new void SetTransform(ref D2D1_MATRIX_3X2_F transform);

        [PreserveSig]
        new float GetOpacity();

        [PreserveSig]
        new void GetTransform(ref D2D1_MATRIX_3X2_F transform);

        // ID2D1BitmapBrush
        [PreserveSig]
        new void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);

        [PreserveSig]
        new void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);

        [PreserveSig]
        new void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);

        [PreserveSig]
        new void SetBitmap(ID2D1Bitmap bitmap);

        [PreserveSig]
        new D2D1_EXTEND_MODE GetExtendModeX();

        [PreserveSig]
        new D2D1_EXTEND_MODE GetExtendModeY();

        [PreserveSig]
        new D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode();

        [PreserveSig]
        new void GetBitmap(out ID2D1Bitmap bitmap);

        // ID2D1BitmapBrush1
        [PreserveSig]
        void SetInterpolationMode1(D2D1_INTERPOLATION_MODE interpolationMode);

        [PreserveSig]
        D2D1_INTERPOLATION_MODE GetInterpolationMode1();
    }
}