namespace ChuongtrinhQuanlybanhangsieuthi;

static class Program
{
    [STAThread]
    static void Main()
    {
        QuanLySieuThi.Data.DataStorage.Instance.KhoiTaoDuLieuMau();
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmLogin()); 
    }
}