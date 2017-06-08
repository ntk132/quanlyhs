using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class KetQuaHocTapDAL
    {
        private DataAccess da = new DataAccess();

        public KetQuaHocTapDAL()
        {
            
        }

        public DataTable layDanhSachHocSinh(string maLopHoc, int maMonHoc, string maHocKy)
        {
            DataTable dt = new DataTable();

            string query = "select HOCSINH.MaHocSinh, HoTen from KETQUAHOCTAP join HOCSINH on (KETQUAHOCTAP.MaHocSinh=HOCSINH..MaHocSinh) where MaLopHoc=@malop, MaMonHoc=@mamon, MaHocKy=@mahk";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = maLopHoc;
            command.Parameters.AddWithValue("@mamon", SqlDbType.Int).Value = maMonHoc;
            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = maHocKy;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public int laySoLuongKetQuaHocTapCuaMotHocSinh(string maNamHoc, int maHocSinh)
        {
            DataTable dt = new DataTable();

            string query = "select count(*) from KETQUAHOCTAP join HS_LOP on (KETQUAHOCTAP.MaHocSinh=HS_LOP.MaHocSinh) where MaNamHoc=@manh and KETQUAHOCTAP.MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = maHocSinh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.OpenConnection();

            adapter.Fill(dt);

            da.CloseConnection();

            return Convert.ToInt16(dt.Rows[0][0].ToString());
        }

        public DataTable xemDiemCuaHocSinhTrongLop(string maLopHoc, int maMonHoc, string maHocKy)
        {
            DataTable dt = new DataTable();

            string query = "select distinct HOCSINH.MaHocSinh, HoTen, Diem15Phut, Diem1Tiet, DiemTB from HS_LOP join HOCSINH on (HS_LOP.MaHocSinh=HOCSINH.MaHocSinh) join KETQUAHOCTAP on (HOCSINH.MaHocSinh=KETQUAHOCTAP.MaHocSinh) where MaLopHoc=@malop and MaMonHoc=@mamon and MaHocKy=@mahk";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = maLopHoc;
            command.Parameters.AddWithValue("@mamon", SqlDbType.Int).Value = maMonHoc;
            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = maHocKy;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public DataTable xemDiemCuaHocSinh(string maHocKy, string maLopHoc, int maMonHoc, int maHocSinh)
        {
            DataTable dt = new DataTable();

            string query = "select distinct MaHocSinh, Diem15Phut, Diem1Tiet, DiemTB from KETQUAHOCTAP where MaMonHoc=@mamon and MaHocKy=@mahk and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = maLopHoc;
            command.Parameters.AddWithValue("@mamon", SqlDbType.Int).Value = maMonHoc;
            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = maHocKy;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = maHocSinh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public DataTable layDanhSachHS_QLDiem(string maNamHoc, string maLopHoc)
        {
            DataTable dt = new DataTable();

            string query = "select HOCSINH.MaHocSinh, HoTen from HOCSINH join HS_LOP on (HOCSINH.MaHocSinh=HS_LOP.MaHocSinh) where MaNamHoc=@manh and MaLopHoc=@malop";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = maLopHoc;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public DataTable xuatBaoCaoTongKetMonHoc(string maNamHoc, string maHocKy, int maMonHoc, decimal diemToiThieuDat)
        {
            DataTable dt = new DataTable();
            
            string query = "select distinct LOPHOC.MaLopHoc as 'Mã lớp học', SiSo as 'Sĩ số lớp', "
                + "(select count(*) "
                + "from (KETQUAHOCTAP join HS_LOP on (KETQUAHOCTAP.MaHocSinh=HS_LOP.MaHocSinh)) "
                + "where MaHocKy=@mahk and MaMonHoc=@mamon and MaLopHoc=LOPHOC.MaLopHoc and DiemTB >= @diemtoithieudat" 
                + ") as 'Số lượng đạt', "
                + "(select count(*) "
                + "from (KETQUAHOCTAP join HS_LOP on (KETQUAHOCTAP.MaHocSinh=HS_LOP.MaHocSinh)) "
                + "where MaHocKy=@mahk and MaMonHoc=@mamon and MaLopHoc=LOPHOC.MaLopHoc and DiemTB >= @diemtoithieudat" 
                + ") * 100 / SiSo as 'Tỉ lệ' "
                + "from (KETQUAHOCTAP join HS_LOP on (KETQUAHOCTAP.MaHocSinh=HS_LOP.MaHocSinh) join LOPHOC on (HS_LOP.MaLopHoc=LOPHOC.MaLopHoc)) " 
                + "where LOPHOC.MaNamHoc=@manh and MaHocKy=@mahk and MaMonHoc=@mamon";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;
            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = maHocKy;
            command.Parameters.AddWithValue("@mamon", SqlDbType.Int).Value = maMonHoc;
            command.Parameters.AddWithValue("@diemtoithieudat", SqlDbType.Decimal).Value = diemToiThieuDat;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }        

        public decimal tinhDiemTBTuSoMonDaCoDiem(KetQuaHocTapDTO ketquahoctaoDTO)
        {
            DataTable dt = new DataTable();

            string query = "select sum(DiemTB) / count(*) from KETQUAHOCTAP where MaHocKy=@mahk and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = ketquahoctaoDTO.MaHocKy;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = ketquahoctaoDTO.MaHocSinh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return Convert.ToDecimal(dt.Rows[0][0].ToString());
        }

        public void insert(KetQuaHocTapDTO kq)
        {
            string query = "insert into KETQUAHOCTAP (MaHocKy,MaMonHoc,MaHocSinh,Diem15Phut,Diem1Tiet,DiemTB,DiemToiThieuDeDat,CoDatHayKhong) values (@mahk,@mamh,@mahs,@diem15p,@diem1t,@diemtb,@diemtoithieu,@codathaykhong)";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = kq.MaHocKy;
            command.Parameters.AddWithValue("@mamh", SqlDbType.Int).Value = kq.MaMonHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = kq.MaHocSinh;
            command.Parameters.AddWithValue("@diem15p", SqlDbType.Decimal).Value = kq.Diem15Phut;
            command.Parameters.AddWithValue("@diem1t", SqlDbType.Decimal).Value = kq.Diem1Tiet;
            command.Parameters.AddWithValue("@diemtb", SqlDbType.Decimal).Value = kq.DiemTB;
            command.Parameters.AddWithValue("@diemtoithieu", SqlDbType.Decimal).Value = kq.DiemToiThieuDat;
            command.Parameters.AddWithValue("@codathaykhong",SqlDbType.Int).Value = kq.CoDatHayKhong;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(KetQuaHocTapDTO kq)
        {
            string query = "update KETQUAHOCTAP set Diem15Phut=@diem15p, Diem1Tiet=@diem1t, DiemTB=@diemtb, DiemToiThieuDeDat=@diemtoithieu, CoDatHayKhong=@codathaykhong where MaHocKy=@mahk and MaMonHoc=@mamh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = kq.MaHocKy;
            command.Parameters.AddWithValue("@mamh", SqlDbType.Int).Value = kq.MaMonHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = kq.MaHocSinh;
            command.Parameters.AddWithValue("@diem15p", SqlDbType.Decimal).Value = kq.Diem15Phut;
            command.Parameters.AddWithValue("@diem1t", SqlDbType.Decimal).Value = kq.Diem1Tiet;
            command.Parameters.AddWithValue("@diemtb", SqlDbType.Decimal).Value = kq.DiemTB;
            command.Parameters.AddWithValue("@diemtoithieu", SqlDbType.Decimal).Value = kq.DiemToiThieuDat;
            command.Parameters.AddWithValue("@codathaykhong", SqlDbType.Int).Value = kq.CoDatHayKhong;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(KetQuaHocTapDTO kq)
        {
            string query = "delete from KETQUAHOCTAP where MaHocKy=@mahk and MaMonHoc=@mamh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahk", SqlDbType.VarChar).Value = kq.MaHocKy;
            command.Parameters.AddWithValue("@mamh", SqlDbType.Int).Value = kq.MaMonHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = kq.MaHocSinh;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void xoaKetQuaTrongMotNamHoc(string maNamHoc)
        {
            string query = "delete from KETQUAHOCTAP where MaHocKy in (select MaHocKy from HOCKY where MaNamHoc=@manh)";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.Int).Value = maNamHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void xoaKetQuaTrongMotMon(int maMonHoc)
        {
            string query = "delete from KETQUAHOCTAP where MaMonHoc=@mamh";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mamh", SqlDbType.Int).Value = maMonHoc;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void xoaKetQuaHoctapCuaMotHocSinh(int maHocSinh)
        {
            string query = "delete from KETQUAHOCTAP where MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = maHocSinh;

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
