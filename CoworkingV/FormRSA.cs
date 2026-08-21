using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoworkingV
{
    public partial class FormRSA : Form
    {
        public FormRSA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataToEncrypt = textBoxShyfr.Text;
            if (string.IsNullOrEmpty(dataToEncrypt) || string.IsNullOrWhiteSpace(dataToEncrypt))
            {
                MessageBox.Show("Введіть дані для шифрування", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    // Експортування відкритого і приватного ключів
                    string publicKey = rsa.ToXmlString(false);
                    string privateKey = rsa.ToXmlString(true);

                    richTextBox1.Text = ("Public Key: \n" + publicKey + "\n" + "\n");
                    richTextBox1.Text +=("Private Key: \n" + privateKey + "\n" + "\n");


                    string textToEncrypt = dataToEncrypt;

                    // Шифрування
                    var encryptedData = Encrypt(textToEncrypt, publicKey);
                    richTextBox1.Text += ("Encrypted Text: " + Convert.ToBase64String(encryptedData) + "\n" + "\n");

                    // Дешифрування
                    var decryptedText = Decrypt(encryptedData, privateKey);
                    richTextBox1.Text += ("Decrypted Text: " + decryptedText + "\n" + "\n");
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        // Метод для шифрування
        public static byte[] Encrypt(string dataToEncrypt, string publicKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);
                var dataToEncryptBytes = Encoding.UTF8.GetBytes(dataToEncrypt);
                return rsa.Encrypt(dataToEncryptBytes, false);
            }
        }

        // Метод для дешифрування
        public static string Decrypt(byte[] dataToDecrypt, string privateKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);
                var decryptedBytes = rsa.Decrypt(dataToDecrypt, false);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}
