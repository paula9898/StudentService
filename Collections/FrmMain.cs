namespace CollectionsAndArrays
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
         private void button1_Click(object sender, EventArgs e)
        {
             int[] tablica = new int[5];

            tablica[0] = 1;
            tablica[1] = 2;
            tablica[2] = 55;
            tablica[3] = 44;
            tablica[4] = 13;

            for (int i = 0; i < tablica.Length; i++)
            {
                MessageBox.Show(tablica[i].ToString());
            }

            int[] tabica2 = { 1, 5, 7, 9, 10 };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> imiona = new List<string>();

            imiona.Add("Paulina");
            imiona.Add("Mateusz");
            imiona.Add("Ania");

            foreach (var item in imiona)
            {
                MessageBox.Show(item);
            }

        }
    }
}