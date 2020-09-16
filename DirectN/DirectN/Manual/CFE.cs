﻿using System;

namespace DirectN
{
    [Flags]
    public enum CFE
    {
        CFE_BOLD = 0x00000001,
        CFE_ITALIC = 0x00000002,
        CFE_UNDERLINE = 0x00000004,
        CFE_STRIKEOUT = 0x00000008,
        CFE_PROTECTED = 0x00000010,
        CFE_LINK = 0x00000020,
        CFE_AUTOCOLOR = 0x40000000,
        CFE_SUBSCRIPT = 0x00010000,
        CFE_SUPERSCRIPT = 0x00020000,
        CFE_SMALLCAPS = CFM.CFM_SMALLCAPS,
        CFE_ALLCAPS = CFM.CFM_ALLCAPS,
        CFE_HIDDEN = CFM.CFM_HIDDEN,
        CFE_OUTLINE = CFM.CFM_OUTLINE,
        CFE_SHADOW = CFM.CFM_SHADOW,
        CFE_EMBOSS = CFM.CFM_EMBOSS,
        CFE_IMPRINT = CFM.CFM_IMPRINT,
        CFE_DISABLED = CFM.CFM_DISABLED,
        CFE_REVISED = CFM.CFM_REVISED,
        CFE_AUTOBACKCOLOR = CFM.CFM_BACKCOLOR,
        CFE_FONTBOUND = 0x00100000,
        CFE_LINKPROTECTED = 0x00800000,
        CFE_EXTENDED = 0x02000000,
        CFE_MATHNOBUILDUP = 0x08000000,
        CFE_MATH = 0x10000000,
        CFE_MATHORDINARY = 0x20000000,
    }
}