namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movies = { "The Simpson", "Rick and Morty", "Squid Game", "Venom" };
            moviesCheckBoxList.Items.AddRange(movies);

            moviesCheckBoxList.CheckOnClick = true;
        }

        private void moviesLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var movies in moviesCheckBoxList.Items)
            {


                bool isSelected = moviesCheckBoxList.GetItemChecked(moviesCheckBoxList.Items.IndexOf(movies));
                if (isSelected && !moviesListBox.Items.Contains(movies))
                {
                    moviesListBox.Items.Add(movies);

                }
            }
        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (moviesListBox.Items.Count >= 1)
            {
                moviesListBox.Items.Remove(moviesListBox.SelectedItem);
            }
        }

        private void clearallBtn_Click(object sender, EventArgs e)
        {
            moviesListBox.Items.Clear();
        }

        private void moviesCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
