namespace MayTinhBoTui
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        enum Actions {
            NONE, CONG, TRU, NHAN, CHIA
        }

        double currentNumber = 0;
        double pastNumber = 0;
        Actions action = Actions.NONE;
        bool newInput = false;

        private void btn_number_Click(object sender, EventArgs e) {
            if (!(sender is Button button)) return;

            string id = button.Name;
            int no = int.Parse(id.Replace("btn_", ""));

            if (newInput) {
                the_box.Clear();
                newInput = false;
            }

            the_box.Text += no.ToString();
            double.TryParse(the_box.Text, out currentNumber);

        }

        private void btn_action_Click(object sender, EventArgs e) {
            if (!(sender is Button button)) return;

            string id = button.Name;
            string actionName = id.Replace("btn_", "").ToUpper(); // cong tru nhan chia

            if (action != Actions.NONE)
                calculate();

            pastNumber = currentNumber;
            Enum.TryParse(actionName, out action);
            newInput = true;
        }

        private void btn_equal_Click(object sender, EventArgs e) {
            calculate();
            the_box.Text = pastNumber.ToString();
            action = Actions.NONE;
        }


        private void calculate() {
            switch (action) {
                case Actions.CONG:
                    pastNumber = pastNumber + currentNumber;
                    break;
                case Actions.TRU:
                    pastNumber = pastNumber - currentNumber;
                    break;
                case Actions.NHAN:
                    pastNumber = pastNumber * currentNumber;
                    break;
                case Actions.CHIA:
                    if (currentNumber == 0) {
                        MessageBox.Show("Không thể chia cho 0!");
                        return;
                    }
                    pastNumber = pastNumber / currentNumber;
                    break;

                case Actions.NONE:
                    pastNumber = currentNumber;
                    break;
            }

            currentNumber = 0;
            newInput = true;
        }

        private void btn_c_Click(object sender, EventArgs e) {
            pastNumber = 0;
            currentNumber = 0;
            action = Actions.NONE;
            newInput = false;
            the_box.Clear();
        }
    }
}
