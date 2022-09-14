namespace LeHuuToan_2001206939_LTW.Models
{
    public class NhanVien
    {
        public int Id { get; set; } = default(int);
        public string Name { get; set; }
        public string Sex { get; set; } = default(string);
        public string Img { set;get; } = default(string);

        public NhanVien()
        {
            Id = 2002106939;
            Name = "Le Huu Toan";
            Sex = "Nam";
            Img = "https://f5-zpcloud.zdn.vn/4105890429389142989/f77809ab626fa331fa7e.jpg";
        }
    }
}
