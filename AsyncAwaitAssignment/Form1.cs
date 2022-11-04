namespace AsyncAwaitAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        // Nathan Burns
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            lbBook1.Items.Clear();
            lbBook2.Items.Clear();

            List<Task> tasks = new List<Task>();

            var book1File = openFileDialog1.FileName;
            var book2File = openFileDialog2.FileName;

            var book1WordTask = ReadBook(book1File, lbBook1);
            var book2WordTask = ReadBook(book2File, lbBook2);
            
            tasks.Add(book1WordTask);
            tasks.Add(book2WordTask);

            await Task.WhenAll(tasks);
        }
        
        // Nathan Burns
        private async Task ReadBook(string fileName, ListBox lb)
        {
            var lines = await Task.FromResult(File.ReadAllLinesAsync(fileName));
            var arrayLinesWithoutPunctuation =
                lines.Result.Where(x => x != string.Empty)
                .AsParallel()
                .Select(x => x.ToLower().Trim()
                .Replace(",", "").Replace("'", "").Replace("{", "")
                .Replace("}", "").Replace("[", "").Replace("]", "")
                .Replace(";", "").Replace(":", "").Replace("-", ""));
            var arrayOfWords = arrayLinesWithoutPunctuation.SelectMany(x => x.Split(" "));
            Dictionary<string, int> wordDic = new Dictionary<string, int>();
            arrayOfWords.ToList().ForEach(x =>
            {
                if (wordDic.ContainsKey(x))
                {
                    wordDic[x]++;
                }
                else
                {
                    wordDic.Add(x, 1);
                }
            });

            var top10 = wordDic.Where(x => !string.IsNullOrWhiteSpace(x.Key)).OrderByDescending(x => x.Value).Take(10);
            foreach(var word in top10)
            {
                lb.Items.Add(word.Key + " - " + word.Value);
            }
        }

        private void btnBook1Browse_Click(object sender, EventArgs e)
        {
            DialogResult book1Result = this.openFileDialog1.ShowDialog();

            if (book1Result == DialogResult.OK)
            {
                tbBook1.Text = openFileDialog1.FileName.Split("\\").LastOrDefault();
            }
        }

        private void btnBook2Browse_Click(object sender, EventArgs e)
        {
            DialogResult book2Result = this.openFileDialog2.ShowDialog();

            if (book2Result == DialogResult.OK)
            {
                tbBook2.Text = openFileDialog2.FileName.Split("\\").LastOrDefault();
            }
        }
    }
}