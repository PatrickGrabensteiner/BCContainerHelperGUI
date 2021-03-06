﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCDockerHelper
{
    public delegate void ChangeCursorHandler(Cursor c);
    static class GUIHelper
    {
        public static ChangeCursorHandler ChangeCursor { get; set; }
        public static void AppendLine(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(String.Format("{0}\r\n", text));
            box.SelectionColor = box.ForeColor;
        }
        public static void AppendLine(this RichTextBox box, string text)
        {
            box.AppendLine(text, Color.Black);
            box.ScrollToCaret();
        }

        public static void OpenLink(string URL)
        {
            Process.Start(URL);
        }
    }
}
