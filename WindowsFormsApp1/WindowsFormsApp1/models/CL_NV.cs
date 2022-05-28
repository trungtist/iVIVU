using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.models
{
    class CL_NV
    {
        private string _manv;
        private string _tennv;
        private string _chucvu;
        private long _luong;
        private DateTime _ngaysinh;
        private string _gioitinh;
        private string _chuthich;
        public CL_NV() { }
        public CL_NV(string manv, string tennv, string chucvu, long luong, DateTime ngaysinh, string gioitinh, string chuthich)
        {
            _manv = manv;
            _tennv = tennv;
            _chucvu = chucvu;
            _luong = luong;
            _ngaysinh = ngaysinh;
            _gioitinh = gioitinh;
            _chuthich = chuthich;
        }

        public string Manv { get => _manv; set => _manv = value; }
        public string Tennv { get => _tennv; set => _tennv = value; }
        public string Chucvu { get => _chucvu; set => _chucvu = value; }
        public long Luong { get => _luong; set => _luong = value; }
        public DateTime Ngaysinh { get => _ngaysinh; set => _ngaysinh = value; }
        public string Gioitinh { get => _gioitinh; set => _gioitinh = value; }
        public string Chuthich { get => _chuthich; set => _chuthich = value; }

        //SqlDataReader rd = cm.ExecuteReader();
        /*đọc dữ liệu
        while(rd.Read()) //trong khi con đọc dữ liệu thì truy ván đc thực thi
        {
            models.CL_NV obj = new models.CL_NV();
            obj.Manv = rd["Manv"].ToString();
            obj.Tennv = rd["Tennv"].ToString();
            obj.Chucvu = rd["Chucvu"].ToString();
            obj.Luong = (long)rd["Luong"];
            obj.Ngaysinh = (DateTime)rd["Ngaysinh"];
            obj.Gioitinh = rd["Gioitinh"].ToString();
            obj.Chuthich = rd["Chuthich"].ToString();


            lst.Add(obj);
        } */
    }

}
