using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashCreator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(HashType.SelectedIndex != -1)
            {
                if (Paraphrase.Text != "")
                {
                    if (HashType.Text == "MD5")
                    {
                        string non_hash = Paraphrase.Text;
                        string HASH = MD5(non_hash);
                        Result.Text = HASH;
                    }
                    else if (HashType.Text == "SHA-128")
                    {
                        string non_hash = Paraphrase.Text;
                        string HASH = Sha1(non_hash);
                        Result.Text = HASH;
                    }
                    else if (HashType.Text == "SHA-256")
                    {
                        string non_hash = Paraphrase.Text;
                        string HASH = Sha256(non_hash);
                        Result.Text = HASH;
                    }
                    else if (HashType.Text == "SHA-512")
                    {
                        string non_hash = Paraphrase.Text;
                        string HASH = Sha512(non_hash);
                        Result.Text = HASH;
                    }
                }
                else
                {
                    MessageBox.Show("Paraphrase Is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hash Type Isn't Correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        public string MD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        static string Sha256(string value)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(value));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static string Sha1(string value)
        {
            var data = Encoding.ASCII.GetBytes(value);
            var hashData = new SHA1Managed().ComputeHash(data);
            var hash = string.Empty;
            foreach (var b in hashData)
            {
                hash += b.ToString("X2");
            }
            return hash;
        }
        public static string Sha512(string value, bool l = false)
        {
            string hash = "";
            try
            {
                byte[] d = Encoding.UTF8.GetBytes(value);
                using (SHA512 a = new SHA512Managed())
                {
                    byte[] h = a.ComputeHash(d);
                    hash = BitConverter.ToString(h).Replace("-", "");
                }
                hash = (l ? hash.ToLowerInvariant() : hash);
            }
            catch
            {

            }
            return hash;
        }
    }
}
