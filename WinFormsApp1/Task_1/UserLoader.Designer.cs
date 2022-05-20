namespace WinFormsApp1
{
    partial class UserLoader
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.tbx_LoadUser = new System.Windows.Forms.TextBox();
            this.gbx_Anket = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.dp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_bithdate = new System.Windows.Forms.Label();
            this.mtbx_Phone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.tbx_city = new System.Windows.Forms.TextBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.tbx_country = new System.Windows.Forms.TextBox();
            this.lbl_country = new System.Windows.Forms.Label();
            this.tbx_parentname = new System.Windows.Forms.TextBox();
            this.tbx_surname = new System.Windows.Forms.TextBox();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lbl_parentName = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_LoadUser = new System.Windows.Forms.Label();
            this.gbx_LoadUser.SuspendLayout();
            this.gbx_Anket.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_LoadUser
            // 
            this.gbx_LoadUser.BackColor = System.Drawing.Color.Transparent;
            this.gbx_LoadUser.Controls.Add(this.lbl_LoadUser);
            this.gbx_LoadUser.Controls.Add(this.btn_Load);
            this.gbx_LoadUser.Controls.Add(this.tbx_LoadUser);
            this.gbx_LoadUser.ForeColor = System.Drawing.Color.White;
            this.gbx_LoadUser.Location = new System.Drawing.Point(14, 16);
            this.gbx_LoadUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_LoadUser.Name = "gbx_LoadUser";
            this.gbx_LoadUser.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_LoadUser.Size = new System.Drawing.Size(629, 63);
            this.gbx_LoadUser.TabIndex = 1;
            this.gbx_LoadUser.TabStop = false;
            this.gbx_LoadUser.Text = "Load User";
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.Transparent;
            this.btn_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Font = new System.Drawing.Font("Agency FB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Load.Location = new System.Drawing.Point(418, 24);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(86, 31);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // tbx_LoadUser
            // 
            this.tbx_LoadUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_LoadUser.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_LoadUser.Location = new System.Drawing.Point(162, 24);
            this.tbx_LoadUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_LoadUser.Name = "tbx_LoadUser";
            this.tbx_LoadUser.PlaceholderText = "Enter Name";
            this.tbx_LoadUser.Size = new System.Drawing.Size(197, 29);
            this.tbx_LoadUser.TabIndex = 0;
            this.tbx_LoadUser.TextChanged += new System.EventHandler(this.tbx_LoadUser_TextChanged);
            // 
            // gbx_Anket
            // 
            this.gbx_Anket.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Anket.Controls.Add(this.btn_Save);
            this.gbx_Anket.Controls.Add(this.rbtn_female);
            this.gbx_Anket.Controls.Add(this.rbtn_male);
            this.gbx_Anket.Controls.Add(this.lbl_gender);
            this.gbx_Anket.Controls.Add(this.dp_birthdate);
            this.gbx_Anket.Controls.Add(this.lbl_bithdate);
            this.gbx_Anket.Controls.Add(this.mtbx_Phone);
            this.gbx_Anket.Controls.Add(this.lbl_phone);
            this.gbx_Anket.Controls.Add(this.tbx_city);
            this.gbx_Anket.Controls.Add(this.lbl_city);
            this.gbx_Anket.Controls.Add(this.tbx_country);
            this.gbx_Anket.Controls.Add(this.lbl_country);
            this.gbx_Anket.Controls.Add(this.tbx_parentname);
            this.gbx_Anket.Controls.Add(this.tbx_surname);
            this.gbx_Anket.Controls.Add(this.tbx_Name);
            this.gbx_Anket.Controls.Add(this.lbl_parentName);
            this.gbx_Anket.Controls.Add(this.lbl_surname);
            this.gbx_Anket.Controls.Add(this.lbl_name);
            this.gbx_Anket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_Anket.ForeColor = System.Drawing.Color.White;
            this.gbx_Anket.Location = new System.Drawing.Point(19, 92);
            this.gbx_Anket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_Anket.Name = "gbx_Anket";
            this.gbx_Anket.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_Anket.Size = new System.Drawing.Size(623, 565);
            this.gbx_Anket.TabIndex = 2;
            this.gbx_Anket.TabStop = false;
            this.gbx_Anket.Text = "Anket";
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Agency FB", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(241, 512);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(169, 31);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(391, 441);
            this.rbtn_female.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(78, 24);
            this.rbtn_female.TabIndex = 10;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            this.rbtn_female.CheckedChanged += new System.EventHandler(this.rbtn_male_CheckedChanged);
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(288, 441);
            this.rbtn_male.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(63, 24);
            this.rbtn_male.TabIndex = 9;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            this.rbtn_male.CheckedChanged += new System.EventHandler(this.rbtn_male_CheckedChanged);
            // 
            // lbl_gender
            // 
            this.lbl_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_gender.Location = new System.Drawing.Point(159, 425);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(87, 36);
            this.lbl_gender.TabIndex = 16;
            this.lbl_gender.Text = "Gender:";
            // 
            // dp_birthdate
            // 
            this.dp_birthdate.Location = new System.Drawing.Point(281, 368);
            this.dp_birthdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dp_birthdate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dp_birthdate.Name = "dp_birthdate";
            this.dp_birthdate.Size = new System.Drawing.Size(236, 27);
            this.dp_birthdate.TabIndex = 8;
            // 
            // lbl_bithdate
            // 
            this.lbl_bithdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_bithdate.AutoSize = true;
            this.lbl_bithdate.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bithdate.ForeColor = System.Drawing.Color.White;
            this.lbl_bithdate.Location = new System.Drawing.Point(152, 357);
            this.lbl_bithdate.Name = "lbl_bithdate";
            this.lbl_bithdate.Size = new System.Drawing.Size(104, 36);
            this.lbl_bithdate.TabIndex = 14;
            this.lbl_bithdate.Text = "Birthdate:";
            // 
            // mtbx_Phone
            // 
            this.mtbx_Phone.Location = new System.Drawing.Point(289, 297);
            this.mtbx_Phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbx_Phone.Mask = "(999) 000-00-00";
            this.mtbx_Phone.Name = "mtbx_Phone";
            this.mtbx_Phone.Size = new System.Drawing.Size(188, 27);
            this.mtbx_Phone.TabIndex = 7;
            this.mtbx_Phone.TextChanged += new System.EventHandler(this.mtbx_Phone_TextChanged);
            // 
            // lbl_phone
            // 
            this.lbl_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_phone.ForeColor = System.Drawing.Color.White;
            this.lbl_phone.Location = new System.Drawing.Point(152, 288);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(77, 36);
            this.lbl_phone.TabIndex = 11;
            this.lbl_phone.Text = "Phone:";
            // 
            // tbx_city
            // 
            this.tbx_city.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_city.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_city.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_city.Location = new System.Drawing.Point(281, 229);
            this.tbx_city.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_city.Name = "tbx_city";
            this.tbx_city.PlaceholderText = "Enter City";
            this.tbx_city.Size = new System.Drawing.Size(197, 29);
            this.tbx_city.TabIndex = 6;
            this.tbx_city.TextChanged += new System.EventHandler(this.tbx_city_TextChanged);
            // 
            // lbl_city
            // 
            this.lbl_city.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_city.ForeColor = System.Drawing.Color.White;
            this.lbl_city.Location = new System.Drawing.Point(152, 219);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(55, 36);
            this.lbl_city.TabIndex = 9;
            this.lbl_city.Text = "City:";
            // 
            // tbx_country
            // 
            this.tbx_country.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_country.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_country.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_country.Location = new System.Drawing.Point(281, 188);
            this.tbx_country.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_country.Name = "tbx_country";
            this.tbx_country.PlaceholderText = "Enter Country";
            this.tbx_country.Size = new System.Drawing.Size(197, 29);
            this.tbx_country.TabIndex = 5;
            this.tbx_country.TextChanged += new System.EventHandler(this.tbx_country_TextChanged);
            // 
            // lbl_country
            // 
            this.lbl_country.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_country.ForeColor = System.Drawing.Color.White;
            this.lbl_country.Location = new System.Drawing.Point(152, 177);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(93, 36);
            this.lbl_country.TabIndex = 7;
            this.lbl_country.Text = "Country:";
            // 
            // tbx_parentname
            // 
            this.tbx_parentname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_parentname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_parentname.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_parentname.Location = new System.Drawing.Point(281, 109);
            this.tbx_parentname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_parentname.Name = "tbx_parentname";
            this.tbx_parentname.PlaceholderText = "Enter ParentName";
            this.tbx_parentname.Size = new System.Drawing.Size(197, 29);
            this.tbx_parentname.TabIndex = 4;
            this.tbx_parentname.TextChanged += new System.EventHandler(this.tbx_parentname_TextChanged);
            // 
            // tbx_surname
            // 
            this.tbx_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_surname.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_surname.Location = new System.Drawing.Point(281, 68);
            this.tbx_surname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_surname.Name = "tbx_surname";
            this.tbx_surname.PlaceholderText = "Enter Surname";
            this.tbx_surname.Size = new System.Drawing.Size(197, 29);
            this.tbx_surname.TabIndex = 3;
            this.tbx_surname.TextChanged += new System.EventHandler(this.tbx_surname_TextChanged);
            // 
            // tbx_Name
            // 
            this.tbx_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Name.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Name.Location = new System.Drawing.Point(281, 29);
            this.tbx_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.PlaceholderText = "Enter Name";
            this.tbx_Name.Size = new System.Drawing.Size(197, 29);
            this.tbx_Name.TabIndex = 2;
            this.tbx_Name.TextChanged += new System.EventHandler(this.tbx_Name_TextChanged);
            // 
            // lbl_parentName
            // 
            this.lbl_parentName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_parentName.AutoSize = true;
            this.lbl_parentName.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_parentName.ForeColor = System.Drawing.Color.White;
            this.lbl_parentName.Location = new System.Drawing.Point(152, 99);
            this.lbl_parentName.Name = "lbl_parentName";
            this.lbl_parentName.Size = new System.Drawing.Size(76, 36);
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
            this.lbl_surname.ForeColor = System.Drawing.Color.White;
            this.lbl_surname.Location = new System.Drawing.Point(152, 57);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(77, 36);
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
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(152, 19);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(42, 36);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Ad:";
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = true;
            this.btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Agency FB", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 671);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(45, 30);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_LoadUser
            // 
            this.lbl_LoadUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_LoadUser.AutoSize = true;
            this.lbl_LoadUser.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_LoadUser.ForeColor = System.Drawing.Color.White;
            this.lbl_LoadUser.Location = new System.Drawing.Point(93, 17);
            this.lbl_LoadUser.Name = "lbl_LoadUser";
            this.lbl_LoadUser.Size = new System.Drawing.Size(42, 36);
            this.lbl_LoadUser.TabIndex = 17;
            this.lbl_LoadUser.Text = "Ad:";
            // 
            // UserLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.UserLoader_Backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 735);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.gbx_Anket);
            this.Controls.Add(this.gbx_LoadUser);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserLoader";
            this.Text = "Form1";
            this.gbx_LoadUser.ResumeLayout(false);
            this.gbx_LoadUser.PerformLayout();
            this.gbx_Anket.ResumeLayout(false);
            this.gbx_Anket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox gbx_LoadUser;
        private TextBox tbx_LoadUser;
        private Button btn_Load;
        private GroupBox gbx_Anket;
        private Label lbl_name;
        private TextBox tbx_parentname;
        private TextBox tbx_surname;
        private TextBox tbx_Name;
        private Label lbl_parentName;
        private Label lbl_surname;
        private TextBox tbx_country;
        private Label lbl_country;
        private TextBox tbx_city;
        private Label lbl_city;
        private Label lbl_bithdate;
        private MaskedTextBox mtbx_Phone;
        private Label lbl_phone;
        private Button btn_Save;
        private RadioButton rbtn_female;
        private RadioButton rbtn_male;
        private Label lbl_gender;
        private DateTimePicker dp_birthdate;
        private Button btn_back;
        private Label lbl_LoadUser;
    }
}