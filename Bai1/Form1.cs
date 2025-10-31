namespace PhepTinhPhanSo
{
    public partial class Form1 : Form {

        private class PhanSo {
            public int Tu;
            public int Mau;
        }

        public Form1() {
            InitializeComponent();
        }

        private int ucln(int a, int b) {
            if (b == 0) return Math.Abs(a);
            return ucln(b, a % b);
        }

        private PhanSo rutGonPhanSo(PhanSo ps) {
            int u = ucln(ps.Tu, ps.Mau);
            ps.Tu /= u;
            ps.Mau /= u;

            if (ps.Mau < 0) {
                ps.Tu *= -1;
                ps.Mau *= -1;
            }

            return ps;
        }

        private PhanSo[]? getPhanSo() {
            PhanSo phanSo1 = new PhanSo();
            PhanSo phanSo2 = new PhanSo();

            if (int.TryParse(t1.Text, out phanSo1.Tu)
                && int.TryParse(m1.Text, out phanSo1.Mau)
                && int.TryParse(t2.Text, out phanSo2.Tu)
                && int.TryParse(m2.Text, out phanSo2.Mau)) {

                if (phanSo1.Mau == 0 || phanSo2.Mau == 0) {
                    MessageBox.Show("Mẫu không thể bằng 0", "Lỗi");
                    return null;
                }
                return new PhanSo[] { rutGonPhanSo(phanSo1), rutGonPhanSo(phanSo2) };
            }

            MessageBox.Show("Tử hoặc mẫu không hợp lệ.", "Lỗi");
            return null;
        }

        private void writeAnswer(PhanSo result) {
            rutGonPhanSo(result);
            tr.Text = result.Tu.ToString();
            mr.Text = result.Mau.ToString();
        }

        private void action_plus_Click(object sender, EventArgs e) {
            PhanSo[] ps = getPhanSo();
            PhanSo result = new PhanSo();

            if (ps == null) return;

            result.Tu = ps[0].Tu * ps[1].Mau + ps[1].Tu * ps[0].Mau;
            result.Mau = ps[0].Mau * ps[1].Mau;

            writeAnswer(result);
        }

        private void action_minus_Click(object sender, EventArgs e) {
            PhanSo[] ps = getPhanSo();
            PhanSo result = new PhanSo();

            if (ps == null) return;

            result.Tu = ps[0].Tu * ps[1].Mau - ps[1].Tu * ps[0].Mau;
            result.Mau = ps[0].Mau * ps[1].Mau;

            writeAnswer(result);
        }

        private void action_multiply_Click(object sender, EventArgs e) {
            PhanSo[] ps = getPhanSo();
            PhanSo result = new PhanSo();

            if (ps == null) return;

            result.Tu = ps[0].Tu * ps[1].Tu;
            result.Mau = ps[0].Mau * ps[1].Mau;

            writeAnswer(result);
        }

        private void action_divide_Click(object sender, EventArgs e) {
            PhanSo[] ps = getPhanSo();
            PhanSo result = new PhanSo();

            if (ps == null) return;
            if (ps[1].Tu == 0) {
                MessageBox.Show("Phân số 2 không thể bằng 0 khi thực hiện phép chia.", "Lỗi");
                return;
            }

            result.Tu = ps[0].Tu * ps[1].Mau;
            result.Mau = ps[0].Mau * ps[1].Tu;

            writeAnswer(result);
        }
    }
}
