namespace XadrezForms
{
    public partial class Form1 : Form
    {
        int linha;
        int coluna;
        int[,] mat = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
        }
        private void AcaoBotao(object sender, EventArgs e)
        {          
            linha = int.Parse(((Button)sender).Tag.ToString().Substring(0));
            coluna = int.Parse(((Button)sender).Tag.ToString().Substring(1));
            MessageBox.Show(linha.ToString() + " -- " + coluna.ToString());
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                   
            for(int i =0; i<3; i++)
            {
                string linha = " ";
                for (int j =0; j < 3; j++)
                {
                    linha += mat[i, j];
                }  
                listBox1.Items.Add(linha);
            }
        }
    }
}