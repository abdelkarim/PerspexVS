﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See license.md file in the project root for full license information.

using System;
using Microsoft.VisualStudio.Shell;

namespace PerspexVS.Controls.Internals
{
    internal static class PamlDesignerBrushes
    {
        #region Autogenerated resource keys

        // These resource keys are generated by Visual Studio Extension Color Editor, and should be replaced when new colors are added to this category.
        public static readonly Guid Category = new Guid("1fb2e5ba-ede6-4dff-9dd6-59602a4414f9");

        private static ThemeResourceKey _ButtonBackgroundColorKey;
        private static ThemeResourceKey _ButtonBackgroundBrushKey;

        public static ThemeResourceKey ButtonBackgroundColorKey
        {
            get
            {
                return _ButtonBackgroundColorKey ??
                       (_ButtonBackgroundColorKey = new ThemeResourceKey(Category, "ButtonBackground", ThemeResourceKeyType.BackgroundColor));
            }
        }

        public static ThemeResourceKey ButtonBackgroundBrushKey
        {
            get
            {
                return _ButtonBackgroundBrushKey ??
                       (_ButtonBackgroundBrushKey = new ThemeResourceKey(Category, "ButtonBackground", ThemeResourceKeyType.BackgroundBrush));
            }
        }

        private static ThemeResourceKey _ButtonForegroundColorKey;
        private static ThemeResourceKey _ButtonForegroundBrushKey;

        public static ThemeResourceKey ButtonForegroundColorKey
        {
            get
            {
                return _ButtonForegroundColorKey ??
                       (_ButtonForegroundColorKey = new ThemeResourceKey(Category, "ButtonForeground", ThemeResourceKeyType.BackgroundColor));
            }
        }

        public static ThemeResourceKey ButtonForegroundBrushKey
        {
            get
            {
                return _ButtonForegroundBrushKey ??
                       (_ButtonForegroundBrushKey = new ThemeResourceKey(Category, "ButtonForeground", ThemeResourceKeyType.BackgroundBrush));
            }
        }

        private static ThemeResourceKey _ButtonMouseOverBackgroundColorKey;
        private static ThemeResourceKey _ButtonMouseOverBackgroundBrushKey;

        public static ThemeResourceKey ButtonMouseOverBackgroundColorKey
        {
            get
            {
                return _ButtonMouseOverBackgroundColorKey ??
                       (_ButtonMouseOverBackgroundColorKey =
                           new ThemeResourceKey(Category, "ButtonMouseOverBackground", ThemeResourceKeyType.BackgroundColor));
            }
        }

        public static ThemeResourceKey ButtonMouseOverBackgroundBrushKey
        {
            get
            {
                return _ButtonMouseOverBackgroundBrushKey ??
                       (_ButtonMouseOverBackgroundBrushKey =
                           new ThemeResourceKey(Category, "ButtonMouseOverBackground", ThemeResourceKeyType.BackgroundBrush));
            }
        }

        private static ThemeResourceKey _ButtonMouseOverForegroundColorKey;
        private static ThemeResourceKey _ButtonMouseOverForegroundBrushKey;

        public static ThemeResourceKey ButtonMouseOverForegroundColorKey
        {
            get
            {
                return _ButtonMouseOverForegroundColorKey ??
                       (_ButtonMouseOverForegroundColorKey =
                           new ThemeResourceKey(Category, "ButtonMouseOverForeground", ThemeResourceKeyType.BackgroundColor));
            }
        }

        public static ThemeResourceKey ButtonMouseOverForegroundBrushKey
        {
            get
            {
                return _ButtonMouseOverForegroundBrushKey ??
                       (_ButtonMouseOverForegroundBrushKey =
                           new ThemeResourceKey(Category, "ButtonMouseOverForeground", ThemeResourceKeyType.BackgroundBrush));
            }
        }

        private static ThemeResourceKey _ButtonPressedBackgroundColorKey;
        private static ThemeResourceKey _ButtonPressedBackgroundBrushKey;

        public static ThemeResourceKey ButtonPressedBackgroundColorKey
        {
            get
            {
                return _ButtonPressedBackgroundColorKey ??
                       (_ButtonPressedBackgroundColorKey = new ThemeResourceKey(Category, "ButtonPressedBackground", ThemeResourceKeyType.BackgroundColor));
            }
        }

        public static ThemeResourceKey ButtonPressedBackgroundBrushKey
        {
            get
            {
                return _ButtonPressedBackgroundBrushKey ??
                       (_ButtonPressedBackgroundBrushKey = new ThemeResourceKey(Category, "ButtonPressedBackground", ThemeResourceKeyType.BackgroundBrush));
            }
        }

        private static ThemeResourceKey _ButtonPressedForegroundColorKey;
        private static ThemeResourceKey _ButtonPressedForegroundBrushKey;

        public static ThemeResourceKey ButtonPressedForegroundColorKey
        {
            get
            {
                return _ButtonPressedForegroundColorKey ??
                       (_ButtonPressedForegroundColorKey = new ThemeResourceKey(Category, "ButtonPressedForeground", ThemeResourceKeyType.BackgroundColor));
            }
        }

        public static ThemeResourceKey ButtonPressedForegroundBrushKey
        {
            get
            {
                return _ButtonPressedForegroundBrushKey ??
                       (_ButtonPressedForegroundBrushKey = new ThemeResourceKey(Category, "ButtonPressedForeground", ThemeResourceKeyType.BackgroundBrush));
            }
        }

        private static ThemeResourceKey _HeaderActiveColorKey;
        private static ThemeResourceKey _HeaderActiveBrushKey;

        public static ThemeResourceKey HeaderActiveColorKey
        {
            get
            {
                return _HeaderActiveColorKey ??
                       (_HeaderActiveColorKey = new ThemeResourceKey(Category, "HeaderActive", ThemeResourceKeyType.BackgroundColor));
            }
        }

        public static ThemeResourceKey HeaderActiveBrushKey
        {
            get
            {
                return _HeaderActiveBrushKey ??
                       (_HeaderActiveBrushKey = new ThemeResourceKey(Category, "HeaderActive", ThemeResourceKeyType.BackgroundBrush));
            }
        }

        private static ThemeResourceKey _HeaderActiveTextColorKey;
        private static ThemeResourceKey _HeaderActiveTextBrushKey;

        public static ThemeResourceKey HeaderActiveTextColorKey
        {
            get
            {
                return _HeaderActiveTextColorKey ??
                       (_HeaderActiveTextColorKey = new ThemeResourceKey(Category, "HeaderActiveText", ThemeResourceKeyType.BackgroundColor));
            }
        }

        public static ThemeResourceKey HeaderActiveTextBrushKey
        {
            get
            {
                return _HeaderActiveTextBrushKey ??
                       (_HeaderActiveTextBrushKey = new ThemeResourceKey(Category, "HeaderActiveText", ThemeResourceKeyType.BackgroundBrush));
            }
        }

        private static ThemeResourceKey _HeaderInactiveColorKey;
        private static ThemeResourceKey _HeaderInactiveBrushKey;

        public static ThemeResourceKey HeaderInactiveColorKey
        {
            get
            {
                return _HeaderInactiveColorKey ??
                       (_HeaderInactiveColorKey = new ThemeResourceKey(Category, "HeaderInactive", ThemeResourceKeyType.BackgroundColor));
            }
        }

        public static ThemeResourceKey HeaderInactiveBrushKey
        {
            get
            {
                return _HeaderInactiveBrushKey ??
                       (_HeaderInactiveBrushKey = new ThemeResourceKey(Category, "HeaderInactive", ThemeResourceKeyType.BackgroundBrush));
            }
        }

        private static ThemeResourceKey _HeaderInactiveTextColorKey;
        private static ThemeResourceKey _HeaderInactiveTextBrushKey;

        public static ThemeResourceKey HeaderInactiveTextColorKey
        {
            get
            {
                return _HeaderInactiveTextColorKey ??
                       (_HeaderInactiveTextColorKey = new ThemeResourceKey(Category, "HeaderInactiveText", ThemeResourceKeyType.BackgroundColor));
            }
        }

        public static ThemeResourceKey HeaderInactiveTextBrushKey
        {
            get
            {
                return _HeaderInactiveTextBrushKey ??
                       (_HeaderInactiveTextBrushKey = new ThemeResourceKey(Category, "HeaderInactiveText", ThemeResourceKeyType.BackgroundBrush));
            }
        }

        private static ThemeResourceKey _SplitterBackgroundColorKey;
        private static ThemeResourceKey _SplitterBackgroundBrushKey;

        public static ThemeResourceKey SplitterBackgroundColorKey
        {
            get
            {
                return _SplitterBackgroundColorKey ??
                       (_SplitterBackgroundColorKey = new ThemeResourceKey(Category, "SplitterBackground", ThemeResourceKeyType.BackgroundColor));
            }
        }

        public static ThemeResourceKey SplitterBackgroundBrushKey
        {
            get
            {
                return _SplitterBackgroundBrushKey ??
                       (_SplitterBackgroundBrushKey = new ThemeResourceKey(Category, "SplitterBackground", ThemeResourceKeyType.BackgroundBrush));
            }
        }

        #endregion
    }
}