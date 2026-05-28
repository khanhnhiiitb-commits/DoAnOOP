using System.Collections.Generic;

namespace QuanLySieuThi.Data
{
    // Interface Generic áp dụng cho mọi Repository
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Save(List<T> danhSach);
    }
}