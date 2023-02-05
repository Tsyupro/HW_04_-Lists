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
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Не залишайте поле пустим!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Person person = new Person(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, comboBox1.Text);
                    listBox1.Items.Add(person);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person? item = listBox1.SelectedItem as Person;
            DateTime s=DateTime.Now;
            Person person = new Person("name", "namel", "UA", s, "Male");
            if (item!= null )
            {
                MessageBox.Show(item.GetInfo());
                listBox1.SelectedItem = person;
            }
            else
            {
                MessageBox.Show("Виберіть елемент з списку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}