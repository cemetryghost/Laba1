namespace Laboratornaya1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка абонентов");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка профиль");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, button7.Width, button7.Height);

            Region myRegion = new Region(myPath);
            button7.Region = myRegion;

            System.Drawing.Drawing2D.GraphicsPath myPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            myPath2.AddEllipse(0, 0, button8.Width, button8.Height);

            Region myRegion2 = new Region(myPath);
            button8.Region = myRegion2;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка управления оборудованием");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка активы");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка биллинг");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка поддержка пользователей");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка CRM");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка ?");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка собрания менеджеров");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отчет об инвентаризации");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Собрание акционеров");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отчет по району");
        }
    }
}