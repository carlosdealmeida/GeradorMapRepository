namespace GeradorMapRepository
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ofd1.Multiselect = false;
            this.ofd1.Title = "Selecionar Fotos";
            ofd1.InitialDirectory = @"C:\Users\macoratti\Pictures";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Class C# (*.cs)|*.cs";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;
            ofd1.FileName = "";

            DialogResult dr = this.ofd1.ShowDialog();
            int i = 0;
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd1.FileNames)
                {
                    var lines = File.ReadAllLines(arquivo);
                    foreach (var line in lines)
                    {
                        if (line.Contains("{ get; set; }"))
                        {
                            i = i + 1;
                            var varSplit = line.Trim().Split(" ");
                            string[] row = { i.ToString(), "", "", varSplit[3], "", "" };
                            dataGridView1.Rows.Add(row);
                        }
                    }
                }
            }
        }
    }
}