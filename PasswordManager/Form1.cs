using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        public static Form1 form = null;
        Password password;
        PIN pin;

        public Form1()
        {
            InitializeComponent();
            form = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            password = new Password();
            pin = new PIN();
            PasswordLabel.Text = password.PasswordGenerator(PasswordSlider.Value);
            PINLabel.Text = pin.PINGenerator(PINSlider.Value);
        }

        //Password Section
        private void PasswordSlider_Scroll(object sender, EventArgs e)
        {
            PasswordSliderValueLabel.Text = PasswordSlider.Value.ToString();
            //currentPasswordLength = PasswordSlider.Value;
            PasswordLabel.Text = password.PasswordGenerator(PasswordSlider.Value);
        }

        private void PasswordGenButton_Click(object sender, EventArgs e)
        {
            //currentPasswordLength = PasswordSlider.Value;
            PasswordLabel.Text = password.PasswordGenerator(PasswordSlider.Value);
        }

        private void PasswordCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordLabel.Text);
            PasswordCopied.Visible = true;
            System.Threading.Tasks.Task.Delay(3000).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() => { PasswordCopied.Visible = false; }));
            });
        }

        private void SpecialCharsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SpecialCharsCheckBox.Checked) password.AddSpecialChars();
            else password.RemoveSpecialChars();
        }

        //PIN Section
        private void PINSlider_Scroll(object sender, EventArgs e)
        {
            PINSliderValueLabel.Text = PINSlider.Value.ToString();
            PINLabel.Text = pin.PINGenerator(PINSlider.Value);
        }

        private void PINGenButton_Click(object sender, EventArgs e)
        {
            PINLabel.Text = pin.PINGenerator(PINSlider.Value);
        }

        private void PINCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PINLabel.Text);
            PINCopied.Visible = true;
            System.Threading.Tasks.Task.Delay(3000).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() => { PINCopied.Visible = false; }));
            });
        }

        //Navigation Section
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToSavePasswordsButton_Click(object sender, EventArgs e)
        {
            PasswordSection.Hide();
            PINSection.Hide();
            ToSavePasswordsButton.Hide();
            BackButton.Show();
            SavePasswordsPanel.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PasswordSection.Show();
            PINSection.Show();
            ToSavePasswordsButton.Show();
            BackButton.Hide();
            SavePasswordsPanel.Hide();
        }

        private void PINCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PINInput.ForeColor = Color.FromArgb(223, 243, 228);
            if (PINCheckBox.Checked)
            {
                PINInput.Show();
            }
            else
            {
                PINInput.Hide();
                PINInput.Text = "0";
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordInput.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordInput.UseSystemPasswordChar = true;
            }
        }

        private void ResetInputButton_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }

        private void ResetInputs()
        {
            UsernameInput.Text = null;
            PasswordInput.Text = null;
            PlatformInput.Text = null;
            PINCheckBox.Checked = false;
        }

        private void SaveInputButton_Click(object sender, EventArgs e)
        {
            if (UsernameInput.Text == "" || PasswordInput.Text == "" || PlatformInput.Text == "" || PINCheckBox.Checked)
            {
                if (UsernameInput.Text == "")
                {
                    UsernameInput.Text = "Enter your username";
                    UsernameInput.ForeColor = Color.DarkRed;
                }
                if (PasswordInput.Text == "")
                {
                    PasswordInput.UseSystemPasswordChar = false;
                    PasswordInput.Text = "Enter your password";
                    PasswordInput.ForeColor = Color.DarkRed;
                }
                if (PlatformInput.Text == "")
                {
                    PlatformInput.Text = "Enter a platform";
                    PlatformInput.ForeColor = Color.DarkRed;
                }
                if (PINCheckBox.Checked)
                {
                    if (isNumber(PINInput.Text))
                    {
                        PINInput.Text = "Your PIN must contains only numbers";
                        PINInput.ForeColor = Color.DarkRed;
                    }
                    if (PINInput.Text == "")
                    {
                        PINInput.Text = "Enter your PIN if exists";
                        PINInput.ForeColor = Color.DarkRed;
                    }
                }

            }
            else if (UsernameInput.Text != "" && PasswordInput.Text != "" && PlatformInput.Text != "" && isNumber(PINInput.Text) && UsernameInput.ForeColor != Color.DarkRed && PasswordInput.ForeColor != Color.DarkRed && PlatformInput.ForeColor != Color.DarkRed && PINInput.ForeColor != Color.DarkRed)
            {
                /*con.Open();
                string save = "INSERT INTO tbl_accounts VALUES ('" + UsernameInput.Text + "','" + PasswordInput.Text + "','" + PlatformInput.Text + "','" + PINInput.Text + "')";
                cmd = new OleDbCommand(save, con);
                cmd.ExecuteNonQuery();
                con.Close();*/
                MessageBox.Show("Your account has been saved!", "Registration Success", MessageBoxButtons.OK);
                ResetInputs();
            }
        }

        private bool isNumber(string number)
        {
            bool isNumber = int.TryParse(number, out int numericValue);
            return isNumber;
        }

        private void UsernameInput_Click(object sender, EventArgs e)
        {
            if (UsernameInput.Focus() && UsernameInput.ForeColor == Color.DarkRed)
            {
                UsernameInput.ForeColor = Color.FromArgb(223, 243, 228);
                UsernameInput.Text = null;
            }
        }

        private void PasswordInput_Click(object sender, EventArgs e)
        {
            if (PasswordInput.Focus() && PasswordInput.ForeColor == Color.DarkRed)
            {
                PasswordInput.ForeColor = Color.FromArgb(223, 243, 228);
                PasswordInput.Text = null;
                PasswordInput.UseSystemPasswordChar = true;
            }
        }

        private void PlatformInput_Click(object sender, EventArgs e)
        {
            if (PlatformInput.Focus() && PlatformInput.ForeColor == Color.DarkRed)
            {
                PlatformInput.ForeColor = Color.FromArgb(223, 243, 228);
                PlatformInput.Text = null;
            }
        }

        private void PINInput_Click(object sender, EventArgs e)
        {
            if (PINInput.Focus() && PINInput.ForeColor == Color.DarkRed)
            {
                PINInput.ForeColor = Color.FromArgb(223, 243, 228);
                PINInput.Text = null;
            }
            if (PINInput.Text == "0")
            {
                PINInput.Text = null;
            }
        }

        private void PasswordInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (PasswordInput.ForeColor == Color.DarkRed)
            {
                PasswordInput.ForeColor = Color.FromArgb(223, 243, 228);
                PasswordInput.Text = null;
                PasswordInput.UseSystemPasswordChar = true;
            }
        }

        private void PlatformInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (PlatformInput.ForeColor == Color.DarkRed)
            {
                PlatformInput.ForeColor = Color.FromArgb(223, 243, 228);
                PlatformInput.Text = null;
            }
        }

        private void UsernameInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (UsernameInput.ForeColor == Color.DarkRed)
            {
                UsernameInput.ForeColor = Color.FromArgb(223, 243, 228);
                UsernameInput.Text = null;
            }
        }

        private void PINInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (PINInput.ForeColor == Color.DarkRed)
            {
                PINInput.ForeColor = Color.FromArgb(223, 243, 228);
                PINInput.Text = null;
            }
        }
    }
}
