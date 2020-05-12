using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace Animal_IdentificationKBS
{
    public partial class Form1 : Form
    {
        string ans1, ans2, ans3, ans4, ans5, ans6, ans7, ans8, ans9, ans10, ans11, ans12, ans13, ans14, ans15, ans16, ans17, ans18, ans19, ans20, ans21, ans22, ans23, ans24, ans25, ans26, ans27, ans28, ans29, ans30, ans31, ans32, ans33, ans34, ans35, ans36, ans37, ans38, ans39, ans40, ans41, ans42, ans43, ans44;
        DataTable dt = new DataTable();
        private void Button32_Click(object sender, EventArgs e)
        {
            ans11 = "yes";

           
            
            ans12 = "no";
            ans13 = "no";
            ans14 = "no";
            ans15 = "no";
            ans16 = "no";
            ans24 = "no";
            panel11.Visible = false;
            panel17.Visible = true;
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            ans12 = "yes";
            ans13 = "no";
            ans14 = "no";
            ans15 = "no";
            panel12.Visible = false;
            panel16.Visible = true;
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            ans12 = "no";
            ans16 = "no";
            panel12.Visible = false;
            panel13.Visible = true;
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            panel12.Visible = false;
            panel11.Visible = true;
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            ans13 = "yes";
            ans14 = "no";
            ans16 = "no";
            panel13.Visible = false;
            panel15.Visible = true;
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            panel13.Visible = false;
            panel12.Visible = true;
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            ans13 = "no";
            ans15 = "no";
            ans16 = "no";
            panel13.Visible = false;
            panel14.Visible = true;
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            panel14.Visible = false;
            panel13.Visible = true;
        }

        private void Button41_Click(object sender, EventArgs e)
        {
            ans14 = "yes";
            panel14.Visible = false;
            panelDone.Visible = true;
        }

        private void Button42_Click(object sender, EventArgs e)
        {
            ans14 = "no";
            panel14.Visible = false;
            panelDone.Visible = true;
        }

        private void Button43_Click(object sender, EventArgs e)
        {
            panel15.Visible = false;
            panel13.Visible = true;
            
        }

        private void Button44_Click(object sender, EventArgs e)
        {
            ans15 = "yes";
            panel15.Visible = false;
            panelDone.Visible = true;
        }

        private void Button45_Click(object sender, EventArgs e)
        {
            ans15 = "no";
            panel15.Visible = false;
            panelDone.Visible = true;
        }

        private void Button46_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            panel12.Visible = true;
        }

        private void Button47_Click(object sender, EventArgs e)
        {
            ans16 = "yes";
            panel16.Visible = false;
            panelDone.Visible = true;
        }

        private void Button48_Click(object sender, EventArgs e)
        {
            ans16 = "no";
            panel16.Visible = false;
            panelDone.Visible = true;
        }

        private void Button49_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
            panel11.Visible = true;
        }

        private void Button50_Click(object sender, EventArgs e)
        {
            ans17 = "yes";
            ans18 = "no";
            panel17.Visible = false;
            panel19.Visible = true;
        }

        private void Button51_Click(object sender, EventArgs e)
        {
            ans17 = "no";
            ans19 = "no";
            ans20 = "no";
            ans21 = "no";
            ans22 = "no";
            ans23 = "no";
            panel17.Visible = false;
            panel18.Visible = true;
        }

        private void Button52_Click(object sender, EventArgs e)
        {
            panel18.Visible = false;
            panel17.Visible = true;
        }

        private void Button53_Click(object sender, EventArgs e)
        {
            ans18 = "yes";
            panel18.Visible = false;
            panelDone.Visible = true;
        }

        private void Button54_Click(object sender, EventArgs e)
        {
            ans18 = "no";
            panel18.Visible = false;
            panelDone.Visible = true;
        }

        private void Button55_Click(object sender, EventArgs e)
        {
            panel19.Visible = false;
            panel17.Visible = true;
        }

        private void Button56_Click(object sender, EventArgs e)
        {
            ans19 = "yes";
            ans20 = "no";
            panel19.Visible = false;
            panel21.Visible = true;
        }

        private void Button57_Click(object sender, EventArgs e)
        {
            ans19 = "no";
            ans21 = "no";
            ans22 = "no";
            ans23 = "no";
            panel19.Visible = false;
            panel20.Visible = true;
        }

        private void Button58_Click(object sender, EventArgs e)
        {
            panel20.Visible = false;
            panel19.Visible = true;
        }

        private void Button59_Click(object sender, EventArgs e)
        {
            ans20 = "yes";
            panel20.Visible = false;
            panelDone.Visible = true;
        }

        private void Button60_Click(object sender, EventArgs e)
        {
            ans20 = "no";
            panel20.Visible = false;
            panelDone.Visible = true;
        }

        private void Button61_Click(object sender, EventArgs e)
        {
            panel21.Visible = false;
            panel19.Visible = true;
        }

        private void Button62_Click(object sender, EventArgs e)
        {
            ans21 = "yes";
            ans22 = "no";
            ans23 = "no";
            panel21.Visible = false;
            panelDone.Visible = true;
        }

        private void Button63_Click(object sender, EventArgs e)
        {
            ans21 = "no";
            panel21.Visible = false;
            panel22.Visible = true;
        }

        private void Button64_Click(object sender, EventArgs e)
        {
            panel22.Visible = false;
            panel21.Visible = true;
        }

        private void Button65_Click(object sender, EventArgs e)
        {
            ans22 = "yes";
            ans23 = "no";
            panel22.Visible = false;
            panelDone.Visible = true;
        }

        private void Button66_Click(object sender, EventArgs e)
        { 
            ans22 = "no";
            panel22.Visible = false;
            panel23.Visible = true;
        }

        private void Button67_Click(object sender, EventArgs e)
        {
            panel23.Visible = false;
            panel22.Visible = true;
        }

        private void Button68_Click(object sender, EventArgs e)
        {
            ans23 = "yes";
            panel23.Visible = false;
            panelDone.Visible = true;
        }

        private void Button69_Click(object sender, EventArgs e)
        {
            ans23 = "no";
            panel23.Visible = false;
            panelDone.Visible = true;
        }

        private void Button70_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel10.Visible = true;
        }

        private void Button68_Click_1(object sender, EventArgs e)
        {
            
            ans23 = "yes";
            
            panel23.Visible = false;
            panelDone.Visible = true;
        }

        private void Button71_Click(object sender, EventArgs e)
        {
            panel24.Visible = false;
            panel10.Visible = true;
        }

        private void Button72_Click(object sender, EventArgs e)
        {
            
            
            ans24 = "yes";
            ans25 = "no";
            ans26 = "no";
            ans27 = "no";
            ans28 = "no";
            ans29 = "no";
            ans30 = "no";
            ans31 = "no";

            panel24.Visible = false;
            panelDone.Visible = true;
        }

        private void Button73_Click(object sender, EventArgs e)
        {
            ans24 = "no";
            panel24.Visible = false;
            panel25.Visible = true;
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            ans10 = "yes";

            ans3 = "no";
            ans4 = "no";
            ans5 = "no";
            ans6 = "no";
            ans7 = "no";
            ans8 = "no";
            ans11 = "no";
            ans12 = "no";
            ans13 = "no";
            ans14 = "no";
            ans15 = "no";
            ans16 = "no";
            ans17 = "no";
            ans18 = "no";
            ans19 = "no";
            ans20 = "no";
            ans21 = "no";
            ans22 = "no";
            ans23 = "no";
            panel10.Visible = false;
            panel24.Visible = true;

        }

        private void Button74_Click(object sender, EventArgs e)
        {
            panel25.Visible = false;
            panel24.Visible = true;
        }

        private void Button75_Click(object sender, EventArgs e)
        {
            ans25 = "yes";
            ans26 = "no";
            ans27 = "no";
            ans28 = "no";
            panel25.Visible = false;
            panel29.Visible = true;
        }

        private void Button76_Click(object sender, EventArgs e)
        {
            ans25 = "no";
            ans29 = "no";
            ans30 = "no";
            ans31 = "no";
            panel25.Visible = false;
            panel26.Visible = true;
        }

        private void Button77_Click(object sender, EventArgs e)
        {
            panel26.Visible = false;
            panel25.Visible = true;
        }

        private void Button78_Click(object sender, EventArgs e)
        {
            ans26 = "yes";
            ans27 = "no";
            panel26.Visible = false;
            panel28.Visible = true;
        }

        private void Button79_Click(object sender, EventArgs e)
        {
            ans26 = "no";
            ans28 = "no";
            panel26.Visible = false;
            panel27.Visible = true;
        }

        private void Button80_Click(object sender, EventArgs e)
        {
            panel27.Visible = false;
            panel26.Visible = true;
        }

        private void Button81_Click(object sender, EventArgs e)
        {
            ans27 = "yes";
            panel27.Visible = false;
            panelDone.Visible = true;
        }

        private void Button82_Click(object sender, EventArgs e)
        {
            ans27 = "no";
            panel27.Visible = false;
            panelDone.Visible = true;
        }

        private void Button83_Click(object sender, EventArgs e)
        {
            panel28.Visible = false;
            panel26.Visible = true;
        }

        private void Button84_Click(object sender, EventArgs e)
        {
            ans28 = "yes";
            panel28.Visible = false;
            panelDone.Visible = true;
        }

        private void Button85_Click(object sender, EventArgs e)
        {
            ans28 = "no";
            panel28.Visible = false;
            panelDone.Visible = true;
        }

        private void Panel28_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button86_Click(object sender, EventArgs e)
        {
            panel29.Visible = false;
            panel25.Visible = true;
        }

        private void Button87_Click(object sender, EventArgs e)
        {
            ans29 = "yes";
            ans30 = "no";
            ans31 = "no";
            panel29.Visible = false;
            panelDone.Visible = true;
        }

        private void Button88_Click(object sender, EventArgs e)
        {
            ans29 = "no";
            panel29.Visible = false;
            panel30.Visible = true;
        }

        private void Button89_Click(object sender, EventArgs e)
        {
            panel30.Visible = false;
            panel29.Visible = true;
        }

        private void Button90_Click(object sender, EventArgs e)
        {
            ans30 = "yes";
            ans31 = "no";
            panel30.Visible = false;
            panelDone.Visible = true;
        }

        private void Button91_Click(object sender, EventArgs e)
        {
            ans30 = "no";
            panel30.Visible = false;
            panel31.Visible = true;
        }

        private void Button92_Click(object sender, EventArgs e)
        {
            panel31.Visible = false;
            panel30.Visible = true;
        }

        private void Button93_Click(object sender, EventArgs e)
        {
            ans31 = "yes";
            panel31.Visible = false;
            panelDone.Visible = true;
        }

        private void Button94_Click(object sender, EventArgs e)
        {
            ans31 = "no";
            panel31.Visible = false;
            panelDone.Visible = true;
        }

        private void Button97_Click(object sender, EventArgs e)
        {
            panel32.Visible = false;
            panel1.Visible = true;
        }

        private void Button95_Click(object sender, EventArgs e)
        {
            ans32 = "yes";
            ans33 = "no";
            ans35 = "no";
            ans36 = "no";
            ans37 = "no";
            ans38 = "no";
            ans39 = "no";
            ans40 = "no";
            ans41 = "no";
            ans42 = "no";
            panel32.Visible = false;
            panel34.Visible = true;
        }

        private void Button96_Click(object sender, EventArgs e)
        {
            ans32 = "no";
            ans34 = "no";
            panel32.Visible = false;
            panel33.Visible = true;
        }

        private void Button98_Click(object sender, EventArgs e)
        {
            panel33.Visible = false;
            panel32.Visible = true;
        }

        private void Button99_Click(object sender, EventArgs e)
        {
            ans33 = "yes";
            ans35 = "no";
            ans36 = "no";
            ans37 = "no";
            ans38 = "no";
            ans39 = "no";
            ans40 = "no";
            panel33.Visible = false;
            panel41.Visible = true;
        }

        private void Button100_Click(object sender, EventArgs e)
        {
            ans33 = "no";
            ans41 = "no";
            ans42 = "no";
            panel33.Visible = false;
            panel35.Visible = true;
        }

        private void Button101_Click(object sender, EventArgs e)
        {
            panel34.Visible = false;
            panel32.Visible = true;
        }

        private void Button102_Click(object sender, EventArgs e)
        {
            ans34 = "yes";
            panel34.Visible = false;
            panelDone.Visible = true;
        }

        private void Button103_Click(object sender, EventArgs e)
        {
            ans34 = "no";
            panel34.Visible = false;
            panelDone.Visible = true;
        }

        private void Button104_Click(object sender, EventArgs e)
        {
            panel35.Visible = false;
            panel33.Visible = true;
        }

        private void Button105_Click(object sender, EventArgs e)
        {
            ans35 = "yes";
            ans36 = "no";
            ans37 = "no";
            ans38 = "no";
            panel35.Visible = false;
            panel39.Visible = true;
        }

        private void Button106_Click(object sender, EventArgs e)
        {
            ans35 = "no";
            ans39 = "no";
            ans40 = "no";
            panel35.Visible = false;
            panel36.Visible = true;
        }

        private void Button107_Click(object sender, EventArgs e)
        {
            panel36.Visible = false;
            panel35.Visible = true;
        }

        private void Button108_Click(object sender, EventArgs e)
        {
            ans36 = "yes";
            panel36.Visible = false;
            panel37.Visible = true;
        }

        private void Button109_Click(object sender, EventArgs e)
        {
            ans36 = "no";
            ans37 = "no";
            ans38 = "no";
            panel36.Visible = false;
            panelDone.Visible = true;
        }

        private void Button110_Click(object sender, EventArgs e)
        {
            panel37.Visible = false;
            panel36.Visible = true;
        }

        private void Button111_Click(object sender, EventArgs e)
        {
            ans37 = "yes";
            ans38 = "no";
            panel37.Visible = false;
            panelDone.Visible = true;
        }

        private void Button112_Click(object sender, EventArgs e)
        {
            ans37 = "no";
            panel37.Visible = false;
            panel38.Visible = true;
        }

        private void Button113_Click(object sender, EventArgs e)
        {
            panel38.Visible = false;
            panel37.Visible = true;
        }

        private void Button114_Click(object sender, EventArgs e)
        {
            ans38 = "yes";
            panel38.Visible = false;
            panelDone.Visible = true;
        }

        private void Button115_Click(object sender, EventArgs e)
        {
            ans38 = "no";
            panel38.Visible = false;
            panelDone.Visible = true;
        }

        private void Button116_Click(object sender, EventArgs e)
        {
            panel39.Visible = false;
            panel35.Visible = true;
        }

        private void Button117_Click(object sender, EventArgs e)
        {
            ans39 = "yes";
            panel39.Visible = false;
            panel40.Visible = true;
        }

        private void Button118_Click(object sender, EventArgs e)
        {
            ans39 = "no";
            ans40 = "no";
            panel39.Visible = false;
            panelDone.Visible = true;
        }

        private void Button119_Click(object sender, EventArgs e)
        {
            panel40.Visible = false;
            panel39.Visible = true;
        }

        private void Button120_Click(object sender, EventArgs e)
        {
            ans40 = "yes";
            panel40.Visible = false;
            panelDone.Visible = true;
        }

        private void Button121_Click(object sender, EventArgs e)
        {
            ans40 = "no";
            panel40.Visible = false;
            panelDone.Visible = true;
        }

        private void Button122_Click(object sender, EventArgs e)
        {
            panel41.Visible = false;
            panel33.Visible = true;
        }

        private void Button123_Click(object sender, EventArgs e)
        {
            ans41 = "yes";
            panel41.Visible = false;
            panel42.Visible = true;
        }

        private void Button124_Click(object sender, EventArgs e)
        {
            ans41 = "no";
            ans42 = "no";
            panel41.Visible = false;
            panelDone.Visible = true;
        }

        private void Button125_Click(object sender, EventArgs e)
        {
            panel42.Visible = false;
            panel41.Visible = true;
        }

        private void Button126_Click(object sender, EventArgs e)
        {
            ans42 = "yes";
            panel42.Visible = false;
            panelDone.Visible = true;
        }

        private void Button127_Click(object sender, EventArgs e)
        {
            ans42 = "no";
            panel42.Visible = false;
            panelDone.Visible = true;
        }

        private void Button128_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.label47.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            
        }

        private void Button23_Click_1(object sender, EventArgs e)
        {
            ans8 = "no";
            panel8.Visible = false;
            panelDone.Visible = true;
        }

        private void Button130_Click(object sender, EventArgs e)
        {
            panelRules.Visible = false;
            
        }

        private void Button129_Click(object sender, EventArgs e)
        {
            panelRules.Visible = true;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button48_Click_1(object sender, EventArgs e)
        {
            ans16 = "no";
            panel16.Visible = false;
            panelDone.Visible = true;
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            panel10.Visible = false;
            panel9.Visible = true;
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            ans10 = "no";

            ans24 = "no";
            ans25 = "no";
            ans26 = "no";
            ans27 = "no";
            ans28 = "no";
            ans29 = "no";
            ans30 = "no";
            ans31 = "no";
            panel10.Visible = false;
            panel11.Visible = true;
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            ans11 = "no";

            ans17 = "no";
            ans18 = "no";
            ans19 = "no";
            ans20 = "no";
            ans21 = "no";
            ans22 = "no";
            ans23 = "no";

            panel11.Visible = false;
            panel12.Visible = true;
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            ans9 = "yes";
            Qu(back_bone);
            panel9.Visible = false;
            panel10.Visible = true;
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            ans9 = "no";
            ans10 = "no";
            ans11 = "no";
            ans12 = "no";
            ans13 = "no";
            ans14 = "no";
            ans15 = "no";
            ans16 = "no";
            ans17 = "no";
            ans18 = "no";
            ans19 = "no";
            ans20 = "no";
            ans21 = "no";
            ans22 = "no";
            ans23 = "no";
            ans24 = "no";
            ans25 = "no";
            ans26 = "no";
            ans27 = "no";
            ans28 = "no";
            ans29 = "no";
            ans30 = "no";
            ans31 = "no";
            Qu(back_bone);
            panel9.Visible = false;
            panelDone.Visible = true;
        }

        private void Button24_Click_1(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel2.Visible = true;
        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelResult_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            ans4 = "no";
            ans6 = "no";
            ans7 = "no";
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void Button24_Click(object sender, EventArgs e)
        {

        }
        private void fillDataGridView()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IBRAHIM\SQLEXPRESS;Initial Catalog=AnimalKBS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Animal_KBS] ;", con);
            
            dt2.Load(cmd.ExecuteReader());
           
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt2;
        }
        private void Button25_Click(object sender, EventArgs e)
        {
            panelDone.Visible = false;
            panelResult.Visible = true;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IBRAHIM\SQLEXPRESS;Initial Catalog=AnimalKBS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select animal_name,animal_photo from [dbo].[Animal_KBS] where " +
                "Q1 =  '"+ans1+"'  and " +
                "Q2 =  '"+ans2+"'  and " +
                "Q3 =  '"+ans3+"'  and " +
                "Q4 =  '"+ans4+"'  and " +
                "Q5 =  '"+ans5+"'  and " +
                "Q6 =  '"+ans6+"'  and " +
                "Q7 =  '"+ans7+"'  and " +
                "Q8 =  '"+ans8+"'  and " +
                "Q9 =  '"+ans9+"'  and " +
                "Q10 = '"+ans10+"' and " +
                "Q11 = '"+ans11+"' and " +
                "Q12 = '"+ans12+"' and " +
                "Q13 = '"+ans13+"' and " +
                "Q14 = '"+ans14+"' and " +
                "Q15 = '"+ans15+"' and " +
                "Q16 = '"+ans16+"' and " +
                "Q17 = '"+ans17+"' and " +
                "Q18 = '"+ans18+"' and " +
                "Q19 = '"+ans19+"' and " +
                "Q20 = '"+ans20+"' and " +
                "Q21 = '"+ans21+"' and " +
                "Q22 = '"+ans22+"' and " +
                "Q23 = '"+ans23+"' and " +
                "Q24 = '"+ans24+"' and " +
                "Q25 = '"+ans25+"' and " +
                "Q26 = '"+ans26+"' and " +
                "Q27 = '"+ans27+"' and " +
                "Q28 = '"+ans28+"' and " +
                "Q29 = '"+ans29+"' and " +
                "Q30 = '"+ans30+"' and " +
                "Q31 = '"+ans31+"' and " +
                "Q32 = '"+ans32+"' and " +
                "Q33 = '"+ans33+"' and " +
                "Q34 = '"+ans34+"' and " +
                "Q35 = '"+ans35+"' and " +
                "Q36 = '"+ans36+"' and " +
                "Q37 = '"+ans37+"' and " +
                "Q38 = '"+ans38+"' and " +
                "Q39 = '"+ans39+"' and " +
                "Q40 = '"+ans40+"' and " +
                "Q41 = '"+ans41+"' and " +
                "Q42 = '"+ans42+"' ;", con);
            
            dt.Load(cmd.ExecuteReader());
            textBox1.Text=cmd.CommandText;
            if (dt.Rows.Count == 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    label11.Visible = true;
                    if (row["animal_name"].ToString() == "Not animal its Human") {
                        pictureBox1.Load(row["animal_photo"].ToString());
                        label11.Text = row["animal_name"].ToString();
                        label12.Visible = false;
                    }
                    else{
                        label12.Text = row["animal_name"].ToString();
                        pictureBox1.Load(row["animal_photo"].ToString());
                    }
                }

            }
            else if (dt.Rows.Count == 2)
            {
               
                        label49.Visible = true;
                        label11.Visible = true;
                        label50.Visible = true;
                        pictureBox2.Visible = true;
                        label12.Text = dt.Rows[0][0].ToString();
                        pictureBox1.Load(dt.Rows[0][1].ToString());
                        label49.Text = dt.Rows[1][0].ToString();
                        pictureBox2.Load(dt.Rows[1][1].ToString());
                        

            }
            else if (dt.Rows.Count == 3)
            {
               
                   
                        label49.Visible = true;
                        label50.Visible = true;
                        pictureBox2.Visible = true;
                        label11.Visible = true;
                        label51.Visible = true;
                        label52.Visible = true;
                        pictureBox3.Visible = true;
                        label12.Text = dt.Rows[0][0].ToString();
                        pictureBox1.Load(dt.Rows[0][1].ToString());
                        label49.Text = dt.Rows[1][0].ToString();
                        pictureBox2.Load(dt.Rows[1][1].ToString());
                        label51.Text = dt.Rows[2][0].ToString();
                        pictureBox3.Load(dt.Rows[2][1].ToString());
                    
                

            }

            else if (dt.Rows.Count == 4)
            {
               
                        label49.Visible = true;
                        label50.Visible = true;
                        pictureBox2.Visible = true;
                        label11.Visible = true;
                        label51.Visible = true;
                        label52.Visible = true;
                        pictureBox3.Visible = true;

                        label53.Visible = true;
                        label54.Visible = true;
                        pictureBox4.Visible = true;

                        label12.Text = dt.Rows[0][0].ToString();
                        pictureBox1.Load(dt.Rows[0][1].ToString());
                        label49.Text = dt.Rows[1][0].ToString();
                        pictureBox2.Load(dt.Rows[1][1].ToString());
                        label51.Text = dt.Rows[2][0].ToString();
                        pictureBox3.Load(dt.Rows[2][1].ToString());
                        label53.Text = dt.Rows[3][0].ToString();
                        pictureBox4.Load(dt.Rows[3][1].ToString());
                        
                    
                

            }
            else
            {
                label12.Visible = false;
                label11.Visible = true;
                label11.Text = "Your answers are not suitable for finding an available animal ";
            }
            
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            ans8 = "yes";
            panel8.Visible = false;
            panelDone.Visible = true;
        }
       
        private void Button21_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            
            panel3.Visible = true;
        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button20_Click(object sender, EventArgs e)
        {
            ans7 = "no";
            panelDone.Visible = true;
            panel7.Visible = false;
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            ans7 = "yes";
            panelDone.Visible = true;
            panel7.Visible = false;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel6.Visible = true;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            ans5 = "no";
            panelDone.Visible = true;
            panel5.Visible = false;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            ans5 = "yes";
            panelDone.Visible = true;
            panel5.Visible = false;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel4.Visible = true;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            ans6 = "no";
            ans5 = "no";
            ans8 = "no";
            panel7.Visible = true;
            panel6.Visible = false;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            ans6 = "yes";
            ans5 = "no";
            ans7 = "no";
            ans8 = "no";
            panel6.Visible = false;
            panelDone.Visible = true;
            
            
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel4.Visible = true;
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            ans4 = "yes";
            ans5 = "no";
            panel4.Visible = false;
            panel6.Visible = true;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ans3 = "no";
            ans8 = "no";
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ans3 = "yes";
            ans4 = "no";
            ans5 = "no";
            ans6 = "no";
            ans7 = "no";
            panel3.Visible = false;
            panel8.Visible = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
            panel1.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ans2 = "no";
            ans9 = "no";
            ans10 = "no";
            ans11 = "no";
            ans12 = "no";
            ans13 = "no";
            ans14 = "no";
            ans15 = "no";
            ans16 = "no";
            ans17 = "no";
            ans18 = "no";
            ans19 = "no";
            ans20 = "no";
            ans21 = "no";
            ans22 = "no";
            ans23 = "no";
            ans24 = "no";
            ans25 = "no";
            ans26 = "no";
            ans27 = "no";
            ans28 = "no";
            ans29 = "no";
            ans30 = "no";
            ans31 = "no";
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ans2 = "yes";
            ans3 = "no";
            ans4 = "no";
            ans5 = "no";
            ans6 = "no";
            ans7 = "no";
            ans8 = "no";
            panel2.Visible = false;
            panel9.Visible = true;
        }

       
        
        
        private void Qu(Boolean backbone)
        {
            if (backbone) {
                ans32 = "no";
                ans33 = "no";
                ans34 = "no";
                ans35 = "no";
                ans36 = "no";
                ans37 = "no";
                ans38 = "no";
                ans39 = "no";
                ans40 = "no";
                ans41 = "no";
                ans42 = "no";
                ans43 = "no";
                ans44 = "no";
            }
            else
            {
                ans1= "no";
                ans2= "no";
                ans3= "no"; 
                ans4= "no"; 
                ans5= "no";
                ans6= "no";
                ans7= "no";
                ans8= "no";
                ans9= "no";
                ans10= "no";
                ans11= "no";
                ans12= "no";
                ans13= "no";
                ans14= "no";
                ans15= "no";
                ans16= "no";
                ans17= "no";
                ans18= "no";
                ans19= "no";
                ans20= "no";
                ans21= "no";
                ans22= "no";
                ans23= "no";
                ans24= "no";
                ans25= "no";
                ans26= "no";
                ans27= "no";
                ans28= "no";
                ans29= "no";
                ans30= "no";
                ans31= "no";
            }
            
        }

        private void Reset()
        {
            dt.Clear();

            ans1 = "";
            ans2 = "";
            ans3 = "";
            ans4 = "";
            ans5 = "";
            ans6 = "";
            ans7 = "";
            ans8 = "";
            ans9 = "";
            ans10 = "";
            ans11 = "";
            ans12 = "";
            ans13 = "";
            ans14 = "";
            ans15 = "";
            ans16 = "";
            ans17 = "";
            ans18 = "";
            ans19 = "";
            ans20 = "";
            ans21 = "";
            ans22 = "";
            ans23 = "";
            ans24 = "";
            ans25 = "";
            ans26 = "";
            ans27 = "";
            ans28 = "";
            ans29 = "";
            ans30 = "";
            ans31 = "";
            ans32 = "";
            ans33 = "";
            ans34 = "";
            ans35 = "";
            ans36 = "";
            ans37 = "";
            ans38 = "";
            ans39 = "";
            ans40 = "";
            ans41 = "";
            ans42 = "";
            label11.Visible=false;
            label12.Text = "";

            label49.Text="";
            label50.Visible = false;
            label51.Text = "";
            label52.Visible = false;
            label53.Text = "";
            label54.Visible = false;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;
            panel27.Visible = false;
            panel28.Visible = false;
            panel29.Visible = false;
            panel30.Visible = false;
            panel31.Visible = false;
            panel32.Visible = false;
            panel33.Visible = false;
            panel34.Visible = false;
            panel35.Visible = false;
            panel36.Visible = false;
            panel37.Visible = false;
            panel38.Visible = false;
            panel39.Visible = false;
            panel40.Visible = false;
            panel41.Visible = false;
            panel42.Visible = false;
            panelDone.Visible = false;
            panelResult.Visible = false;

            panel1.Visible = true;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            ans1 = "no";
            back_bone = false;
            Qu(back_bone);
            panel1.Visible = false;
            panel32.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ans1 = "yes";
            back_bone = true;
            Qu(back_bone);
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        Boolean back_bone = true;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            fillDataGridView();

            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;
            panel27.Visible = false;
            panel28.Visible = false;
            panel29.Visible = false;
            panel30.Visible = false;
            panel31.Visible = false;
            panel32.Visible = false;
            panel33.Visible = false;
            panel34.Visible = false;
            panel35.Visible = false;
            panel36.Visible = false;
            panel37.Visible = false;
            panel38.Visible = false;
            panel39.Visible = false;
            panel40.Visible = false;
            panel41.Visible = false;
            panel42.Visible = false;
            panelDone.Visible = false;
            panelResult.Visible = false;
            panelRules.Visible = false;

            label49.Visible = false;
            label50.Visible = false;
            label51.Visible = false;
            label52.Visible = false;
            label53.Visible = false;
            label54.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
