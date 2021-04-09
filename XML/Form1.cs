using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateXML_Click(object sender, EventArgs e)
        {
            try
            {
                Infomation info = new Infomation();
                info.Data1 = textBoxData1.Text;
                info.Data2 = textBoxData2.Text;
                info.Data3 = textBoxData3.Text;
                info.Data4 = textBoxData4.Text;
                info.Bool1 = checkBox1.Checked;
                SaveXML.SaveData(info, "data.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Infomation));
                FileStream read = new FileStream("data.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Infomation info = (Infomation)xs.Deserialize(read);
                textBoxData1.Text = info.Data1;
                textBoxData2.Text = info.Data2;
                textBoxData3.Text = info.Data3;
                textBoxData4.Text = info.Data4;
                checkBox1.Checked = info.Bool1;
                read.Close();
            }
        }
    }
}
