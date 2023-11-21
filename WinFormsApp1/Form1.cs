namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> names = new List<string>()
        {
            "Jude",
            "Liam",
            "Noah",
            "William",
            "James",
            "Oliver",
            "Benjamin",
            "Elijah",
            "Lucas",
            "Mason",
            "Logan",
            "Alexander",
            "Ethan",
            "Jacob",
            "Michael",
            "Daniel",
            "Henry",
            "Jackson",
            "Sebastian",
            "Aiden",
            "Matthew",
            "Samuel",
            "David",
            "Joseph",
            "Carter",
            "Owen",
            "Wyatt",
            "John",
            "Jack",
            "Luke",
            "Jayden",
            "Dylan",
            "Grayson",
            "Levi",
            "Isaac",
            "Gabriel",
            "Julian",
            "Mateo",
            "Anthony",
            "Jaxon",
            "Lincoln",
            "Joshua",
            "Christopher",
            "Andrew",
            "Theodore",
            "Caleb",
            "Ryan"

        };


        /// <summary>
        /// filter listbox1 by textbox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = names.Where(x => x.ToLower().Contains(textBox1.Text.ToLower())).ToList();
        }

        /// <summary>
        /// form load and set listbox1 datasource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = names;
        }

        /// <summary>
        /// textbox1 focus lost and listbox1 visible false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox1_LostFocus(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            //set selected item to textbox1
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        /// <summary>
        /// listbox1 visible true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }

        /// <summary>
        /// catch enter key and add selected item to textbox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
                //move focus to next control
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Down && listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                //change selected item to next item
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
            else if (e.KeyCode == Keys.Up && listBox1.SelectedIndex > 0)
            {
                //change selected item to previous item
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
        }
    }
}
