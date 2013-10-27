using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class FormEditGroup : Form
    {
        DateTime d;
        public FormEditGroup()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormGroup.group.id = Convert.ToInt32( textBoxID.Text);
            FormGroup.group.name.S = textBoxName.Text;
            FormGroup.group.year = (UInt16)dateTimePicker1.Value.Year;
            FormGroup.group.month = (UInt16)dateTimePicker1.Value.Month;
            FormGroup.group.day = (UInt16)dateTimePicker1.Value.Day;
        }

        private void FormEditGroup_Activated(object sender, EventArgs e)
        {
            textBoxID.Text = Convert.ToString( FormGroup.group.id);
            textBoxName.Text = FormGroup.group.name.S.Trim();
            d = new DateTime(FormGroup.group.year, FormGroup.group.month, FormGroup.group.day);
            dateTimePicker1.Value = d;
        }
    }
}
