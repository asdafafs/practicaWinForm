namespace practiceWinforms
{
    public partial class Form1 : Form
    {
        readonly List<(int, string, int, int)> yourCollection = [];
        public Form1()
        {
            InitializeComponent();

            yourCollection.Add((1, "Message 1", 20, 50));
            yourCollection.Add((2, "Message 2", 30, 50));
            yourCollection.Add((3, "Message 3", 25, 35));

            foreach (var item in yourCollection)
            {
                dataGridView1.Rows.Add(item.Item1, item.Item2, item.Item3, item.Item4);
            }

            UpdateMessageCount();
            UpdateByteCount();
        }

        private void UpdateMessageCount()
        {
            var messageCount = dataGridView1.Rows.Count - 1;

            //countMessages.Text = messageCount.ToString();
        }

        private void UpdateByteCount()
        {
            var byteSum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["sizeInByte"].Value != null)
                {
                    if (int.TryParse(row.Cells["sizeInByte"].Value.ToString(), out int cellValue))
                    {
                        byteSum += cellValue;
                    }
                }
            }

            //countBites.Text = byteSum.ToString();
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
