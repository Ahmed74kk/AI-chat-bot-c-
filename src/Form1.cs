using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4U_BOT
{
    public partial class Form1 : Form
    {
        // اسمك
        string k0 = "اسمك";
        string k01 = "أسمك";
        string k02 = "إسمك";

        // ايه
        string k1 = "ايه";
        string k10 = "إيه";
        string k11 = "أيه";

        // عايز
        string m0 = "عايز";
        string m1 = "عاوز";

        // يسطا

        string z0 = "يسطا";

        // حاجة

        string d0 = "حاجة";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text.Contains(k0) == true && textBox1.Text.Contains(k1) == true) || (textBox1.Text.Contains(k01) == true && textBox1.Text.Contains(k1) == true) || (textBox1.Text.Contains(k02) == true && textBox1.Text.Contains(k1) == true))
            {
                Random r = new Random();
                int rInt = r.Next(0, 8);

                if(rInt == 0)
                {
                    textBox2.Text = "فور يو بوت يزميلي";
                }
                else if(rInt == 1)
                {
                    textBox2.Text = "4U Bot يبرو";
                }
                else if (rInt == 2)
                {
                    textBox2.Text = "فور يو بوت, ليك شوق في حاجة؟";
                }
                else if (rInt == 3)
                {
                    textBox2.Text = "فور يو بوت ارتحت؟";
                }
                else if (rInt == 4)
                {
                    textBox2.Text = "ام السوال الهقعد اتسئل فيه كل شوية.";
                }
                else if (rInt == 5)
                {
                    textBox2.Text = "عاوز ايه يعني بردو ما قولنا فور يو بوت";
                }
                else if (rInt == 6)
                {
                    textBox2.Text = "بهجت صابر اكس تو يلا";
                }
                else if (rInt == 7)
                {
                    textBox2.Text = "فور يو بوت يصحبي";
                }
                else if (rInt == 8)
                {
                    textBox2.Text = "اسمي فور يو بوت يسطا";
                }
                
            }
            else if(textBox1.Text == z0 || textBox1.Text.Contains(z0) == true)
            {
                Random r = new Random();
                int rInt = r.Next(0, 4);

                if (rInt == 0)
                {
                    textBox2.Text = "انجز يبني بلاش تجلطني";
                }
                else if (rInt == 1)
                {
                    textBox2.Text = "عاوز ايه من امي";
                }
                else if (rInt == 2)
                {
                    textBox2.Text = "نعم يا بيه";
                }
                else if (rInt == 3)
                {
                    textBox2.Text = "تمام وبعدين";
                }
                else if (rInt == 4)
                {
                    textBox2.Text = "بطل ب*ان.";
                }
            }
            else if((textBox1.Text.Contains(m0) == true  && textBox1.Text.Contains(d0)) == true || (textBox1.Text.Contains(m1) == true && textBox1.Text.Contains(d0) == true))
            {
                Random r = new Random();
                int rInt = r.Next(0, 4);

                if (rInt == 0)
                {
                    textBox2.Text = "عايز ايه يسطا";
                }
                else if (rInt == 1)
                {
                    textBox2.Text = "ماتقول يعم دغري";
                }
                else if (rInt == 2)
                {
                    textBox2.Text = "قول يسطا";
                }
                else if (rInt == 3)
                {
                    textBox2.Text = "اتفضل يمعلم";
                }
                else if (rInt == 4)
                {
                    textBox2.Text = "قول الحاجة يعم";
                }
            }
            else
            {
                Random r = new Random();
                int rInt = r.Next(0, 10);

                if (rInt == 0)
                {
                    textBox2.Text = "قول كلام غير كدا يسطا";
                }
                else if (rInt == 1)
                {
                    textBox2.Text = "ما توضح كلامك سيكا؟";
                }
                else if (rInt == 2)
                {
                    textBox2.Text = "شكلك بتشتم وانا مش فاهمك بس هتغلط هنغلط يبو الصحاب";
                }
                else if (rInt == 3)
                {
                    textBox2.Text = "يسطا كلامك مش مفهوش خالص";
                }
                else if (rInt == 4)
                {
                    textBox2.Text = "دا فرانكو صيني مش فاهم الكلام يعم";
                }
                else if (rInt == 5)
                {
                    textBox2.Text = "مش فاهمك يزميلي";
                }
                else if (rInt == 6)
                {
                    textBox2.Text = "مش فاهمك يبرو";
                }
                else if (rInt == 7)
                {
                    textBox2.Text = "الكلام طالع منك مش سالك ومش عارف افهموا وضح";
                }
                else if (rInt == 8)
                {
                    textBox2.Text = "وضح شوية يسطا";
                }
                else if (rInt == 9)
                {
                    textBox2.Text = "مش فاهم حاجة";
                }
                else if (rInt == 10)
                {
                    textBox2.Text = "بقولك ايه ماتيجي سكة ودغري وتقول عاوز ايه";
                }
            }
        }
        internal bool HasArabicCharacters(string text)
        {

            Regex regex = new Regex(

              "^[\u0600-\u06FF]+$");

            return regex.IsMatch(text);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
