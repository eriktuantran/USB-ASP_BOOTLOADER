/*
 * Project: AVRDUDESS - A GUI for AVRDUDE
 * Author: Zak Kemble, contact@zakkemble.co.uk
 * Copyright: (C) 2013 by Zak Kemble
 * License: GNU GPL v3 (see License.txt)
 * Web: http://blog.zakkemble.co.uk/avrdudess-a-gui-for-avrdude/
 */

using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DemoUSBASP
{
    // Action without parameters doesn't seem to be a thing in .NET 2.0
    public delegate void Action();

    static class Util
    {
        // No Dispatcher stuff in .NET 2.0, make a static reference to our main form
        public static Form UI;

        private static TextBox console;

        public static void InvokeIfRequired<T>(this T c, Action<T> action)
            where T : Control
        {
            try
            {
                if (c.InvokeRequired)
                    c.Invoke(new Action(() => action(c)));
                else
                    action(c);
            }
            catch (Exception)
            {

            }
        }

        public static void consoleSet(TextBox textBox)
        {
            console = textBox;
        }

        // Write to console
        public static void consoleWrite(string text)
        {
            // Credits:
            // Uwe Tanger (Console in main window instead of separate window)
            // Dean (Console in main window instead of separate window)

            if (console != null)
                console.InvokeIfRequired(c => { ((TextBox)c).AppendText(text); });
        }

        // Clear console
        public static void consoleClear()
        {
            if (console != null)
                console.InvokeIfRequired(c => { ((TextBox)c).Clear(); });
        }
    }

    static class MsgBox
    {
        public static void error(string msg, Exception ex)
        {
            error(msg + Environment.NewLine + ex.Message);
        }

        public static void error(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void warning(string msg)
        {
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void notice(string msg)
        {
            MessageBox.Show(msg, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
