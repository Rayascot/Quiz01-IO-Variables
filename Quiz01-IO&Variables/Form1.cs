namespace Quiz01_IO_Variables
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void q2SExampleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go Jays!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("To output two decimal places use F2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4 items at 2.25 each with tax will be $10.17");
        }

        private void q01Button_Click(object sender, EventArgs e)
        {
            q1OutputLabel.Text = "Go Bears!";

        }

        private void q02Button_Click(object sender, EventArgs e)
        {
            string team;
            team = Convert.ToString(q2TextBox.Text);
            q2OutputLabel.Text = $"Go {team}!";
        }

        private void q03Button_Click(object sender, EventArgs e)
        {
            int num1, num2;
            try
            {
                num1 = Convert.ToInt16(num1Box.Text);
                num2 = Convert.ToInt16(num2Box.Text);
                q3OutputLabel.Text = $"{num1 * num2}";
            }
            catch
            {
                q3OutputLabel.Text = "enter a number";
            }
        }

        private void q04Button_Click(object sender, EventArgs e)
        {
            int costOfItem;
            int numOfItems;
            double total;
            try
            {
                numOfItems = Convert.ToInt32(noItemsBox.Text);
                costOfItem = Convert.ToInt32(costBox.Text);
                total = (numOfItems * costOfItem) * 0.13;
                total = Convert.ToDouble("F2");
                q4OutputLabel.Text = $"The amount of items {numOfItems} at a rate of {costOfItem} is {total} ";
            }catch
            {  

            }

        }
    }
}
