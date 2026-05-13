namespace ChuongtrinhQuanlybanhangsieuthi;

static class Program
{
    [STAThread]
    static void Main()
    {
        QuanLySieuThi.Data.DataStorage storage = QuanLySieuThi.Data.DataStorage.Instance;
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmLogin()); 
    }
}