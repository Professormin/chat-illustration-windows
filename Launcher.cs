using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

internal static class Launcher
{
    [STAThread]
    private static void Main()
    {
        try
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "ChatIllustration", "0.1.0");
            Directory.CreateDirectory(folder);
            string path = Path.Combine(folder, "template.html");
            using (Stream source = Assembly.GetExecutingAssembly().GetManifestResourceStream("template.html"))
            {
                if (source == null) throw new InvalidOperationException("Template resource is missing.");
                using (FileStream target = File.Create(path)) source.CopyTo(target);
            }
            Process.Start(new ProcessStartInfo(new Uri(path).AbsoluteUri) { UseShellExecute = true });
        }
        catch (Exception error)
        {
            MessageBox.Show(error.Message, "Chat Illustration", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
