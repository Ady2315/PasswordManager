namespace PasswordManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PasswordSection = new System.Windows.Forms.Panel();
            this.PasswordCopied = new System.Windows.Forms.Label();
            this.SpecialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordGenButton = new System.Windows.Forms.Button();
            this.PasswordCopyButton = new System.Windows.Forms.Button();
            this.PasswordSliderPanel = new System.Windows.Forms.Panel();
            this.PasswordSliderValueLabel = new System.Windows.Forms.Label();
            this.PasswordSlider = new System.Windows.Forms.TrackBar();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordWordLabel = new System.Windows.Forms.Label();
            this.NavSection = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.ToSavePasswordsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PINSection = new System.Windows.Forms.Panel();
            this.PINCopied = new System.Windows.Forms.Label();
            this.PINGenButton = new System.Windows.Forms.Button();
            this.PINCopyButton = new System.Windows.Forms.Button();
            this.PINSliderPanel = new System.Windows.Forms.Panel();
            this.PINSlider = new System.Windows.Forms.TrackBar();
            this.PINSliderValueLabel = new System.Windows.Forms.Label();
            this.PINPanel = new System.Windows.Forms.Panel();
            this.PINLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SavePasswordsPanel = new System.Windows.Forms.Panel();
            this.SaveInputButton = new System.Windows.Forms.Button();
            this.ResetInputButton = new System.Windows.Forms.Button();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PlatformInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PINCheckBox = new System.Windows.Forms.CheckBox();
            this.PINInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernamePanel = new System.Windows.Forms.Panel();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordSection.SuspendLayout();
            this.PasswordSliderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordSlider)).BeginInit();
            this.PasswordPanel.SuspendLayout();
            this.NavSection.SuspendLayout();
            this.PINSection.SuspendLayout();
            this.PINSliderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PINSlider)).BeginInit();
            this.PINPanel.SuspendLayout();
            this.SavePasswordsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UsernamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordSection
            // 
            this.PasswordSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.PasswordSection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PasswordSection.Controls.Add(this.PasswordCopied);
            this.PasswordSection.Controls.Add(this.SpecialCharsCheckBox);
            this.PasswordSection.Controls.Add(this.PasswordGenButton);
            this.PasswordSection.Controls.Add(this.PasswordCopyButton);
            this.PasswordSection.Controls.Add(this.PasswordSliderPanel);
            this.PasswordSection.Controls.Add(this.PasswordPanel);
            this.PasswordSection.Controls.Add(this.PasswordWordLabel);
            this.PasswordSection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordSection.Location = new System.Drawing.Point(12, 12);
            this.PasswordSection.Name = "PasswordSection";
            this.PasswordSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordSection.Size = new System.Drawing.Size(527, 531);
            this.PasswordSection.TabIndex = 0;
            // 
            // PasswordCopied
            // 
            this.PasswordCopied.BackColor = System.Drawing.Color.Transparent;
            this.PasswordCopied.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasswordCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordCopied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(214)))), ((int)(((byte)(225)))));
            this.PasswordCopied.Location = new System.Drawing.Point(355, 331);
            this.PasswordCopied.Name = "PasswordCopied";
            this.PasswordCopied.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordCopied.Size = new System.Drawing.Size(140, 51);
            this.PasswordCopied.TabIndex = 20;
            this.PasswordCopied.Text = "Copied!";
            this.PasswordCopied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PasswordCopied.Visible = false;
            // 
            // SpecialCharsCheckBox
            // 
            this.SpecialCharsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SpecialCharsCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SpecialCharsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpecialCharsCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.SpecialCharsCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(123)))), ((int)(((byte)(236)))));
            this.SpecialCharsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpecialCharsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialCharsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.SpecialCharsCheckBox.Location = new System.Drawing.Point(30, 336);
            this.SpecialCharsCheckBox.Name = "SpecialCharsCheckBox";
            this.SpecialCharsCheckBox.Size = new System.Drawing.Size(238, 41);
            this.SpecialCharsCheckBox.TabIndex = 0;
            this.SpecialCharsCheckBox.Text = "SPECIAL CHARACTERS";
            this.SpecialCharsCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SpecialCharsCheckBox.UseVisualStyleBackColor = true;
            this.SpecialCharsCheckBox.CheckedChanged += new System.EventHandler(this.SpecialCharsCheckBox_CheckedChanged);
            // 
            // PasswordGenButton
            // 
            this.PasswordGenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PasswordGenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(48)))), ((int)(((byte)(176)))));
            this.PasswordGenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(32)))), ((int)(((byte)(128)))));
            this.PasswordGenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordGenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordGenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PasswordGenButton.Location = new System.Drawing.Point(30, 394);
            this.PasswordGenButton.Name = "PasswordGenButton";
            this.PasswordGenButton.Size = new System.Drawing.Size(465, 57);
            this.PasswordGenButton.TabIndex = 7;
            this.PasswordGenButton.Text = "GENERATE";
            this.PasswordGenButton.UseVisualStyleBackColor = true;
            this.PasswordGenButton.Click += new System.EventHandler(this.PasswordGenButton_Click);
            // 
            // PasswordCopyButton
            // 
            this.PasswordCopyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PasswordCopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(214)))), ((int)(((byte)(225)))));
            this.PasswordCopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(187)))));
            this.PasswordCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PasswordCopyButton.Location = new System.Drawing.Point(30, 457);
            this.PasswordCopyButton.Name = "PasswordCopyButton";
            this.PasswordCopyButton.Size = new System.Drawing.Size(465, 57);
            this.PasswordCopyButton.TabIndex = 5;
            this.PasswordCopyButton.Text = "COPY";
            this.PasswordCopyButton.UseVisualStyleBackColor = true;
            this.PasswordCopyButton.Click += new System.EventHandler(this.PasswordCopyButton_Click);
            // 
            // PasswordSliderPanel
            // 
            this.PasswordSliderPanel.Controls.Add(this.PasswordSliderValueLabel);
            this.PasswordSliderPanel.Controls.Add(this.PasswordSlider);
            this.PasswordSliderPanel.Location = new System.Drawing.Point(30, 262);
            this.PasswordSliderPanel.Name = "PasswordSliderPanel";
            this.PasswordSliderPanel.Size = new System.Drawing.Size(465, 53);
            this.PasswordSliderPanel.TabIndex = 4;
            // 
            // PasswordSliderValueLabel
            // 
            this.PasswordSliderValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.PasswordSliderValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PasswordSliderValueLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PasswordSliderValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordSliderValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordSliderValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PasswordSliderValueLabel.Location = new System.Drawing.Point(0, 0);
            this.PasswordSliderValueLabel.Name = "PasswordSliderValueLabel";
            this.PasswordSliderValueLabel.Size = new System.Drawing.Size(60, 53);
            this.PasswordSliderValueLabel.TabIndex = 4;
            this.PasswordSliderValueLabel.Text = "15";
            this.PasswordSliderValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordSlider
            // 
            this.PasswordSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.PasswordSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordSlider.Dock = System.Windows.Forms.DockStyle.Right;
            this.PasswordSlider.LargeChange = 2;
            this.PasswordSlider.Location = new System.Drawing.Point(60, 0);
            this.PasswordSlider.Maximum = 20;
            this.PasswordSlider.Minimum = 8;
            this.PasswordSlider.Name = "PasswordSlider";
            this.PasswordSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordSlider.Size = new System.Drawing.Size(405, 53);
            this.PasswordSlider.TabIndex = 3;
            this.PasswordSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.PasswordSlider.Value = 15;
            this.PasswordSlider.Scroll += new System.EventHandler(this.PasswordSlider_Scroll);
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Controls.Add(this.PasswordLabel);
            this.PasswordPanel.Location = new System.Drawing.Point(30, 132);
            this.PasswordPanel.Margin = new System.Windows.Forms.Padding(30, 50, 30, 30);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(465, 97);
            this.PasswordPanel.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.PasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PasswordLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PasswordLabel.Location = new System.Drawing.Point(0, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordLabel.Size = new System.Drawing.Size(465, 97);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordWordLabel
            // 
            this.PasswordWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordWordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PasswordWordLabel.Location = new System.Drawing.Point(-1, 0);
            this.PasswordWordLabel.Name = "PasswordWordLabel";
            this.PasswordWordLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.PasswordWordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordWordLabel.Size = new System.Drawing.Size(527, 132);
            this.PasswordWordLabel.TabIndex = 0;
            this.PasswordWordLabel.Text = "PASSWORD";
            this.PasswordWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NavSection
            // 
            this.NavSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.NavSection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NavSection.Controls.Add(this.BackButton);
            this.NavSection.Controls.Add(this.ToSavePasswordsButton);
            this.NavSection.Controls.Add(this.ExitButton);
            this.NavSection.Location = new System.Drawing.Point(12, 549);
            this.NavSection.Name = "NavSection";
            this.NavSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NavSection.Size = new System.Drawing.Size(1060, 100);
            this.NavSection.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.BackButton.Location = new System.Drawing.Point(30, 19);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(122, 57);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ToSavePasswordsButton
            // 
            this.ToSavePasswordsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.ToSavePasswordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToSavePasswordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToSavePasswordsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.ToSavePasswordsButton.Location = new System.Drawing.Point(377, 19);
            this.ToSavePasswordsButton.Name = "ToSavePasswordsButton";
            this.ToSavePasswordsButton.Size = new System.Drawing.Size(305, 57);
            this.ToSavePasswordsButton.TabIndex = 10;
            this.ToSavePasswordsButton.Text = "SAVE PASSWORDS";
            this.ToSavePasswordsButton.UseVisualStyleBackColor = true;
            this.ToSavePasswordsButton.Click += new System.EventHandler(this.ToSavePasswordsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.ExitButton.Location = new System.Drawing.Point(910, 19);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(118, 57);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "QUIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PINSection
            // 
            this.PINSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.PINSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PINSection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PINSection.Controls.Add(this.PINCopied);
            this.PINSection.Controls.Add(this.PINGenButton);
            this.PINSection.Controls.Add(this.PINCopyButton);
            this.PINSection.Controls.Add(this.PINSliderPanel);
            this.PINSection.Controls.Add(this.PINPanel);
            this.PINSection.Controls.Add(this.label1);
            this.PINSection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PINSection.Location = new System.Drawing.Point(545, 12);
            this.PINSection.Name = "PINSection";
            this.PINSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PINSection.Size = new System.Drawing.Size(527, 531);
            this.PINSection.TabIndex = 2;
            // 
            // PINCopied
            // 
            this.PINCopied.BackColor = System.Drawing.Color.Transparent;
            this.PINCopied.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PINCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINCopied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(214)))), ((int)(((byte)(225)))));
            this.PINCopied.Location = new System.Drawing.Point(355, 331);
            this.PINCopied.Name = "PINCopied";
            this.PINCopied.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PINCopied.Size = new System.Drawing.Size(140, 51);
            this.PINCopied.TabIndex = 21;
            this.PINCopied.Text = "Copied!";
            this.PINCopied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PINCopied.Visible = false;
            // 
            // PINGenButton
            // 
            this.PINGenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PINGenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(48)))), ((int)(((byte)(176)))));
            this.PINGenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(32)))), ((int)(((byte)(128)))));
            this.PINGenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PINGenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINGenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PINGenButton.Location = new System.Drawing.Point(30, 394);
            this.PINGenButton.Name = "PINGenButton";
            this.PINGenButton.Size = new System.Drawing.Size(465, 57);
            this.PINGenButton.TabIndex = 8;
            this.PINGenButton.Text = "GENERATE";
            this.PINGenButton.UseVisualStyleBackColor = true;
            this.PINGenButton.Click += new System.EventHandler(this.PINGenButton_Click);
            // 
            // PINCopyButton
            // 
            this.PINCopyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PINCopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(214)))), ((int)(((byte)(225)))));
            this.PINCopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(151)))), ((int)(((byte)(187)))));
            this.PINCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PINCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PINCopyButton.Location = new System.Drawing.Point(30, 457);
            this.PINCopyButton.Name = "PINCopyButton";
            this.PINCopyButton.Size = new System.Drawing.Size(465, 57);
            this.PINCopyButton.TabIndex = 6;
            this.PINCopyButton.Text = "COPY";
            this.PINCopyButton.UseVisualStyleBackColor = true;
            this.PINCopyButton.Click += new System.EventHandler(this.PINCopyButton_Click);
            // 
            // PINSliderPanel
            // 
            this.PINSliderPanel.Controls.Add(this.PINSlider);
            this.PINSliderPanel.Controls.Add(this.PINSliderValueLabel);
            this.PINSliderPanel.Location = new System.Drawing.Point(30, 262);
            this.PINSliderPanel.Name = "PINSliderPanel";
            this.PINSliderPanel.Size = new System.Drawing.Size(465, 53);
            this.PINSliderPanel.TabIndex = 5;
            // 
            // PINSlider
            // 
            this.PINSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.PINSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PINSlider.Dock = System.Windows.Forms.DockStyle.Right;
            this.PINSlider.LargeChange = 2;
            this.PINSlider.Location = new System.Drawing.Point(60, 0);
            this.PINSlider.Maximum = 15;
            this.PINSlider.Minimum = 4;
            this.PINSlider.Name = "PINSlider";
            this.PINSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PINSlider.Size = new System.Drawing.Size(405, 53);
            this.PINSlider.TabIndex = 3;
            this.PINSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.PINSlider.Value = 4;
            this.PINSlider.Scroll += new System.EventHandler(this.PINSlider_Scroll);
            // 
            // PINSliderValueLabel
            // 
            this.PINSliderValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.PINSliderValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PINSliderValueLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PINSliderValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PINSliderValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINSliderValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PINSliderValueLabel.Location = new System.Drawing.Point(0, 0);
            this.PINSliderValueLabel.Name = "PINSliderValueLabel";
            this.PINSliderValueLabel.Size = new System.Drawing.Size(60, 53);
            this.PINSliderValueLabel.TabIndex = 6;
            this.PINSliderValueLabel.Text = "4";
            this.PINSliderValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PINPanel
            // 
            this.PINPanel.Controls.Add(this.PINLabel);
            this.PINPanel.Location = new System.Drawing.Point(30, 131);
            this.PINPanel.Margin = new System.Windows.Forms.Padding(30, 50, 30, 30);
            this.PINPanel.Name = "PINPanel";
            this.PINPanel.Size = new System.Drawing.Size(465, 97);
            this.PINPanel.TabIndex = 3;
            // 
            // PINLabel
            // 
            this.PINLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.PINLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PINLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PINLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PINLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PINLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PINLabel.Location = new System.Drawing.Point(0, 0);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PINLabel.Size = new System.Drawing.Size(465, 97);
            this.PINLabel.TabIndex = 3;
            this.PINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(527, 132);
            this.label1.TabIndex = 1;
            this.label1.Text = "PIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavePasswordsPanel
            // 
            this.SavePasswordsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.SavePasswordsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SavePasswordsPanel.Controls.Add(this.SaveInputButton);
            this.SavePasswordsPanel.Controls.Add(this.ResetInputButton);
            this.SavePasswordsPanel.Controls.Add(this.ShowPasswordCheckBox);
            this.SavePasswordsPanel.Controls.Add(this.panel3);
            this.SavePasswordsPanel.Controls.Add(this.panel2);
            this.SavePasswordsPanel.Controls.Add(this.panel1);
            this.SavePasswordsPanel.Controls.Add(this.UsernamePanel);
            this.SavePasswordsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.SavePasswordsPanel.Location = new System.Drawing.Point(12, 12);
            this.SavePasswordsPanel.Name = "SavePasswordsPanel";
            this.SavePasswordsPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SavePasswordsPanel.Size = new System.Drawing.Size(1060, 529);
            this.SavePasswordsPanel.TabIndex = 0;
            this.SavePasswordsPanel.Visible = false;
            // 
            // SaveInputButton
            // 
            this.SaveInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveInputButton.Location = new System.Drawing.Point(565, 450);
            this.SaveInputButton.Name = "SaveInputButton";
            this.SaveInputButton.Size = new System.Drawing.Size(193, 57);
            this.SaveInputButton.TabIndex = 5;
            this.SaveInputButton.Text = "Save";
            this.SaveInputButton.UseVisualStyleBackColor = true;
            this.SaveInputButton.Click += new System.EventHandler(this.SaveInputButton_Click);
            // 
            // ResetInputButton
            // 
            this.ResetInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetInputButton.Location = new System.Drawing.Point(304, 450);
            this.ResetInputButton.Name = "ResetInputButton";
            this.ResetInputButton.Size = new System.Drawing.Size(193, 57);
            this.ResetInputButton.TabIndex = 6;
            this.ResetInputButton.Text = "Reset";
            this.ResetInputButton.UseVisualStyleBackColor = true;
            this.ResetInputButton.Click += new System.EventHandler(this.ResetInputButton_Click);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowPasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(845, 472);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(188, 35);
            this.ShowPasswordCheckBox.TabIndex = 7;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PlatformInput);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(32, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 57);
            this.panel3.TabIndex = 3;
            // 
            // PlatformInput
            // 
            this.PlatformInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.PlatformInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.PlatformInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PlatformInput.Location = new System.Drawing.Point(199, 0);
            this.PlatformInput.Name = "PlatformInput";
            this.PlatformInput.Size = new System.Drawing.Size(712, 53);
            this.PlatformInput.TabIndex = 3;
            this.PlatformInput.Click += new System.EventHandler(this.PlatformInput_Click);
            this.PlatformInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlatformInput_KeyUp);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 57);
            this.label4.TabIndex = 10;
            this.label4.Text = "Platform:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PINCheckBox);
            this.panel2.Controls.Add(this.PINInput);
            this.panel2.Location = new System.Drawing.Point(32, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 57);
            this.panel2.TabIndex = 2;
            // 
            // PINCheckBox
            // 
            this.PINCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PINCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PINCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PINCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PINCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINCheckBox.Location = new System.Drawing.Point(0, 0);
            this.PINCheckBox.Name = "PINCheckBox";
            this.PINCheckBox.Size = new System.Drawing.Size(193, 57);
            this.PINCheckBox.TabIndex = 100;
            this.PINCheckBox.TabStop = false;
            this.PINCheckBox.Text = "PIN?";
            this.PINCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PINCheckBox.UseVisualStyleBackColor = true;
            this.PINCheckBox.CheckedChanged += new System.EventHandler(this.PINCheckBox_CheckedChanged);
            // 
            // PINInput
            // 
            this.PINInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.PINInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.PINInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PINInput.Location = new System.Drawing.Point(199, 0);
            this.PINInput.Name = "PINInput";
            this.PINInput.Size = new System.Drawing.Size(712, 53);
            this.PINInput.TabIndex = 4;
            this.PINInput.Text = "0";
            this.PINInput.Visible = false;
            this.PINInput.Click += new System.EventHandler(this.PINInput_Click);
            this.PINInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PINInput_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PasswordInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(32, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 57);
            this.panel1.TabIndex = 2;
            // 
            // PasswordInput
            // 
            this.PasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.PasswordInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.PasswordInput.Location = new System.Drawing.Point(199, 0);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(712, 53);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.UseSystemPasswordChar = true;
            this.PasswordInput.Click += new System.EventHandler(this.PasswordInput_Click);
            this.PasswordInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordInput_KeyUp);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 57);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernamePanel
            // 
            this.UsernamePanel.Controls.Add(this.UsernameInput);
            this.UsernamePanel.Controls.Add(this.label2);
            this.UsernamePanel.Location = new System.Drawing.Point(32, 34);
            this.UsernamePanel.Name = "UsernamePanel";
            this.UsernamePanel.Size = new System.Drawing.Size(911, 57);
            this.UsernamePanel.TabIndex = 0;
            // 
            // UsernameInput
            // 
            this.UsernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.UsernameInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.UsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.UsernameInput.Location = new System.Drawing.Point(199, 0);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(712, 53);
            this.UsernameInput.TabIndex = 1;
            this.UsernameInput.Click += new System.EventHandler(this.UsernameInput_Click);
            this.UsernameInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UsernameInput_KeyUp);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 57);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.PINSection);
            this.Controls.Add(this.NavSection);
            this.Controls.Add(this.PasswordSection);
            this.Controls.Add(this.SavePasswordsPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(197)))), ((int)(((byte)(240)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PasswordSection.ResumeLayout(false);
            this.PasswordSliderPanel.ResumeLayout(false);
            this.PasswordSliderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordSlider)).EndInit();
            this.PasswordPanel.ResumeLayout(false);
            this.NavSection.ResumeLayout(false);
            this.PINSection.ResumeLayout(false);
            this.PINSliderPanel.ResumeLayout(false);
            this.PINSliderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PINSlider)).EndInit();
            this.PINPanel.ResumeLayout(false);
            this.SavePasswordsPanel.ResumeLayout(false);
            this.SavePasswordsPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UsernamePanel.ResumeLayout(false);
            this.UsernamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PasswordSection;
        private System.Windows.Forms.Panel NavSection;
        private System.Windows.Forms.Panel PINSection;
        private System.Windows.Forms.Label PasswordWordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Panel PasswordSliderPanel;
        private System.Windows.Forms.Label PasswordSliderValueLabel;
        private System.Windows.Forms.TrackBar PasswordSlider;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Panel PINPanel;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.Panel PINSliderPanel;
        private System.Windows.Forms.TrackBar PINSlider;
        private System.Windows.Forms.Label PINSliderValueLabel;
        private System.Windows.Forms.CheckBox SpecialCharsCheckBox;
        private System.Windows.Forms.Button PasswordGenButton;
        private System.Windows.Forms.Button PasswordCopyButton;
        private System.Windows.Forms.Button PINGenButton;
        private System.Windows.Forms.Button PINCopyButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label PasswordCopied;
        private System.Windows.Forms.Button ToSavePasswordsButton;
        private System.Windows.Forms.Label PINCopied;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel UsernamePanel;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SavePasswordsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox PINCheckBox;
        private System.Windows.Forms.TextBox PINInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PlatformInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Button SaveInputButton;
        private System.Windows.Forms.Button ResetInputButton;
    }
}

