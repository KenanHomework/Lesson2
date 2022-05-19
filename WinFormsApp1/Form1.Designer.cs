namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbx_LoadUser = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_LoadUser = new System.Windows.Forms.TextBox();
            this.gbx_Anket = new System.Windows.Forms.GroupBox();
            this.tbx_city = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_country = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_parentname = new System.Windows.Forms.TextBox();
            this.tbx_surname = new System.Windows.Forms.TextBox();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lbl_parentName = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.gbx_LoadUser.SuspendLayout();
            this.gbx_Anket.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_LoadUser
            // 
            this.gbx_LoadUser.Controls.Add(this.button1);
            this.gbx_LoadUser.Controls.Add(this.tbx_LoadUser);
            this.gbx_LoadUser.Location = new System.Drawing.Point(12, 12);
            this.gbx_LoadUser.Name = "gbx_LoadUser";
            this.gbx_LoadUser.Size = new System.Drawing.Size(550, 47);
            this.gbx_LoadUser.TabIndex = 1;
            this.gbx_LoadUser.TabStop = false;
            this.gbx_LoadUser.Text = "Load User";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(317, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_LoadUser
            // 
            this.tbx_LoadUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_LoadUser.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_LoadUser.Location = new System.Drawing.Point(93, 16);
            this.tbx_LoadUser.Name = "tbx_LoadUser";
            this.tbx_LoadUser.PlaceholderText = "Enter Name";
            this.tbx_LoadUser.Size = new System.Drawing.Size(172, 23);
            this.tbx_LoadUser.TabIndex = 0;
            // 
            // gbx_Anket
            // 
            this.gbx_Anket.Controls.Add(this.button2);
            this.gbx_Anket.Controls.Add(this.rbtn_female);
            this.gbx_Anket.Controls.Add(this.rbtn_male);
            this.gbx_Anket.Controls.Add(this.label5);
            this.gbx_Anket.Controls.Add(this.dp_birthdate);
            this.gbx_Anket.Controls.Add(this.label4);
            this.gbx_Anket.Controls.Add(this.maskedTextBox1);
            this.gbx_Anket.Controls.Add(this.label3);
            this.gbx_Anket.Controls.Add(this.tbx_city);
            this.gbx_Anket.Controls.Add(this.label1);
            this.gbx_Anket.Controls.Add(this.tbx_country);
            this.gbx_Anket.Controls.Add(this.label2);
            this.gbx_Anket.Controls.Add(this.tbx_parentname);
            this.gbx_Anket.Controls.Add(this.tbx_surname);
            this.gbx_Anket.Controls.Add(this.tbx_Name);
            this.gbx_Anket.Controls.Add(this.lbl_parentName);
            this.gbx_Anket.Controls.Add(this.lbl_surname);
            this.gbx_Anket.Controls.Add(this.lbl_name);
            this.gbx_Anket.Location = new System.Drawing.Point(17, 69);
            this.gbx_Anket.Name = "gbx_Anket";
            this.gbx_Anket.Size = new System.Drawing.Size(545, 424);
            this.gbx_Anket.TabIndex = 2;
            this.gbx_Anket.TabStop = false;
            this.gbx_Anket.Text = "Anket";
            this.gbx_Anket.Enter += new System.EventHandler(this.gbx_Anket_Enter);
            // 
            // tbx_city
            // 
            this.tbx_city.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_city.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_city.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_city.Location = new System.Drawing.Point(246, 172);
            this.tbx_city.Name = "tbx_city";
            this.tbx_city.PlaceholderText = "Enter City";
            this.tbx_city.Size = new System.Drawing.Size(172, 23);
            this.tbx_city.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "City:";
            // 
            // tbx_country
            // 
            this.tbx_country.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_country.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_country.Location = new System.Drawing.Point(246, 141);
            this.tbx_country.Name = "tbx_country";
            this.tbx_country.PlaceholderText = "Enter Country";
            this.tbx_country.Size = new System.Drawing.Size(172, 23);
            this.tbx_country.TabIndex = 8;
            this.tbx_country.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(133, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Country:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbx_parentname
            // 
            this.tbx_parentname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_parentname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_parentname.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_parentname.Location = new System.Drawing.Point(246, 82);
            this.tbx_parentname.Name = "tbx_parentname";
            this.tbx_parentname.PlaceholderText = "Enter ParentName";
            this.tbx_parentname.Size = new System.Drawing.Size(172, 23);
            this.tbx_parentname.TabIndex = 5;
            // 
            // tbx_surname
            // 
            this.tbx_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_surname.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_surname.Location = new System.Drawing.Point(246, 51);
            this.tbx_surname.Name = "tbx_surname";
            this.tbx_surname.PlaceholderText = "Enter Surname";
            this.tbx_surname.Size = new System.Drawing.Size(172, 23);
            this.tbx_surname.TabIndex = 4;
            // 
            // tbx_Name
            // 
            this.tbx_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Name.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Name.Location = new System.Drawing.Point(246, 22);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.PlaceholderText = "Enter Name";
            this.tbx_Name.Size = new System.Drawing.Size(172, 23);
            this.tbx_Name.TabIndex = 3;
            // 
            // lbl_parentName
            // 
            this.lbl_parentName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_parentName.AutoSize = true;
            this.lbl_parentName.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_parentName.Location = new System.Drawing.Point(133, 74);
            this.lbl_parentName.Name = "lbl_parentName";
            this.lbl_parentName.Size = new System.Drawing.Size(67, 31);
            this.lbl_parentName.TabIndex = 2;
            this.lbl_parentName.Text = "Ata ad:";
            // 
            // lbl_surname
            // 
            this.lbl_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_surname.Location = new System.Drawing.Point(133, 43);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(67, 31);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Soyad:";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(133, 14);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 31);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(253, 223);
            this.maskedTextBox1.Mask = "(999) 000-000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(165, 23);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(133, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Birthdate:";
            // 
            // dp_birthdate
            // 
            this.dp_birthdate.Location = new System.Drawing.Point(246, 276);
            this.dp_birthdate.Name = "dp_birthdate";
            this.dp_birthdate.Size = new System.Drawing.Size(191, 23);
            this.dp_birthdate.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(139, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gender:";
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(252, 331);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(51, 19);
            this.rbtn_male.TabIndex = 17;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(342, 331);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(63, 19);
            this.rbtn_female.TabIndex = 18;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 536);
            this.Controls.Add(this.gbx_Anket);
            this.Controls.Add(this.gbx_LoadUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.gbx_LoadUser.ResumeLayout(false);
            this.gbx_LoadUser.PerformLayout();
            this.gbx_Anket.ResumeLayout(false);
            this.gbx_Anket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gbx_LoadUser;
        private TextBox tbx_LoadUser;
        private Button button1;
        private GroupBox gbx_Anket;
        private Label lbl_name;
        private TextBox tbx_parentname;
        private TextBox tbx_surname;
        private TextBox tbx_Name;
        private Label lbl_parentName;
        private Label lbl_surname;
        private TextBox tbx_country;
        private Label label2;
        private TextBox tbx_city;
        private Label label1;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Button button2;
        private RadioButton rbtn_female;
        private RadioButton rbtn_male;
        private Label label5;
        private DateTimePicker dp_birthdate;
    }
}