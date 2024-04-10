using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static toolCreateProjectLaravel.Database;

namespace toolCreateProjectLaravel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string dataname = TxtDataName.Text;
            string tk = txtTk.Text;
            string mk = txtMatKhau.Text;
            string lc = txtlocalhost.Text;
            Database a = new Database(lc, dataname, tk, mk);
            foreach (var item in a.tableName())
            {
                MessageBox.Show(item);
            }

        }

        private void button2_Click(object sender, EventArgs e)

        {


            String dataname = TxtDataName.Text;
            string tk = txtTk.Text;
            string mk = txtMatKhau.Text;
            string lc = txtlocalhost.Text;
            Database a = new Database(lc, dataname, tk, mk);
            string oldFilePath = @"C:\Users\nguye\source\repos\toolCreateProjectLaravel\toolCreateProjectLaravel\fileMau\model.php";
            string newFilePath = txtlink.Text; // txtlink.Text chứa đường dẫn cho file mới

            newFilePath += "/app/Models/";



            foreach (var item in a.tableName())
            {
               
                
                try
                {
                    string content = File.ReadAllText(oldFilePath);

                    // Hiển thị nội dung ban đầu trong một MessageBox


                    // Thực hiện sửa đổi nội dung
                    string newContent = content.Replace("ModelName", item);
                    newContent = newContent.Replace("fillableName", a.fillable(item));

                    // Ghi nội dung mới vào một tệp tạm thời
                    string tempFilePath = Path.Combine(Path.GetDirectoryName(newFilePath), item + ".php");
                    File.WriteAllText(tempFilePath, newContent);

                    // Di chuyển và đổi tên tệp tạm thời thành tên tệp mới
                    File.Move(tempFilePath, newFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }


            }
            //try
            //{

                // Đọc nội dung của file

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                //}
        }

        private void txtlink_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String dataname = TxtDataName.Text;
            string tk = txtTk.Text;
            string mk = txtMatKhau.Text;
            string lc = txtlocalhost.Text;
            Database a = new Database(lc, dataname, tk, mk);
            string oldFilePath = @"C:\Users\nguye\source\repos\toolCreateProjectLaravel\toolCreateProjectLaravel\fileMau\Controler.php";
            string newFilePath = txtlink.Text; // txtlink.Text chứa đường dẫn cho file mới

            newFilePath += "/app/Http/Controllers/";



            foreach (var item in a.tableName())
            {
                

                try
                {
                    string content = File.ReadAllText(oldFilePath);

                    // Hiển thị nội dung ban đầu trong một MessageBox


                    // Thực hiện sửa đổi nội item
                    string newContent = content.Replace("modelName", item);

                    newContent = newContent.Replace("Datarequest", a.dataRequest(item));

                    // Ghi nội dung mới vào một tệp tạm thời
                    string tempFilePath = Path.Combine(Path.GetDirectoryName(newFilePath), item + "Controler.php");
                    File.WriteAllText(tempFilePath, newContent);

                    // Di chuyển và đổi tên tệp tạm thời thành tên tệp mới
                    File.Move(tempFilePath, newFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }


            }

        }
    }
}
