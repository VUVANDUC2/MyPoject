using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    internal class GiangVien
    {

        private string ten;
        private string diachi;
        private string cmnd;
        private string ngaysinh;

        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }

        public GiangVien(string ten, string diachi, string cmnd, string ngaysinh)
        {
            Ten = ten;
            Diachi = diachi;
            Cmnd = cmnd;
            Ngaysinh = ngaysinh;
        }
    }
}
