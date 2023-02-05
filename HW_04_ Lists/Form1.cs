namespace HW_04__Lists
{
    public partial class Form1 : Form
    {
        private List<Person> persons = new List<Person>();
        private int id = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text=="")
                {
                    MessageBox.Show("Не залишайте поле пустим!","Помилка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Person person = new Person(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, comboBox1.Text);
                    persons.Add(person);
                    listBox1.Items.Add($"{id},{person.Name},{person.Last_Name}");
                    id++;
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
            string name = listBox1.SelectedItem.ToString();
            string[] v = name.Split(',');
            int i = 1;
            foreach (Person s in persons)
            {
               
                if (i == Convert.ToInt32(v[0]) && s.Name == v[1])
                {
                    MessageBox.Show(s.GetAllInfo());
                }
                i++;
            }
        }
    }
}