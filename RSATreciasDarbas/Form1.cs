using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;

namespace RSATreciasDarbas
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            try
            {
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    RSAParameters RSAParams = RSA.ExportParameters(true);

                    string publicKey = RSA.ToXmlString(false);
                    string privateKey = RSA.ToXmlString(true);

                    boxPublicKey.Text = publicKey;
                    boxPrivateKey.Text = privateKey;
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnEncypt_Click(object sender, EventArgs e)
        {

            if (boxTextValue.Text == String.Empty || boxPublicKey.Text == String.Empty || boxPrivateKey.Text == String.Empty)
            {
                boxOutputValue.Text = "Please provide text value and generate keys!";
            }
            else
            {
                var outputValue = Encryption(boxTextValue.Text, boxPublicKey.Text);
                boxOutputValue.Text = outputValue;
            }



        }

        private void btnDecypt_Click(object sender, EventArgs e)
        {

            if (boxTextValue.Text == String.Empty || boxPublicKey.Text == String.Empty || boxPrivateKey.Text == String.Empty)
            {
                boxOutputValue.Text = "Please provide text value and generate keys!";
            }
            else
            {
                var outputValue = Decryption(boxTextValue.Text, boxPrivateKey.Text);
                boxOutputValue.Text = outputValue;
            }


        }



        public static string Encryption(string strText, string publicKey)
        {
            var testData = Encoding.UTF8.GetBytes(strText);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    // client encrypting data with public key issued by server                    
                    rsa.FromXmlString(publicKey.ToString());

                    var encryptedData = rsa.Encrypt(testData, true);

                    var base64Encrypted = Convert.ToBase64String(encryptedData);

                    return base64Encrypted;
                }
                catch (Exception ex)
                {
                    return ex.Message.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public static string Decryption(string strText, string privateKey)
        {
            var testData = Encoding.UTF8.GetBytes(strText);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    var base64Encrypted = strText;

                    // server decrypting data with private key                    
                    rsa.FromXmlString(privateKey);

                    var resultBytes = Convert.FromBase64String(base64Encrypted);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                catch (Exception ex)
                {
                    return ex.Message.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}