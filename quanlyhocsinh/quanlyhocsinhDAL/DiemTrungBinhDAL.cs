using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using quanlyhocsinhDTO;

namespace quanlyhocsinhDAL
{
    public class DiemTrungBinhDAL
    {
        DataAccess da = new DataAccess();

        public DiemTrungBinhDAL()
        {

        }

        public DataTable xemDiemTBToanBoHocSinh(string maNamHoc)
        {
            DataTable dt = new DataTable();

            string query = "select DIEMTRUNGBINHNAMHOC.MaHocSinh, HoTen, DiemTrungBinhHK1, DiemTrungBinhHK2, DiemTrungBinhNam from DIEMTRUNGBINHNAMHOC join HOCSINH on (DIEMTRUNGBINHNAMHOC.MaHocSinh=HOCSINH.MaHocSinh) where MaNamHoc=@manh";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public DataTable xemDiemTBTheoLop(string maNamHoc, string maLopHoc)
        {
            DataTable dt = new DataTable();

            string query = "select DIEMTRUNGBINHNAMHOC.MaHocSinh, HoTen, DiemTrungBinhHK1, DiemTrungBinhHK2, DiemTrungBinhNam from DIEMTRUNGBINHNAMHOC join HOCSINH on (DIEMTRUNGBINHNAMHOC.MaHocSinh=HOCSINH.MaHocSinh) join HS_LOP on (DIEMTRUNGBINHNAMHOC.MaHocSinh=HS_LOP.MaHocSinh) where DIEMTRUNGBINHNAMHOC.MaNamHoc=@manh and MaLopHoc=@malop";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;
            command.Parameters.AddWithValue("@malop", SqlDbType.VarChar).Value = maLopHoc;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public DataTable xemDiemTrungBinhCuaHocSinh(string maNamHoc, int maHocSinh)
        {
            DataTable dt = new DataTable();

            string query = "select MaHocSinh, DiemTrungBinhHK1, DiemTrungBinhHK2, DiemTrungBinhNam from DIEMTRUNGBINHNAMHOC where DIEMTRUNGBINHNAMHOC.MaNamHoc=@manh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = maHocSinh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public decimal tinhDiemTrungBinhNamHoc(DiemTrungBinhDTO diemtbDTO)
        {
            DataTable dt = new DataTable();

            string query = "select (DiemTrungBinhHK1 + DiemTrungBinhHK2) / 2 from DIEMTRUNGBINHNAMHOC where MaNamHoc=@manh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = diemtbDTO.MaNamHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = diemtbDTO.MaHocSinh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return Convert.ToDecimal(dt.Rows[0][0].ToString());
        }

        public DataTable xuatBaoCaoTongKetHocKy(string maNamHoc, string index)
        {
            DataTable dt = new DataTable();
            string diemTBHK = "DiemTrungBinhHK" + index;
            string query = "select distinct LOPHOC.MaLopHoc as 'Mã lớp học', SiSo as 'Sĩ số lớp', "
                + "(select count(*) "
                + "from DIEMTRUNGBINHNAMHOC dtb join HS_LOP on (dtb.MaHocSinh=HS_LOP.MaHocSinh) join LOPHOC lha on (HS_LOP.MaLopHoc=LOPHOC.MaLopHoc) "
                + "where dtb.DiemTrungBinhHK1 >= 5.0 and lha.MaLopHoc=LOPHOC.MaLopHoc"
                + ") as 'Số lượng đạt',"
                + "(select count(*) "
                + "from DIEMTRUNGBINHNAMHOC dtb join HS_LOP on (dtb.MaHocSinh=HS_LOP.MaHocSinh) join LOPHOC lha on (HS_LOP.MaLopHoc=LOPHOC.MaLopHoc) "
                + "where dtb.DiemTrungBinhHK1 >= 5.0 and lha.MaLopHoc=LOPHOC.MaLopHoc"
                + ") * 100 / SiSo as 'Tỉ lệ'"
                + "from DIEMTRUNGBINHNAMHOC dtb join HS_LOP on (dtb.MaHocSinh=HS_LOP.MaHocSinh) join LOPHOC on (HS_LOP.MaLopHoc=LOPHOC.MaLopHoc) "
                + "where dtb.MaNamHoc=@manh";

            SqlCommand command = new SqlCommand();

            command.Connection = da.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            adapter.Fill(dt);

            da.connection.Close();

            return dt;
        }

        public void insert(DiemTrungBinhDTO diemtrungbinhDTO)
        {
            string query = "insert into DIEMTRUNGBINHNAMHOC (MaNamHoc,MaHocSinh,DiemTrungBinhHK1,DiemTrungBinhHK2,DiemTrungBinhNam) values (@manh,@mahs,@tbhk1,@tbhk2,@tbnam)";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = diemtrungbinhDTO.MaNamHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = diemtrungbinhDTO.MaHocSinh;
            command.Parameters.AddWithValue("@tbhk1", SqlDbType.Decimal).Value = diemtrungbinhDTO.DiemTrungBinhHK1;
            command.Parameters.AddWithValue("@tbhk2", SqlDbType.Decimal).Value = diemtrungbinhDTO.DiemTrungBinhHK2;
            command.Parameters.AddWithValue("@tbnam", SqlDbType.Decimal).Value = diemtrungbinhDTO.DiemTrungBinhHKNam;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void update(DiemTrungBinhDTO diemtrungbinhDTO)
        {
            string query = "update DIEMTRUNGBINHNAMHOC set DiemTrungBinhHK1=@tbhk1,DiemTrungBinhHK2=@tbhk2,DiemTrungBinhNam=@tbnam where MaNamHoc=@manh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = diemtrungbinhDTO.MaNamHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = diemtrungbinhDTO.MaHocSinh;
            command.Parameters.AddWithValue("@tbhk1", SqlDbType.Decimal).Value = diemtrungbinhDTO.DiemTrungBinhHK1;
            command.Parameters.AddWithValue("@tbhk2", SqlDbType.Decimal).Value = diemtrungbinhDTO.DiemTrungBinhHK2;
            command.Parameters.AddWithValue("@tbnam", SqlDbType.Decimal).Value = diemtrungbinhDTO.DiemTrungBinhHKNam;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void CapNhatDiemTBHK1(DiemTrungBinhDTO diemtrungbinhDTO)
        {
            string query = "update DIEMTRUNGBINHNAMHOC set DiemTrungBinhHK1=@tbhk1 where MaNamHoc=@manh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = diemtrungbinhDTO.MaNamHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = diemtrungbinhDTO.MaHocSinh;
            command.Parameters.AddWithValue("@tbhk1", SqlDbType.Decimal).Value = diemtrungbinhDTO.DiemTrungBinhHK1;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void CapNhatDiemTBHK2(DiemTrungBinhDTO diemtrungbinhDTO)
        {
            string query = "update DIEMTRUNGBINHNAMHOC set DiemTrungBinhHK2=@tbhk2 where MaNamHoc=@manh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = diemtrungbinhDTO.MaNamHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = diemtrungbinhDTO.MaHocSinh;
            command.Parameters.AddWithValue("@tbhk2", SqlDbType.Decimal).Value = diemtrungbinhDTO.DiemTrungBinhHK2;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void delete(DiemTrungBinhDTO diemtbDTO)
        {
            string query = "delete from DIEMTRUNGBINHNAMHOC where MaNamHoc=@manh and MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = diemtbDTO.MaNamHoc;
            command.Parameters.AddWithValue("@mahs", SqlDbType.Int).Value = diemtbDTO.MaHocSinh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void xoaDiemTBTrongNamHoc(string maNamHoc)
        {
            string query = "delete from DIEMTRUNGBINHNAMHOC where MaNamHoc=@manh";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@manh", SqlDbType.VarChar).Value = maNamHoc;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }

        public void xoaDiemTBCuaMotHocSinh(int maHocSinh)
        {
            string query = "delete from DIEMTRUNGBINHNAMHOC where MaHocSinh=@mahs";

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = da.connection;
            command.CommandText = query;

            command.Parameters.AddWithValue("@mahs", SqlDbType.VarChar).Value = maHocSinh;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            da.connection.Open();

            command.ExecuteNonQuery();

            da.connection.Close();
        }
    }
}
