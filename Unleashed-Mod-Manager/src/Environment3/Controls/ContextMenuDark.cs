﻿using System.Drawing;
using System.Windows.Forms;

// Unleashed Mod Manager is licensed under the MIT License:
/*
 * MIT License

 * Copyright (c) 2020 HyperBE32
 * Copyright (c) 2017 thesupersonic16

 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:

 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.

 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace Unleash.Environment3
{
    public partial class ContextMenuDark : ContextMenuStrip
    {
        public ContextMenuDark()
        {
            InitializeComponent();
            RenderMode = ToolStripRenderMode.Professional;
            Renderer = new ToolStripProfessionalRenderer(new ColorTable());
            ForeColor = SystemColors.Control;
        }
    }

    internal class ColorTable : ProfessionalColorTable
    {
        public override Color MenuItemBorder => MenuItemSelected;
        public override Color ButtonSelectedBorder => MenuItemBorder;
        public override Color ToolStripDropDownBackground => Color.FromArgb(0x1B, 0x1B, 0x1C);
        public override Color MenuItemSelected => Color.FromArgb(0x33, 0x33, 0x34);
        public override Color ButtonCheckedHighlight => MenuItemSelected;
        public override Color ButtonPressedHighlight => MenuItemSelected;
        public override Color ButtonSelectedGradientBegin => Color.FromArgb(0x18, 0x18, 0x18);
        public override Color ButtonSelectedGradientMiddle => ButtonSelectedGradientBegin;
        public override Color ButtonSelectedGradientEnd => ButtonSelectedGradientBegin;
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(0x1B, 0x1B, 0x1C);
        public override Color MenuItemPressedGradientMiddle => MenuItemPressedGradientBegin;
        public override Color MenuItemPressedGradientEnd => MenuItemPressedGradientBegin;
        public override Color CheckBackground => Color.FromArgb(0x50, 0x50, 0x50);
        public override Color CheckPressedBackground => Color.FromArgb(0x30, 0x30, 0x30);
        public override Color CheckSelectedBackground => Color.FromArgb(0x68, 0x68, 0x68);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(0x3E, 0x3E, 0x40);
        public override Color MenuItemSelectedGradientEnd => MenuItemSelectedGradientBegin;
        public override Color ImageMarginGradientBegin => Color.FromArgb(0x1B, 0x1B, 0x1C);
        public override Color ImageMarginGradientMiddle => ImageMarginGradientBegin;
        public override Color ImageMarginGradientEnd => ImageMarginGradientBegin;
        public override Color SeparatorDark => Color.FromArgb(0x33, 0x33, 0x37);
    }
}