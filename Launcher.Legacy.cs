using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

internal static class DaRakBangLauncher
{
    [STAThread]
    private static void Main()
    {
        string pagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "index.html");
        if (!File.Exists(pagePath))
        {
            MessageBox.Show("index.html 파일을 찾지 못했습니다.", "다락방 페이지", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        Process.Start(pagePath);
    }
}
