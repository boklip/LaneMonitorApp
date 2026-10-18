using System;
using System.Windows.Forms;
using LibVLCSharp.Shared;

namespace LaneMonitorApp2
{
    internal static class Program
    {
        [STAThread]
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Core step: Initialize the VLC engine deployment files
            Core.Initialize();
            Application.Run(new Form1());
    }
    
    }
}