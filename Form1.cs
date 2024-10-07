namespace math5
{
    public partial class Form1 : Form
    {
        string symList = "àáâãäå¸æçèéêëìíîïğñòóôõö÷øùúûüışÿÀÁÂÃÄÅ¨ÆÇÈÉÊËÌÍÎÏĞÑÒÓÔÕÖ×ØÙÚÛÜİŞß.,!?:;-_+=()* ";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output1.Text = encryption(Input1.Text, Int32.Parse(keyCode.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Output2.Text = decryption(Input2.Text, Int32.Parse(keyCode.Text));
        }

        private string encryption(string text, int key)
        {
            string encryptedText = "";
            for (int i = 0; i < text.Length; i++)
            {
                encryptedText += symList[(symList.IndexOf(text[i]) + key) % symList.Length];
            }
            return encryptedText;
        }

        private string decryption(string text, int key)
        {
            string decryptedText = "";
            for (int i = 0; i < text.Length; i++)
            {
                decryptedText += symList[(symList.IndexOf(text[i]) + symList.Length - key) % symList.Length];
            }
            return decryptedText;
        }
    }
}
