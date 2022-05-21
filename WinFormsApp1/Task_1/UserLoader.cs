using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.Text.RegularExpressions;
using WinFormsApp1.Task_1;
using System.Text.Json;

namespace WinFormsApp1
{
    public partial class UserLoader : Form
    {
        public UserLoader()
        {
            InitializeComponent();
            CenterToScreen();
            dp_birthdate.Value = DateTime.Now;
            dp_birthdate.MaxDate = DateTime.Now;
        }


        public bool GoBack { get; set; } = false;
        private void button3_Click(object sender, EventArgs e)
        {
            GoBack = true;
            Close();
        }


        public bool CheckFields()
        {
            if (CName)
                if (CSurname)
                    if (CParent)
                        if (CPhone)
                            if (CCountry)
                                if (CGender)
                                    return true;

            return false;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                if (!File.Exists($"{tbx_Name.Text.ToUpper()}.json"))
                {
                    Human user = new(
                        tbx_Name.Text,
                        tbx_surname.Text,
                        tbx_parentname.Text,
                        dp_birthdate.Value,
                        mtbx_Phone.Text,
                        tbx_country.Text,
                        tbx_city.Text,
                        rbtn_male.Checked ? "Male" : "Female"
                        );
                    File.WriteAllText($"{user.Name.ToUpper()}.json", JsonSerializer.Serialize(user));
                    MessageBox.Show("Progress Succeeded ! ", "Save Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Unable to retrieve survey with the same name !\n This name already saved", "Same Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                MessageBox.Show("Please Correctly Fill All Informations!", "Save Informations", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public bool CName { get; set; } = false;
        public bool CSurname { get; set; } = false;
        public bool CParent { get; set; } = false;
        public bool CCountry { get; set; } = false;
        public bool CCity { get; set; } = false;
        public bool CPhone { get; set; } = false;
        public bool CGender { get; set; } = false;
        public bool CLoadUser { get; set; } = false;



        private void tbx_Name_TextChanged(object sender, EventArgs e)
        {
            if (tbx_Name.Text.Length > 2)

                if (new Regex("^([A-Za-z]+([ ]?[a-z]?['-]?[A-Za-z]+)*)$").IsMatch(tbx_Name.Text))
                {
                    CName = true;
                    lbl_name.ForeColor = Color.White;
                    tbx_Name.BackColor = Color.White;
                }
                else
                {
                    CName = false;
                    lbl_name.ForeColor = Color.Red;
                    tbx_Name.BackColor = Color.Red;
                }
            else
            {

                CName = false;
                lbl_name.ForeColor = Color.Red;
                tbx_Name.BackColor = Color.Red;
            }
        }

        private void tbx_surname_TextChanged(object sender, EventArgs e)
        {
            if (tbx_surname.Text.Length > 2)

                if (new Regex("^([A-Za-z]+([ ]?[a-z]?['-]?[A-Za-z]+)*)$").IsMatch(tbx_surname.Text))
                {
                    CSurname = true;
                    lbl_surname.ForeColor = Color.White;
                    tbx_surname.BackColor = Color.White;
                }
                else
                {
                    CSurname = false;
                    lbl_surname.ForeColor = Color.Red;
                    tbx_surname.BackColor = Color.Red;
                }
            else
            {

                CSurname = false;
                lbl_surname.ForeColor = Color.Red;
                tbx_surname.BackColor = Color.Red;
            }

        }

        private void tbx_parentname_TextChanged(object sender, EventArgs e)
        {
            if (tbx_parentname.Text.Length > 2)

                if (new Regex("^([A-Za-z]+([ ]?[a-z]?['-]?[A-Za-z]+)*)$").IsMatch(tbx_parentname.Text))
                {
                    CParent = true;
                    lbl_parentName.ForeColor = Color.White;
                    tbx_parentname.BackColor = Color.White;
                }
                else
                {
                    CParent = false;
                    lbl_parentName.ForeColor = Color.Red;
                    tbx_parentname.BackColor = Color.Red;
                }
            else
            {

                CParent = false;
                lbl_parentName.ForeColor = Color.Red;
                tbx_parentname.BackColor = Color.Red;
            }

        }

        private void tbx_country_TextChanged(object sender, EventArgs e)
        {
            if (tbx_country.Text.Length > 2)

                if (new Regex("^([A-Za-z]+([ ]?[a-z]?['-]?[A-Za-z]+)*)$").IsMatch(tbx_country.Text))
                {
                    CCountry = true;
                    lbl_country.ForeColor = Color.White;
                    tbx_country.BackColor = Color.White;
                }
                else
                {
                    CCountry = false;
                    lbl_country.ForeColor = Color.Red;
                    tbx_country.BackColor = Color.Red;
                }
            else
            {

                CCountry = false;
                lbl_country.ForeColor = Color.Red;
                tbx_country.BackColor = Color.Red;
            }

        }

        private void tbx_city_TextChanged(object sender, EventArgs e)
        {
            if (tbx_city.Text.Length > 2)

                if (new Regex("^([A-Za-z]+([ ]?[a-z]?['-]?[A-Za-z]+)*)$").IsMatch(tbx_city.Text))
                {
                    CCity = true;
                    lbl_city.ForeColor = Color.White;
                    tbx_city.BackColor = Color.White;
                }
                else
                {
                    CCity = false;
                    lbl_city.ForeColor = Color.Red;
                    tbx_city.BackColor = Color.Red;
                }
            else
            {

                CCity = false;
                lbl_city.ForeColor = Color.Red;
                tbx_city.BackColor = Color.Red;
            }

        }

        private void mtbx_Phone_TextChanged(object sender, EventArgs e)
        {
            string MTrim(string txt, string trimChars)
            {
                StringBuilder sb = new StringBuilder();
                txt.ToList().ForEach(delegate (Char ch)
                {
                    if (!trimChars.Contains(ch))
                        sb.Append(ch);
                });
                return sb.ToString();
            }
            if (mtbx_Phone.Text.Length > 2)

                if (new Regex("((^099|055|050|077|070|010|[1-2]|1[\\d]|3[\\d]|2[0-1])[\\d]{3}[\\d]{4})").IsMatch(MTrim(mtbx_Phone.Text, " ()-")))
                {
                    CPhone = true;
                    lbl_phone.ForeColor = Color.White;
                    mtbx_Phone.BackColor = Color.White;
                }
                else
                {
                    CPhone = false;
                    lbl_phone.ForeColor = Color.Red;
                    mtbx_Phone.BackColor = Color.Red;
                }
            else
            {

                CPhone = false;
                lbl_phone.ForeColor = Color.Red;
                mtbx_Phone.BackColor = Color.Red;
            }


        }

        private void rbtn_male_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                if (rbtn_male.Checked || rbtn_female.Checked)
                {
                    lbl_gender.ForeColor = Color.White;
                    CGender = true;
                }
                else
                {
                    lbl_gender.ForeColor = Color.Red;
                    CGender = false;
                }
            }
        }

        private void tbx_LoadUser_TextChanged(object sender, EventArgs e)
        {
            if (tbx_LoadUser.Text.Length > 2)

                if (new Regex("^([A-Za-z]+([ ]?[a-z]?['-]?[A-Za-z]+)*)$").IsMatch(tbx_LoadUser.Text))
                {
                    CLoadUser = true;
                    lbl_LoadUser.ForeColor = Color.White;
                    tbx_LoadUser.BackColor = Color.White;
                }
                else
                {
                    CLoadUser = false;
                    lbl_LoadUser.ForeColor = Color.Red;
                    tbx_LoadUser.BackColor = Color.Red;
                }
            else
            {

                CLoadUser = false;
                lbl_LoadUser.ForeColor = Color.Red;
                tbx_LoadUser.BackColor = Color.Red;
            }

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (CLoadUser)
            {
                if (File.Exists($"{tbx_LoadUser.Text.ToUpper()}.json"))
                {
                    Human? human = JsonSerializer.Deserialize<Human>(File.ReadAllText($"{tbx_LoadUser.Text.ToUpper()}.json"));
                    tbx_Name.Text = human.Name;
                    tbx_parentname.Text = human.ParentName;
                    tbx_surname.Text = human.Surname;
                    mtbx_Phone.Text = human.Phone;
                    tbx_city.Text = human.City;
                    tbx_country.Text = human.Country;
                    dp_birthdate.Value = human.BirthDate;
                    if (human.Gender == "Male")
                        rbtn_male.Select();
                    else
                        rbtn_female.Select();
                }
                else
                {
                    MessageBox.Show("User not find!", "Load Informations", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
                MessageBox.Show("Please Correctly Fill Name !", "Load Informations", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void UserLoader_Load(object sender, EventArgs e)
        {

        }
    }


}