namespace ChuongtrinhQuanlybanhangsieuthi;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Các cấu hình giao diện cơ bản
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmLogin()); 
    }
}