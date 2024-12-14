namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "Bitmap file|*.bmp|JPEG file|*.jpg";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                Form2 frm = new Form2(oFile.FileName);
                frm.MdiParent = this;
                frm.Show();
            }
        }



        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/mm/yy hh:mm:ss");
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tileVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
