/*
 * Project: AVRDUDESS - A GUI for AVRDUDE
 * Author: Zak Kemble, contact@zakkemble.co.uk
 * Copyright: (C) 2014 by Zak Kemble
 * License: GNU GPL v3 (see License.txt)
 * Web: http://blog.zakkemble.co.uk/avrdudess-a-gui-for-avrdude/
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace DemoUSBASP
{
    public class Avrdude
    {
        private Process p;
        private Action<object> onFinish;
        public event EventHandler OnProcessStart;
        public event EventHandler OnProcessEnd;
        private bool processOutputStreamOpen;
        private bool processErrorStreamOpen;
        string avrdude_dir;

        public Avrdude(string avrdude_dir)
        {
            this.avrdude_dir = avrdude_dir;
            Thread t = new Thread(new ThreadStart(tConsoleUpdate));
            t.IsBackground = true;
            t.Start();
        }

        public bool runCommand(string args)
        {
            if (isActive()) // Another process is active
                return false;
            Util.consoleClear();
            Process tmp = new Process();
            tmp.StartInfo.FileName = avrdude_dir;
            tmp.StartInfo.Arguments = args;
            tmp.StartInfo.CreateNoWindow = true;
            tmp.StartInfo.UseShellExecute = false;
            tmp.StartInfo.RedirectStandardOutput = true;
            tmp.StartInfo.RedirectStandardError = true;
            tmp.EnableRaisingEvents = true;
            tmp.Exited += new EventHandler(p_Exited);

            try 
            {
                tmp.Start();
            }
            catch (Exception ex)
            {
                MsgBox.error("Error starting process", ex);
                return false;
            }

            if (OnProcessStart != null)
                OnProcessStart(this, EventArgs.Empty);

            p = tmp;

            processOutputStreamOpen = false;
            processErrorStreamOpen = false;
            return true;
        }

        private void p_Exited(object sender, EventArgs e)
        {
            if (OnProcessEnd != null)
                OnProcessEnd(this, EventArgs.Empty);

            if (onFinish != null)
                onFinish(null);//param
            onFinish = null;
        }

        // Progress bars don't work using async output, since it only fires when a new line is received
        // Problem: Slow if the process outputs a lot of text
        private void tConsoleUpdate()
        {
            while (true)
            {
                Thread.Sleep(15);

                try
                {
                    if (p != null)
                    {
                        char[] buff = new char[256];
                        
                        // TODO: read from stdError AND stdOut (AVRDUDE outputs stuff through stdError)
                        if (p.StandardError.Read(buff, 0, buff.Length) > 0)
                        {
                            string s = new string(buff);
                            Util.consoleWrite(s);
                        }
                    }
                }
                catch (Exception) {}
            }
        }

        protected bool isActive()
        {
            return (p != null && !p.HasExited);
        }

        public bool kill()
        {
            if (!isActive())
                return false;
            p.Kill();
            return true;
        }

        protected void waitForExit()
        {
            if (isActive())
                p.WaitForExit();

            // There might still be data in a buffer somewhere that needs to be read by the output handler even after the process has ended
            while (processOutputStreamOpen && processErrorStreamOpen)
                Thread.Sleep(15);
        }
    }
}
