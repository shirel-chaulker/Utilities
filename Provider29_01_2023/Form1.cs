using Utilitis;

namespace Provider29_01_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Logger logger = new Logger("LogDb");
        private void button1_Click(object sender, EventArgs e)
        {
            Logger.LogEvent("the system is finish", DateTime.Now);
           
            
        }
    }
}