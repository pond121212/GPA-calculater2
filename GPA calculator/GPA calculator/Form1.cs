namespace GPA_calculator
{
    public partial class Form1 : Form
    {
        CALCULATOR oGPAcal = new CALCULATOR();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBox1_inputGPA.Text;
            string name = this.textBoxinputGPANAME.Text;

            double dInput = Convert.ToDouble(input);
            oGPAcal.addGPA(dInput, name);

            double GPAX = oGPAcal.getGPAx();
            textBox2output.Text = GPAX.ToString();

            double max = oGPAcal.getMax();
            textBox4MAX.Text = max.ToString();
            textBox3MAXNAME.Text = oGPAcal.getMaxName().ToString();

            double min = oGPAcal.getMin();
            textBox6MIN.Text = min.ToString();
            textBox5MINNAME.Text = oGPAcal.getMinName().ToString();

            textBox1_inputGPA.Text = "";
            textBoxinputGPANAME.Text = string.Empty;
            textBox7_alldata.Text = oGPAcal.getAlldata();

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1_inputGPA.Text = "";
            textBox2output.Text = "";
            textBox3MAXNAME.Text = "";
            textBox4MAX.Text = "";
            textBox5MINNAME.Text = "";
            textBox6MIN.Text = "";
            textBox7_alldata.Text = "";
            textBoxinputGPANAME.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_alldata_TextChanged(object sender, EventArgs e)
        {

        }
    }
}