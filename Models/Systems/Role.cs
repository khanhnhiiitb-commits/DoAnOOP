namespace QuanLySieuThi.Models.Systems
{
    public class Role
    {
        private string maRole;
        private string tenRole;
        private string moTa;

        public string MaRole 
        { 
            get {return maRole;}
          set{ maRole = value;} 
        }
        public string TenRole 
        { 
            get{return tenRole;}
            set{tenRole = value;}
         }                           // Ví dụ: "Quản trị viên", "Thu ngân"
        public string MoTa 
        { get{return moTa;}
         set{moTa = value;} 
         }

        public Role()
        {}


        public Role(string ma, string ten, string moTa)
        {
            MaRole = ma;
            TenRole = ten;
            MoTa = moTa;
        }
    }
}
