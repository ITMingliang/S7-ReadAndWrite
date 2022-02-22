using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S71200_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Plc S71200;//声明一个类型为PLC的内部变量

        //读数据
        private void bt_Read_Click(object sender, EventArgs e)
        {
            //浮点
            if (comboxType.Text == "Real")
            {
                double MyPlcData = Convert.ToDouble(((uint)S71200.Read("DB" + tbDB.Text + "." + "DBD" + tbStart.Text)));
                MessageBox.Show(MyPlcData.ToString());
            }
            //整数
            else if (comboxType.Text == "Int")
            {
                short MyPlcData = ((ushort)S71200.Read("DB" + tbDB.Text + "." + "DBW" + tbStart.Text)).ConvertToShort();
                MessageBox.Show(MyPlcData.ToString());
            }
            //双整数
            else if (comboxType.Text == "DInt")
            {
                int MyPlcData = ((uint)S71200.Read("DB" + tbDB.Text + "." + "DBD" + tbStart.Text)).ConvertToInt();
                MessageBox.Show(MyPlcData.ToString());
            }

        }

        //连接
        private void bt_Connect_Click(object sender, EventArgs e)
        {
            //创建连接对象
            S71200 = new Plc(CpuType.S71200, tbIP.Text, Convert.ToInt16(tbRack.Text), Convert.ToInt16(tbSlot.Text));
            S71200.Open();
        }

        //断开
        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            S71200.Close();
        }

        //写
        private void bt_Write_Click(object sender, EventArgs e)
        {
            //浮点
            if (comboxType.Text == "Real")
            {
                double MyData = Convert.ToDouble(tbWrite.Text);
                S71200.Write("DB" + tbDB.Text + "." + "DBD" + tbStart.Text, (int)MyData);

            }
            //整数
            else if (comboxType.Text == "Int")
            {
                short MyData = Convert.ToInt16(tbWrite.Text);
                S71200.Write("DB" + tbDB.Text + "." + "DBW" + tbStart.Text, MyData.ConvertToUshort());
            }
            //双整数
            else if (comboxType.Text == "DInt")
            {
                int myData = Convert.ToInt32(tbWrite.Text);
                S71200.Write("DB" + tbDB.Text + "." + "DBD" + tbStart.Text, myData);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboxType.Items.Clear();   
            comboxType.Items.Add("Int");
            comboxType.Items.Add("DInt");
            comboxType.Items.Add("Real");
            comboxType.Text = "Real";

            comboxType.SelectedIndex = 0;
        }
    }
}
