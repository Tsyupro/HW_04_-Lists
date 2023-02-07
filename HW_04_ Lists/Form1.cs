namespace HW_04__Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("�� ��������� ���� ������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Add(new Person(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, comboBox1.Text));
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Person? item = listBox1.SelectedItem as Person;
            if (item != null)
            {
                MessageBox.Show(item.GetInfo());
            }
            else
            {
                MessageBox.Show("������� ������� � ������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("������� �������!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}