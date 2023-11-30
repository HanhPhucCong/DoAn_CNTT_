using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DoAnCNTT
{
    public class Const
    {
        public static NhanSu NewNhanSu = null;
        public static NhanVien NewNhanVien = null;
        public static QuanLy NewQuanLy = null;
        public static CongNhan NewCongNhan = null;
        public static KySu NewKySu = null;
        public static User NewUser = null;
        public static string loai;

        public static List<string> Listgioitinh = new List<string>() { "Nam", "Nữ", "Giới tính thứ 3", "Không xác định" };
        public static List<string> Listtrinhdo = new List<string>() { "1/12", "2/12", "3/12", "4/12", "5/12", "6/12", "7/12", "8/12", "9/12", "10/12", "11/12", "12/12", "Cao đẳng", "Đại học" };

        public static List<string> Listphong = new List<string>() { "Phòng nhân sự", "Phòng công nghệ", "Phòng kế toán", "Phòng xây dựng", "Phòng thiết kế" };
        public static List<string> Listcongviet = new List<string>() { "Kế toán", "Xây dựng", "Thiết kế", "Giám sát công trình", "Công nhân" };

        public static List<string> Listbac = new List<string>() { "Bậc 1", "Bậc 2", "Bậc 3", "Bậc 4", "Bậc 5", "Bậc 6", "Bậc 7" };
        public static List<string> Listto = new List<string>() { "Tổ xây dựng", "Tổ thiết kế", "Tổ công nghệ", "Tổ Kế toán", "Tổ kinh doanh" };
        public static List<string> Listnhom = new List<string>() { "Nhóm 1", "Nhóm 2", "Nhóm 3", "Nhóm 4", "Nhóm 5", "Nhóm 6", "Nhóm 7" };


        public static List<string> Listbophan = new List<string>() { "Bộ phận xây dựng", "Bộ phận thiết kế", "Bộ phận công nghệ thông tin", "Bộ phận quản lý" };
        public static List<string> Listnganh = new List<string>() { "Ngành thiết kế", "Ngành công nghệ thông tin", "Ngành xây dựng", "Ngành kinh doanh" };

        public static void LuuDanhSachNguoiDung(List<User> danhSachNguoiDung)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<User>));
            TextWriter txtWriter = new StreamWriter(@"NguoiDung.xml");

            xs.Serialize(txtWriter, danhSachNguoiDung);

            txtWriter.Close();
        }
        public static List<User> DocDanhSachNguoiDung()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<User>));
            StreamReader reader = new StreamReader(@"NguoiDung.xml");

            List<User> danhSachNguoiDung = (List<User>)xs.Deserialize(reader);
            reader.Close();

            return danhSachNguoiDung;
        }
        public static void DocNhanSu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "SELECT * FROM NhanSu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NhanSu nhanSu = new NhanSu()
                            {
                                Manhansu = reader.GetString(0),
                                Hoten = reader.GetString(1),
                                Ngaysinh = reader.GetDateTime(2),
                                Gioitinh = reader.GetString(3),
                                Diachi = reader.GetString(4),
                                Trinhdo = reader.GetString(5),
                                Loainhansu = reader.GetString(6)
                            };
                            ListNhanSu.Instance.Listnhansu.Add(nhanSu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static void LuuNhanSu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    foreach (var nhanSu in ListNhanSu.Instance.Listnhansu)
                    {
                        string sqlStr = "INSERT INTO NhanSu (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu) VALUES (@manhansu, @hoten, @ngaysinh, @gioitinh, @diachi, @trinhdo, @loainhansu)";
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        cmd.Parameters.AddWithValue("@manhansu", nhanSu.Manhansu);
                        cmd.Parameters.AddWithValue("@hoten", nhanSu.Hoten);
                        cmd.Parameters.AddWithValue("@ngaysinh", nhanSu.Ngaysinh);
                        cmd.Parameters.AddWithValue("@gioitinh", nhanSu.Gioitinh);
                        cmd.Parameters.AddWithValue("@diachi", nhanSu.Diachi);
                        cmd.Parameters.AddWithValue("@trinhdo", nhanSu.Trinhdo);
                        cmd.Parameters.AddWithValue("@loainhansu", nhanSu.Loainhansu);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void XoaNhanSu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "DELETE FROM NhanSu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void ThemNhanSu(NhanSu nhanSuMoi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "INSERT INTO NhanSu (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu) VALUES (@manhansu, @hoten, @ngaysinh, @gioitinh, @diachi, @trinhdo, @loainhansu)";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", nhanSuMoi.Manhansu);
                    cmd.Parameters.AddWithValue("@hoten", nhanSuMoi.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", nhanSuMoi.Ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", nhanSuMoi.Gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", nhanSuMoi.Diachi);
                    cmd.Parameters.AddWithValue("@trinhdo", nhanSuMoi.Trinhdo);
                    cmd.Parameters.AddWithValue("@loainhansu", nhanSuMoi.Loainhansu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void CapNhatNhanSu(NhanSu nhanSuCapNhat)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "UPDATE NhanSu SET hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, trinhdo = @trinhdo, loainhansu = @loainhansu WHERE manhansu = @manhansu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", nhanSuCapNhat.Manhansu);
                    cmd.Parameters.AddWithValue("@hoten", nhanSuCapNhat.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", nhanSuCapNhat.Ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", nhanSuCapNhat.Gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", nhanSuCapNhat.Diachi);
                    cmd.Parameters.AddWithValue("@trinhdo", nhanSuCapNhat.Trinhdo);
                    cmd.Parameters.AddWithValue("@loainhansu", nhanSuCapNhat.Loainhansu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void XoaNhanSu(string maNhanSu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "DELETE FROM NhanSu WHERE manhansu = @manhansu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", maNhanSu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static void DocNhanVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "SELECT * FROM NhanVien";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NhanVien nhanvien = new NhanVien()
                            {
                                Manhansu = reader.GetString(0),
                                Hoten = reader.GetString(1),
                                Ngaysinh = reader.GetDateTime(2),
                                Gioitinh = reader.GetString(3),
                                Diachi = reader.GetString(4),
                                Trinhdo = reader.GetString(5),
                                Loainhansu = reader.GetString(6),
                                Congviec = reader.GetString(7),
                                Phong = reader.GetString(8)
                            };
                            ListNhanVien.Instance.Listnhanvien.Add(nhanvien);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static void LuuNhanVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    foreach (var nhanvien in ListNhanVien.Instance.Listnhanvien)
                    {
                        string sqlStr = "INSERT INTO NhanVien (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu, congviec, phong) VALUES (@manhansu, @hoten, @ngaysinh, @gioitinh, @diachi, @trinhdo, @loainhansu, @congviec, @phong)";
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        cmd.Parameters.AddWithValue("@manhansu", nhanvien.Manhansu);
                        cmd.Parameters.AddWithValue("@hoten", nhanvien.Hoten);
                        cmd.Parameters.AddWithValue("@ngaysinh", nhanvien.Ngaysinh);
                        cmd.Parameters.AddWithValue("@gioitinh", nhanvien.Gioitinh);
                        cmd.Parameters.AddWithValue("@diachi", nhanvien.Diachi);
                        cmd.Parameters.AddWithValue("@trinhdo", nhanvien.Trinhdo);
                        cmd.Parameters.AddWithValue("@loainhansu", nhanvien.Loainhansu);
                        cmd.Parameters.AddWithValue("@congviec", nhanvien.Congviec);
                        cmd.Parameters.AddWithValue("@phong", nhanvien.Phong);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void XoaNhanVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "DELETE FROM NhanVien";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void ThemNhanVien(NhanVien nhanVienMoi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "INSERT INTO NhanVien (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu, congviec, phong) VALUES (@manhansu, @hoten, @ngaysinh, @gioitinh, @diachi, @trinhdo, @loainhansu, @congviec, @phong)";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", nhanVienMoi.Manhansu);
                    cmd.Parameters.AddWithValue("@hoten", nhanVienMoi.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", nhanVienMoi.Ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", nhanVienMoi.Gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", nhanVienMoi.Diachi);
                    cmd.Parameters.AddWithValue("@trinhdo", nhanVienMoi.Trinhdo);
                    cmd.Parameters.AddWithValue("@loainhansu", nhanVienMoi.Loainhansu);
                    cmd.Parameters.AddWithValue("@congviec", nhanVienMoi.Congviec);
                    cmd.Parameters.AddWithValue("@phong", nhanVienMoi.Phong);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void CapNhatNhanVien(NhanVien nhanVienCapNhat)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "UPDATE NhanVien SET hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, trinhdo = @trinhdo, loainhansu = @loainhansu, congviec = @congviec, phong = @phong WHERE manhansu = @manhansu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", nhanVienCapNhat.Manhansu);
                    cmd.Parameters.AddWithValue("@hoten", nhanVienCapNhat.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", nhanVienCapNhat.Ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", nhanVienCapNhat.Gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", nhanVienCapNhat.Diachi);
                    cmd.Parameters.AddWithValue("@trinhdo", nhanVienCapNhat.Trinhdo);
                    cmd.Parameters.AddWithValue("@loainhansu", nhanVienCapNhat.Loainhansu);
                    cmd.Parameters.AddWithValue("@congviec", nhanVienCapNhat.Congviec);
                    cmd.Parameters.AddWithValue("@phong", nhanVienCapNhat.Phong);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void XoaNhanVien(string maNhanSu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "DELETE FROM NhanVien WHERE manhansu = @manhansu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", maNhanSu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static void DocKySu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "SELECT * FROM KySu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            KySu kysu = new KySu()
                            {
                                Manhansu = reader.GetString(0),
                                Hoten = reader.GetString(1),
                                Ngaysinh = reader.GetDateTime(2),
                                Gioitinh = reader.GetString(3),
                                Diachi = reader.GetString(4),
                                Trinhdo = reader.GetString(5),
                                Loainhansu = reader.GetString(6),
                                Nganhdaotao = reader.GetString(7),
                                Bophan = reader.GetString(8)
                            };
                            ListKySu.Instance.Listkysu.Add(kysu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static void LuuKySu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    foreach (var kysu in ListKySu.Instance.Listkysu)
                    {
                        string sqlStr = "INSERT INTO KySu (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu, nganhdaotao, bophan) VALUES (@manhansu, @hoten, @ngaysinh, @gioitinh, @diachi, @trinhdo, @loainhansu, @nganhdaotao, @bophan)";
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        cmd.Parameters.AddWithValue("@manhansu", kysu.Manhansu);
                        cmd.Parameters.AddWithValue("@hoten", kysu.Hoten);
                        cmd.Parameters.AddWithValue("@ngaysinh", kysu.Ngaysinh);
                        cmd.Parameters.AddWithValue("@gioitinh", kysu.Gioitinh);
                        cmd.Parameters.AddWithValue("@diachi", kysu.Diachi);
                        cmd.Parameters.AddWithValue("@trinhdo", kysu.Trinhdo);
                        cmd.Parameters.AddWithValue("@loainhansu", kysu.Loainhansu);
                        cmd.Parameters.AddWithValue("@nganhdaotao", kysu.Nganhdaotao);
                        cmd.Parameters.AddWithValue("@bophan", kysu.Bophan);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void XoaKySu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "DELETE FROM KySu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void ThemKySu(KySu kySuMoi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "INSERT INTO KySu (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu, nganhdaotao, bophan) VALUES (@manhansu, @hoten, @ngaysinh, @gioitinh, @diachi, @trinhdo, @loainhansu, @nganhdaotao, @bophan)";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", kySuMoi.Manhansu);
                    cmd.Parameters.AddWithValue("@hoten", kySuMoi.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", kySuMoi.Ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", kySuMoi.Gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", kySuMoi.Diachi);
                    cmd.Parameters.AddWithValue("@trinhdo", kySuMoi.Trinhdo);
                    cmd.Parameters.AddWithValue("@loainhansu", kySuMoi.Loainhansu);
                    cmd.Parameters.AddWithValue("@nganhdaotao", kySuMoi.Nganhdaotao);
                    cmd.Parameters.AddWithValue("@bophan", kySuMoi.Bophan);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void CapNhatKySu(KySu kySuCapNhat)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "UPDATE KySu SET hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, trinhdo = @trinhdo, loainhansu = @loainhansu, nganhdaotao = @nganhdaotao, bophan = @bophan WHERE manhansu = @manhansu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", kySuCapNhat.Manhansu);
                    cmd.Parameters.AddWithValue("@hoten", kySuCapNhat.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", kySuCapNhat.Ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", kySuCapNhat.Gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", kySuCapNhat.Diachi);
                    cmd.Parameters.AddWithValue("@trinhdo", kySuCapNhat.Trinhdo);
                    cmd.Parameters.AddWithValue("@loainhansu", kySuCapNhat.Loainhansu);
                    cmd.Parameters.AddWithValue("@nganhdaotao", kySuCapNhat.Nganhdaotao);
                    cmd.Parameters.AddWithValue("@bophan", kySuCapNhat.Bophan);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void XoaKySu(string maNhanSu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "DELETE FROM KySu WHERE manhansu = @manhansu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", maNhanSu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static void DocCongNhan()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "SELECT * FROM CongNhan";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CongNhan congnhan = new CongNhan()
                            {
                                Manhansu = reader.GetString(0),
                                Hoten = reader.GetString(1),
                                Ngaysinh = reader.GetDateTime(2),
                                Gioitinh = reader.GetString(3),
                                Diachi = reader.GetString(4),
                                Trinhdo = reader.GetString(5),
                                Loainhansu = reader.GetString(6),
                                Bac = reader.GetString(7),
                                To = reader.GetString(8),
                                Nhom = reader.GetString(9)
                            };
                            ListCongNhan.Instance.Listcongnhan.Add(congnhan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static void LuuCongNhan()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    foreach (var congnhan in ListCongNhan.Instance.Listcongnhan)
                    {
                        string sqlStr = "INSERT INTO CongNhan (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu, bac, loaito, nhom) VALUES (@manhansu, @hoten, @ngaysinh, @gioitinh, @diachi, @trinhdo, @loainhansu, @bac, @to, @nhom)";
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        cmd.Parameters.AddWithValue("@manhansu", congnhan.Manhansu);
                        cmd.Parameters.AddWithValue("@hoten", congnhan.Hoten);
                        cmd.Parameters.AddWithValue("@ngaysinh", congnhan.Ngaysinh);
                        cmd.Parameters.AddWithValue("@gioitinh", congnhan.Gioitinh);
                        cmd.Parameters.AddWithValue("@diachi", congnhan.Diachi);
                        cmd.Parameters.AddWithValue("@trinhdo", congnhan.Trinhdo);
                        cmd.Parameters.AddWithValue("@loainhansu", congnhan.Loainhansu);
                        cmd.Parameters.AddWithValue("@bac", congnhan.Bac);
                        cmd.Parameters.AddWithValue("@to", congnhan.To);
                        cmd.Parameters.AddWithValue("@nhom", congnhan.Nhom);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void XoaCongNhan()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "DELETE FROM CongNhan";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void ThemCongNhan(CongNhan congNhanMoi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "INSERT INTO CongNhan (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu, bac, loaito, nhom) VALUES (@manhansu, @hoten, @ngaysinh, @gioitinh, @diachi, @trinhdo, @loainhansu, @bac, @to, @nhom)";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", congNhanMoi.Manhansu);
                    cmd.Parameters.AddWithValue("@hoten", congNhanMoi.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", congNhanMoi.Ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", congNhanMoi.Gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", congNhanMoi.Diachi);
                    cmd.Parameters.AddWithValue("@trinhdo", congNhanMoi.Trinhdo);
                    cmd.Parameters.AddWithValue("@loainhansu", congNhanMoi.Loainhansu);
                    cmd.Parameters.AddWithValue("@bac", congNhanMoi.Bac);
                    cmd.Parameters.AddWithValue("@to", congNhanMoi.To);
                    cmd.Parameters.AddWithValue("@nhom", congNhanMoi.Nhom);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void CapNhatCongNhan(CongNhan congNhanCapNhat)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "UPDATE CongNhan SET hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, trinhdo = @trinhdo, loainhansu = @loainhansu, bac = @bac, loaito = @to, nhom = @nhom WHERE manhansu = @manhansu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", congNhanCapNhat.Manhansu);
                    cmd.Parameters.AddWithValue("@hoten", congNhanCapNhat.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", congNhanCapNhat.Ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", congNhanCapNhat.Gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", congNhanCapNhat.Diachi);
                    cmd.Parameters.AddWithValue("@trinhdo", congNhanCapNhat.Trinhdo);
                    cmd.Parameters.AddWithValue("@loainhansu", congNhanCapNhat.Loainhansu);
                    cmd.Parameters.AddWithValue("@bac", congNhanCapNhat.Bac);
                    cmd.Parameters.AddWithValue("@to", congNhanCapNhat.To);
                    cmd.Parameters.AddWithValue("@nhom", congNhanCapNhat.Nhom);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void XoaCongNhan(string maNhanSu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "DELETE FROM CongNhan WHERE manhansu = @manhansu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", maNhanSu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static void DocQuanLy()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "SELECT * FROM QuanLy";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            QuanLy quanly = new QuanLy()
                            {
                                Manhansu = reader.GetString(0),
                                Hoten = reader.GetString(1),
                                Ngaysinh = reader.GetDateTime(2),
                                Gioitinh = reader.GetString(3),
                                Diachi = reader.GetString(4),
                                Trinhdo = reader.GetString(5),
                                Loainhansu = reader.GetString(6)
                            };
                            ListQuanLy.Instance.Listquanly.Add(quanly);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static void LuuQuanLy()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    foreach (var quanly in ListQuanLy.Instance.Listquanly)
                    {
                        string sqlStr = "INSERT INTO QuanLy (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu) VALUES (@manhansu, @hoten, @ngaysinh, @gioitinh, @diachi, @trinhdo, @loainhansu)";
                        SqlCommand cmd = new SqlCommand(sqlStr, conn);
                        cmd.Parameters.AddWithValue("@manhansu", quanly.Manhansu);
                        cmd.Parameters.AddWithValue("@hoten", quanly.Hoten);
                        cmd.Parameters.AddWithValue("@ngaysinh", quanly.Ngaysinh);
                        cmd.Parameters.AddWithValue("@gioitinh", quanly.Gioitinh);
                        cmd.Parameters.AddWithValue("@diachi", quanly.Diachi);
                        cmd.Parameters.AddWithValue("@trinhdo", quanly.Trinhdo);
                        cmd.Parameters.AddWithValue("@loainhansu", quanly.Loainhansu);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void XoaQuanLy()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "DELETE FROM QuanLy";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void ThemQuanLy(QuanLy quanLyMoi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "INSERT INTO QuanLy (manhansu, hoten, ngaysinh, gioitinh, diachi, trinhdo, loainhansu) VALUES (@manhansu, @hoten, @ngaysinh, @gioitinh, @diachi, @trinhdo, @loainhansu)";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", quanLyMoi.Manhansu);
                    cmd.Parameters.AddWithValue("@hoten", quanLyMoi.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", quanLyMoi.Ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", quanLyMoi.Gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", quanLyMoi.Diachi);
                    cmd.Parameters.AddWithValue("@trinhdo", quanLyMoi.Trinhdo);
                    cmd.Parameters.AddWithValue("@loainhansu", quanLyMoi.Loainhansu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void CapNhatQuanLy(QuanLy quanLyCapNhat)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "UPDATE QuanLy SET hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, trinhdo = @trinhdo, loainhansu = @loainhansu WHERE manhansu = @manhansu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", quanLyCapNhat.Manhansu);
                    cmd.Parameters.AddWithValue("@hoten", quanLyCapNhat.Hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", quanLyCapNhat.Ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", quanLyCapNhat.Gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", quanLyCapNhat.Diachi);
                    cmd.Parameters.AddWithValue("@trinhdo", quanLyCapNhat.Trinhdo);
                    cmd.Parameters.AddWithValue("@loainhansu", quanLyCapNhat.Loainhansu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public static void XoaQuanLy(string maNhanSu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
                {
                    conn.Open();
                    string sqlStr = "DELETE FROM QuanLy WHERE manhansu = @manhansu";
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@manhansu", maNhanSu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}