using System.Collections.ObjectModel;

namespace ChonMonTheThao
{
    public partial class Form1 : Form {

        List<object> originalSubjects = new List<object>();

        public Form1() {
            InitializeComponent();
            foreach (var item in subjects.Items) {
                originalSubjects.Add(item);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_all_in_Click(object sender, EventArgs e) {
            foreach (var item in subjects.Items) {
                chosen.Items.Add(item);
            }
            subjects.Items.Clear();
        }

        private void btn_all_out_Click(object sender, EventArgs e) {
            foreach (var item in chosen.Items) {
                subjects.Items.Add(item);
            }
            chosen.Items.Clear();
        }

        private void btn_in_Click(object sender, EventArgs e) {
            object item = subjects.SelectedItem;
            if (item == null) return;

            subjects.Items.Remove(item);
            chosen.Items.Add(item);
        }

        private void btn_out_Click(object sender, EventArgs e) {
            object item = chosen.SelectedItem;
            if (item == null) return;

            chosen.Items.Remove(item);
            subjects.Items.Add(item);
        }

        private void btn_reset_Click(object sender, EventArgs e) {
            subjects.Items.Clear();
            chosen.Items.Clear();
            dt_date.Value = DateTime.Now;

            foreach (var item in originalSubjects) {
                subjects.Items.Add(item);
            }

            cb_name.Text = "";
        }

        private void btn_exc_Click(object sender, EventArgs e) {
            string[] lines = {
                cb_name.Text,
                dt_date.Text,
                "** Môn đã chọn:",
                String.Join(", ", chosen.Items.Cast<string>())
            };
            tb_result.Lines = lines;
        }
    }
}
