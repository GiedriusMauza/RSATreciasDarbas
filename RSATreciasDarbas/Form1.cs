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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            try
            {
                //Create a new RSACryptoServiceProvider object.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Export the key information to an RSAParameters object.
                    //Pass false to export the public key information or pass
                    //true to export public and private key information.
                    RSAParameters RSAParams = RSA.ExportParameters(true);

                    //Convert RSAParams to XML string
                    var xmlString = RSA.ToXmlString(false);

                    //Print the XML string
                    boxPublicKey.Text = xmlString;

                    /*                    //Convert the key components to Base64-encoded strings
                                        string modulus = Convert.ToBase64String(RSAParams.Modulus);
                                        string exponent = Convert.ToBase64String(RSAParams.Exponent);*/
                }
            }
            catch (CryptographicException ex)
            {
                //Catch this exception in case the encryption did
                //not succeed.
                Console.WriteLine(ex.Message);
            }

        }

        private void btnDecypt_Click(object sender, EventArgs e)
        {
            try
            {

                if (boxTextValue.Text == String.Empty)
                {
                    boxOutputValue.Text = "Please provide text value. String is empty!";
                }
                else
                {
                    //Create a UnicodeEncoder to convert between byte array and string.
                    UnicodeEncoding ByteConverter = new UnicodeEncoding();

                    //Create byte arrays to hold original, encrypted, and decrypted data.
                    byte[] dataToEncrypt = ByteConverter.GetBytes(boxTextValue.Text);
                    byte[] encryptedData;
                    byte[] decryptedData;

                    //Create a new instance of RSACryptoServiceProvider to generate
                    //public and private key data.
                    using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                    {

                        //Pass the data to ENCRYPT, the public key information 
                        //(using RSACryptoServiceProvider.ExportParameters(false),
                        //and a boolean flag specifying no OAEP padding.
                        encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
                        //Pass the data to DECRYPT, the private key information 
                        //(using RSACryptoServiceProvider.ExportParameters(true),
                        //and a boolean flag specifying no OAEP padding.
                        decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);

                        //Display the decrypted plaintext to the console. 
                        Console.WriteLine("Decrypted plaintext: {0}", ByteConverter.GetString(decryptedData));
                        boxOutputValue.Text = ByteConverter.GetString(decryptedData);
                    }
                }

            }
            catch (ArgumentNullException)
            {
                boxOutputValue.Text = "Encryption failed.";
            }

        }

        private void btnEncypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (boxTextValue.Text == String.Empty)
                {
                    boxOutputValue.Text = "Please provide text value. String is empty!";
                }
                else
                {
                    //Create a UnicodeEncoder to convert between byte array and string.
                    UnicodeEncoding ByteConverter = new UnicodeEncoding();

                    //Create byte arrays to hold original, encrypted, and decrypted data.
                    byte[] dataToEncrypt = ByteConverter.GetBytes("Data to Encrypt");
                    byte[] encryptedData;

                    //Create a new instance of RSACryptoServiceProvider to generate
                    //public and private key data.
                    using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                    {

                        //Pass the data to ENCRYPT, the public key information 
                        //(using RSACryptoServiceProvider.ExportParameters(false),
                        //and a boolean flag specifying no OAEP padding.
                        encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
                        boxOutputValue.Text = Convert.ToBase64String(encryptedData);

                        // Show public key
                        RSAParameters RSAParams = RSA.ExportParameters(true);

                        //Convert RSAParams to XML string
                        var xmlString = RSA.ToXmlString(false);

                        //Print the XML string
                        boxPublicKey.Text = xmlString;
                    }
                }
            }
            catch (ArgumentNullException)
            {
                boxOutputValue.Text = "Encryption failed.";
            }


        }

        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}