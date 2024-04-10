using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace toolCreateProjectLaravel
{
    

    internal class Cread
    {
        private string Link;

        public Cread(string Link)
        {
            this.Link = Link;
        }

        public void CreadModel(string[] Data) 

        {
            foreach (var item in Data)
            {

                string a = item;

                RunCommand(a);
            }
        }

        public void RunCommand(string arg1)
        {
            // Tạo một đối tượng ProcessStartInfo để thiết lập thông tin của quy trình
            string command = "php";
            string arguments = "artisan make:model"+arg1;

            string workingDirectory = @""+ this.Link;

            // Tạo một đối tượng ProcessStartInfo để thiết lập thông tin của quy trình
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = command;
            startInfo.Arguments = arguments;
            startInfo.UseShellExecute = false; // Sử dụng để cho biết chúng ta không muốn sử dụng Shell để chạy lệnh
            startInfo.RedirectStandardOutput = true; // Đặt để cho biết chúng ta muốn đọc đầu ra từ quy trình
            startInfo.CreateNoWindow = false; // Đặt để cho biết chúng ta không muốn tạo ra cửa sổ Command Prompt
            startInfo.WorkingDirectory = workingDirectory; // Đặt thư mục làm việc

            // Tạo một đối tượng Process để thực thi lệnh
            Process process = new Process();
            process.StartInfo = startInfo;

            // Khởi động quy trình
            process.Start();

            // Đọc đầu ra từ quy trình (kết quả của lệnh)
            string output = process.StandardOutput.ReadToEnd();

            // Hiển thị kết quả ra màn hình
            Console.WriteLine(output);

            // Chờ quy trình kết thúc
            process.WaitForExit();
        }
    }

}
