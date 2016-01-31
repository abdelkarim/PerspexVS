﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See license.md file in the project root for full license information.

namespace PerspexVS.Controls.Internals
{
    internal class BooleanBoxes
    {
        public static object True = true;
        public static object False = false;

        public static object Box(bool value)
        {
            return value ? True : False;
        }
    }
}
