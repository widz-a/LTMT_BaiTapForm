namespace XepLoaiHocLuc
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_exec_Click(object sender, EventArgs e) {
            string name = input_name.Text.Trim();

            TextBox[] textboxes = { input_s1, input_s2, input_s3, input_s4, input_s5 };
            List<double> grades = new List<double>();
            
            foreach (var item in textboxes) {
                double n;
                if (double.TryParse(item.Text, out n)) {
                    grades.Add(n);
                } else {
                    MessageBox.Show("Điểm không hợp lệ: " + item.Text, "Lỗi");
                    break;
                }
            }

            // Check lại xem có đủ điểm ko (do lỗi sẽ ko thêm vô grades)!!!
            if (grades.Count != textboxes.Length) {
                return;
            }

            //Tính TBC
            double sum = 0;
            foreach (var item in grades) {
                sum += item;
            }
            double average = sum / grades.Count;
            output_tbc.Text = average.ToString();

            string xepLoai;
            if (average > 10) xepLoai = "Súc vật";
            else if (average >= 9) xepLoai = "Xuất sắc";
            else if (average >= 8) xepLoai = "Giỏi";
            else if (average >= 7) xepLoai = "Khá";
            else if (average >= 5) xepLoai = "Trung bình";
            else if (average >= 4) xepLoai = "Yếu";
            else xepLoai = "Yếu";

            output_info.Text = $"{name}\r\nXếp loại: {xepLoai}";
        }
    }
}
