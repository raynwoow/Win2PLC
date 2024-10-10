using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace Win2PLC
{
    public partial class Form1 : Form
    {
        Plc PLC1200;
        string dataStr1;
        string dataStr2;
        string dataStr3;
        string dataStr4;
        string dataStr5;
        string dataStr;
        bool isMouseDown;
        bool isMouseMove;
        Point lastLocation;

        bool intvQ02;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                string ip = textBox1.Text.Trim();
                short rack = short.Parse(textBox2.Text.Trim());
                short slot = short.Parse(textBox3.Text.Trim());
                PLC1200 = new Plc(CpuType.S71200, ip, rack, slot);
                PLC1200.Open();

                if (PLC1200.IsConnected)
                {
                    MessageBox.Show("连接成功");
                    button7.Enabled = true;
                    button8.Enabled = true;
                    button2.Enabled = true;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("PLC Connect Error");
            }
            // var data = PLC1200.ReadBytes(DataType.Memory, 1, 200, 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PLC1200.IsConnected)
            {
                PLC1200.Write("DB2.DBX0.0", true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PLC1200.IsConnected)
            {
                PLC1200.Write("DB2.DBX0.0", false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }

            if (ReferenceEquals(PLC1200.IsConnected, null))
            {
                MessageBox.Show("尚未连接PLC");
            }

            if (PLC1200.IsConnected)
            {
                PLC1200.Close();
                timer1.Enabled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PLC1200.IsConnected == false)
            {
                timer1.Enabled = false;
                MessageBox.Show("已断开连接");

            }
        }



        //点动
        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            if (PLC1200.IsConnected)
            {
                PLC1200.Write("Q0.1", true);
            }
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            if (PLC1200.IsConnected)
            {
                PLC1200.Write("Q0.1", false);
            }
        }

        //取反，需要读取被控点的当前值，并将值放入全局变量中
        private void button6_Click(object sender, EventArgs e)
        {

            if (PLC1200.IsConnected)
            {
                intvQ02 = (bool)PLC1200.Read("Q0.2");

                if (intvQ02)
                {
                    PLC1200.Write("Q0.2", false);
                }
                else
                {
                    PLC1200.Write("Q0.2", true);
                }



            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "I")
            {
                button8.Enabled = false;
            }
            else
            {
                button8.Enabled = true;
            }

            if (comboBox1.Text == "DB")
            {
                textBox4.Enabled = true;
                dataStr2 = textBox4.Text + ".DB";
            }
            else
            {
                textBox4.Enabled = false;
                dataStr2 = "";
                if (comboBox2.Text == "X")
                {
                    dataStr3 = "";
                }
            }
            dataStr1 = comboBox1.Text;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "X")
            {
                textBox6.Enabled = true;
                dataStr5 = "." + textBox6.Text;
                if (comboBox1.Text == "DB")
                {
                    dataStr3 = comboBox2.Text;
                }
                else
                {
                    dataStr3 = "";
                }
            }
            else
            {
                textBox6.Enabled = false;
                dataStr3 = comboBox2.Text;
                dataStr5 = "";
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dataStr = dataStr1 + dataStr2 + dataStr3 + dataStr4 + dataStr5;
            label10.Text = dataStr;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dataStr2 = textBox4.Text + ".DB";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataStr4 = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dataStr5 = "." + textBox6.Text;
            if (textBox6.Text == "")
            {
                dataStr5 = "";

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var b1 = PLC1200.Read(dataStr);
                textBox7.Text = b1.ToString();
                checkBox1.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("读取发生错误");
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                timer3.Enabled = true;
            }
            else
            {
                timer3.Enabled = false;

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                var b1 = PLC1200.Read(dataStr);
                textBox7.Text = b1.ToString();
                checkBox1.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("读取发生错误");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Q" & comboBox2.Text == "X")
                {
                    if (textBox8.Text == "0")
                    {
                        PLC1200.Write(dataStr, false);
                    }

                    if (textBox8.Text == "1")
                    {
                        PLC1200.Write(dataStr, true);
                    }

                }
                else
                {
                    PLC1200.Write(dataStr, textBox8.Text);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("写入发生错误");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            if (isMouseMove == false)
            {
                lastLocation = e.Location;
            }

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                isMouseMove = true;
                Point newLocation = this.Location;
                newLocation.Offset(e.X - lastLocation.X, e.Y - lastLocation.Y);
                this.Location = newLocation;
                lastLocation = e.Location;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            isMouseMove = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RayWoo版权所有");
        }
    }
}