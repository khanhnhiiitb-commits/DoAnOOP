using System.Text.Json.Serialization;

namespace QuanLySieuThi.Models.Systems
{
    public class CaLamViec
    {
        private string maCa;
        private string tenCa;
        private TimeSpan gioBatDau;
        private TimeSpan gioKetThuc;
        // Properties 
        public string MaCa {  get { return maCa; }  set { maCa = value; } }
        public string TenCa  {  get { return tenCa; }  set { tenCa = value; } }
       
        // 1. Tạo 2 thuộc tính dạng string để JSON tự động map vào
        [JsonInclude]
        [JsonPropertyName("GioBatDau")] // Gắn đích danh key trong JSON
        public string GioBatDauString
        {
            get { return gioBatDau.ToString(@"hh\:mm\:ss"); }
            set { gioBatDau = TimeSpan.Parse(value); } // Tự động ép kiểu sang TimeSpan
        }

        [JsonInclude]
        [JsonPropertyName("GioKetThuc")]
        public string GioKetThucString
        {
            get { return gioKetThuc.ToString(@"hh\:mm\:ss"); }
            set
            {
                TimeSpan temp = TimeSpan.Parse(value);
                if (temp > gioBatDau) gioKetThuc = temp;
                else gioKetThuc = gioBatDau.Add(TimeSpan.FromHours(8));
            }
        }

        // 2. Ẩn 2 thuộc tính TimeSpan gốc khỏi JSON (để không bị lỗi)
        [JsonIgnore]
        public TimeSpan GioBatDau { get { return gioBatDau; } set { gioBatDau = value; } }

        [JsonIgnore]
        public TimeSpan GioKetThuc
        {
            get { return gioKetThuc; }
            set
            {
                if (value > gioBatDau) gioKetThuc = value;
                else gioKetThuc = gioBatDau.Add(TimeSpan.FromHours(8));
            }
        }
        // Constructor 
        public CaLamViec() { }
        public CaLamViec(string maCa, string tenCa, TimeSpan batDau, TimeSpan ketThuc)
        {
            this.MaCa = maCa;
            this.TenCa = tenCa;
            this.GioBatDau = batDau;
            this.GioKetThuc = ketThuc;
        }
    
    }
}