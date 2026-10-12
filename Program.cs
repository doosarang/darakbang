using System.Diagnostics;
using System.Windows.Forms;

namespace DaRakBangLauncher;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        var pagePath = Path.Combine(AppContext.BaseDirectory, "index.html");

        if (!File.Exists(pagePath))
        {
            MessageBox.Show(
                "index.html 파일을 찾지 못했습니다. 실행 파일과 웹페이지 파일을 같은 폴더에 두어 주세요.",
                "다락방 페이지",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        Process.Start(new ProcessStartInfo(pagePath) { UseShellExecute = true });
    }
}
