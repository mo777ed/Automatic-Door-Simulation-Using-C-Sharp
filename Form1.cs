 

باستخدام  النظام . المجموعات . عام .
باستخدام  النظام . نموذج ؛
باستخدام  النظام . البيانات ؛
باستخدام  النظام . الرسم ؛
باستخدام  النظام . لينك .
باستخدام  النظام . نص ؛
باستخدام  النظام . خيوط . المهام ؛
باستخدام  النظام . نوافذ . أشكال .
باستخدام  النظام . وسائل الإعلام ؛

مساحة الاسم  Door_sensor
{
     فئة جزئية  عامة Form1 : Form 
    {
        العامة  Form1 ()
        {
            InitializeComponent () ،
        }
       
         open_door باطل ()
        {
            إذا ( pnl_right . العرض  ==  0 )
            {
                pnl_right . العرض  =  279 ؛
                

                btn_lamp . إخفاء () ؛
                لوحة 1 . BackColor  =  اللون . أخضر ؛

            }
            

        }   // هذا المرح للباب المفتوح

        باطل  close_door ()
        {
            إذا ( pnl_right . العرض  ! =  0 )
            {
          
                pnl_right . العرض  =  0 ؛
                لوحة 1 . BackColor  =  اللون . أحمر ؛



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Door_sensor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        void open_door()
        {
            if (pnl_right.Width == 0)
            {
                pnl_right.Width = 279;
                

                btn_lamp.Hide();
                panel1.BackColor = Color.Green;

            }
            

        }  // this fun for open door

        void close_door()
        {
            if (pnl_right.Width != 0)
            {
          
                pnl_right.Width = 0;
                panel1.BackColor = Color.Red;


            }
        }  // this fun for close door
        void adman()
        {
            var state = MessageBox.Show("هل ترغب في عملية اغلاق البوابة بشكل طارئ", "اغلاق ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (state == DialogResult.Yes)
            {
                panel1.Enabled = false;
            }
        }              // this for admin
        void emergences()
        {

            SoundPlayer sound = new SoundPlayer("awsan.wav");
            sound.Play();
            pnl_right.Width = 279;
            btn_lamp.Hide();
            panel1.BackColor = Color.Green;
            panel1.Enabled = false;

        }      //this for emergency
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
              

        }
        int cou = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (pnl_right.Width == 0)
            {

                open_door();
            }
            
            else
            {
                close_door();
            }

        }

        private void pnl_cont_Paint(object sender, PaintEventArgs e)
        {
            pnl_right.Width = 0;
                btn_lamp.Show();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            open_door();
           
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
           
         
        }

       

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
           

        }

        private void panel1_MouseEnter_1(object sender, EventArgs e)
        {

            open_door();
        }
            
           

        

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            close_door();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
       

        private void button7_Click(object sender, EventArgs e)
        {
            count++;

            emergences();
        }
        int count = 0;
        private void button7_Click_1(object sender, EventArgs e)
        {
            adman();
           
        }
    }
}
