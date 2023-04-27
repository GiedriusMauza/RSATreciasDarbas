using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RSATreciasDarbas
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEncrypt_Click(object sender, EventArgs ea)
        {

            if (textBoxP.Text == String.Empty || textBoxP.Text == String.Empty)
            {
                textBoxOutput.Text = "Please provide P and/or Q value and generate keys!";
            }
            else
            {
                // https://www.cs.utexas.edu/~mitra/honors/soln.html
                // https://www.tutorialspoint.com/how-is-rsa-algorithm-calculated

                // Įvesti pirminius skaičius p ir q
                // Choose p = 3 and q = 11

                BigInteger p = BigInteger.Parse(textBoxP.Text);
                BigInteger q = BigInteger.Parse(textBoxQ.Text);

                // Įvesti pradinį skaičių x
                BigInteger x = BigInteger.Parse(textBoxInput.Text);


                // Šifravimo algoritmui reikalingų parametrų radimas
                //Compute n = p * q = 3 * 11 = 33
                // Compute φ(n) = (p - 1) * (q - 1) = 2 * 10 = 20
                BigInteger n = p * q;
                BigInteger phi = (p - 1) * (q - 1);

                // Viešojo rakto radimas
                // Public key is (e, n) => (7, 33)
                BigInteger e = GetPublicKey(phi);
                textPublicKey.Text = e.ToString();

                // Privačiojo rakto radimas
                // Private key is (d, n) => (3, 33)
                BigInteger d = GetPrivateKey(e, phi);
                textBoxPrivateKey.Text = d.ToString();

                // Šifravimas
                // The encryption of m = 2 is c = 27 % 33 = 29
                BigInteger encrypted = Encrypt(x, e, n);


                textBoxOutput.Text = encrypted.ToString();

                /*                Console.WriteLine($"Šifruotas tekstas: {encrypted}");
                                Console.WriteLine($"Atšifruotas tekstas: {decrypted}");*/

            }



        }

        private void buttonDecrypt_Click(object sender, EventArgs ea)
        {

            if (textBoxP.Text == String.Empty || textBoxP.Text == String.Empty)
            {
                textBoxOutput.Text = "Please provide P and/or Q value and generate keys!";
            }
            else
            {
                // https://www.cs.utexas.edu/~mitra/honors/soln.html
                // https://www.tutorialspoint.com/how-is-rsa-algorithm-calculated

                // Įvesti pirminius skaičius p ir q
                // Choose p = 3 and q = 11

                BigInteger p = BigInteger.Parse(textBoxP.Text);
                BigInteger q = BigInteger.Parse(textBoxQ.Text);

                /*                // Įvesti pradinį skaičių x
                                BigInteger x = BigInteger.Parse(textBoxInput.Text);*/


                // Šifravimo algoritmui reikalingų parametrų radimas
                //Compute n = p * q = 3 * 11 = 33
                // Compute φ(n) = (p - 1) * (q - 1) = 2 * 10 = 20
                BigInteger n = p * q;
                /*                BigInteger phi = (p - 1) * (q - 1);*/

                // Viešojo rakto radimas
                // Public key is (e, n) => (7, 33)
                BigInteger e = BigInteger.Parse(textPublicKey.Text);


                // Privačiojo rakto radimas
                // Private key is (d, n) => (3, 33)
                BigInteger d = BigInteger.Parse(textBoxPrivateKey.Text);

                // Šifravimas
                // The encryption of m = 2 is c = 27 % 33 = 29
                BigInteger encrypted = BigInteger.Parse(textBoxOutput.Text);

                // Dešifravimas
                // The decryption of c = 29 is m = 293 % 33 = 2
                BigInteger decrypted = Decrypt(encrypted, d, n);

                textBoxDecrypted.Text = decrypted.ToString();

            }

        }


        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            WriteToFile(textPublicKey.Text, textBoxOutput.Text);

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            var input = textBoxFilePath.Text.Trim();
            JsonDataObject fileValues = ParseJson(input);
            textPublicKey.Text = fileValues.Key;
            textBoxOutput.Text = fileValues.Encypted;

        }


        static BigInteger GetPublicKey(BigInteger phi)
        {
            //Choose e such that 1 < e < φ(n) and e and φ (n) are coprime. Let e = 7
            BigInteger e = 2;

            while (e < phi)
            {
                if (IsCoprime(e, phi))
                {
                    break;
                }

                e++;
            }

            return e;
        }

        static BigInteger GetPrivateKey(BigInteger e, BigInteger phi)
        {
            // Compute a value for d such that (d * e) % φ(n) = 1. One solution is d = 3 [(3 * 7) % 20 = 1]
            BigInteger d = 0;

            while (d < phi)
            {
                if ((e * d) % phi == 1)
                {
                    break;
                }

                d++;
            }

            return d;
        }

        static bool IsCoprime(BigInteger a, BigInteger b)
        {
            BigInteger gcd = GCD(a, b);

            return gcd == 1;
        }

        static BigInteger Encrypt(BigInteger x, BigInteger e, BigInteger n)
        {
            // The encryption of m = 2 is c = 27 % 33 = 29
            return BigInteger.ModPow(x, e, n);
        }

        static BigInteger Decrypt(BigInteger encrypted, BigInteger d, BigInteger n)
        {
            // The decryption of c = 29 is m = 293 % 33 = 2
            return BigInteger.ModPow(encrypted, d, n);
        }


        // Euklido algoritmas
        static BigInteger GCD(BigInteger a, BigInteger b)
        {
            if (a == 0)
                return b;

            return GCD(b % a, a);
        }

        // išplėstinis Euklido algoritmas
        public static int gcdExtended(int a, int b,
                                      int x, int y)
        {
            // Base Case
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            // To store results of
            // recursive call
            int x1 = 1, y1 = 1;
            int gcd = gcdExtended(b % a, a, x1, y1);

            // Update x and y using
            // results of recursive call
            x = y1 - (b / a) * x1;
            y = x1;

            return gcd;
        }

        static void WriteToFile(string key, string encypted)
        {
            //Create my object
            JsonDataObject myData = new JsonDataObject()
            {
                Key = key,
                Encypted = encypted
            };

            //Tranform it to Json object
            string jsonData = JsonConvert.SerializeObject(myData);

            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Write the specified text asynchronously to a new file
            var file = DateTime.Now.Ticks + ".json";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, file)))
            {
                outputFile.Write(jsonData);
            }
        }

        static JsonDataObject ParseJson(string filePath)
        {
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filename = Path.Combine(filePath);
            if (File.Exists(filename))
            {
                var text = File.ReadAllText(filename);


                //Parse the json object
                var values = JsonArray.Parse(text);
                //Print the parsed Json object
                Console.WriteLine("Key: {0}", values["Key"]);
                Console.WriteLine("Encrypted Text: {0}", values["Encypted"]);
                //Create my object
                JsonDataObject jsonData = new JsonDataObject()
                {
                    Key = (string)values["Key"],
                    Encypted = (string)values["Encypted"]
                };
                return jsonData;
            }
            return null;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    public class JsonDataObject
    {
        public string? Key;
        public string? Encypted;
    }
}
