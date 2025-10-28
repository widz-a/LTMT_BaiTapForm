namespace MangSoNguyen
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        List<int> list = new List<int>();

        private void btn_execute_Click(object sender, EventArgs e) {
            list.Clear();

            foreach (var item in input.Text.Split(' ')) { //[1, 2, 3]
                int i;
                if (int.TryParse(item, out i)) {
                    list.Add(i);
                } else {
                    MessageBox.Show("Số không hợp lệ: " + item, "Lỗi");
                    return;
                }
            }

            // Sort
            if (rdb_sort_down.Checked || rdb_sort_up.Checked) {
                list.Sort();
                if (rdb_sort_down.Checked) list.Reverse();
            }

            // Xóa
            int removeNo;
            if (rdb_remove_value.Checked && int.TryParse(input_remove_value.Text, out removeNo)) {
                list.Remove(removeNo);
            }
            if (rdb_remove_index.Checked && int.TryParse(input_remove_index.Text, out removeNo)) {
                if (removeNo < list.Count) list.RemoveAt(removeNo);
            }

            // Thêm
            int addIndex, addValue;
            if (rdb_add.Checked && int.TryParse(input_add_index.Text, out addIndex)
                && int.TryParse(input_add_value.Text, out addValue)) {
                list.Insert(addIndex, addValue);
            }

            //Thay thế
            int replaceNo, inputReplace;
            if (int.TryParse(input_replace.Text, out inputReplace)) {
                if (rdb_replace_value.Checked && int.TryParse(input_replace_value.Text, out replaceNo)) {
                    for (int i = 0; i < list.Count; i++) {
                        if (list[i] == replaceNo) list[i] = inputReplace;
                    }
                }

                if (rdb_replace_index.Checked && int.TryParse(input_replace_index.Text, out replaceNo)) {
                    if (replaceNo < list.Count)
                        list[replaceNo] = inputReplace;

                }
            }

            // Output
            output.Text = string.Join(" ", list.ToArray());

            // Tìm kiếm
            int searchNo;
            if (rdb_search_value.Checked && int.TryParse(input_search_value.Text, out searchNo)) {
                if (list.Contains(searchNo)) {
                    MessageBox.Show("Tìm thấy " + searchNo + " trong mảng", "Kết quả tìm kiếm");

                } else {
                    MessageBox.Show("Không tìm thấy " + searchNo + " trong mảng", "Kết quả tìm kiếm");
                }
            }

            if (rdb_search_index.Checked && int.TryParse(input_search_index.Text, out searchNo)) {
                if (searchNo >= list.Count) {
                    output_search.Text = "";
                    return;
                }
                output_search.Text = list[searchNo].ToString();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e) {
            list.Clear();
            input.Text = "";
            output.Text = "";
            rdb_sort_up.Checked = false;
            rdb_sort_down.Checked = false;

            rdb_search_value.Checked = false;
            rdb_search_index.Checked = false;
            input_search_index.Text = "";
            input_search_value.Text = "";
            output_search.Text = "";

            rdb_remove_index.Checked = false;
            rdb_remove_value.Checked = false;
            input_remove_index.Text = "";
            input_remove_value.Text = "";

            rdb_add.Checked = false;
            input_add_index.Text = "";
            input_add_value.Text = "";

            output_sum.Text = "";
            output_even.Text = "";
            output_odd.Text = "";

            output_max.Text = "";
            output_min.Text = "";

            rdb_replace_value.Checked = false;
            rdb_replace_index.Checked = false;
            input_replace_index.Text = "";
            input_replace_value.Text = "";
            input_replace.Text = "";
        }

        private void btn_sum_Click(object sender, EventArgs e) {
            int sum = 0, sum_even = 0;
            foreach (var i in list) {
                sum += i;
                if (i % 2 == 0) sum_even += i;
            }
            output_sum.Text = sum.ToString();
            output_even.Text = sum_even.ToString();
            output_odd.Text = (sum - sum_even).ToString();
        }

        private void btn_min_max_find_Click(object sender, EventArgs e) {
            int min = list[0], max = list[0];
            foreach (var i in list) {
                if (i < min) min = i;
                if (i > max) max = i;
            }

            output_min.Text = min.ToString();
            output_max.Text = max.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
