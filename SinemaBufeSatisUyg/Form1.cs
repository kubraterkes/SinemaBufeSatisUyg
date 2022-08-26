namespace SinemaBufeSatisUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  
        int kasatutar = 0;       
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);

            toplam = misir * 4 + bilet * 8 + su * 1 + cay * 2;
            LblToplam.Text = toplam.ToString();

        }

      
    }
}