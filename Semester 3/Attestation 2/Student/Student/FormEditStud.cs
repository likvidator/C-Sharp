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
    public partial class FormEditStud : Form
    {
        public FormEditStud()
        {
            InitializeComponent();
        }

        private void FormEditStud_Activated(object sender, EventArgs e)
        {
            textBoxIdGroup.Text = Convert.ToString(FormStud.stud.idGroup);
            textBoxIdStud.Text = Convert.ToString(FormStud.stud.idStud);
            textBoxFIO.Text = FormStud.stud.fio.S.Trim();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            FormStud.stud.idGroup = Convert.ToInt32(textBoxIdGroup.Text);
            FormStud.stud.idStud = Convert.ToInt32(textBoxIdStud.Text);
            FormStud.stud.fio.S = textBoxFIO.Text;
        }
    }
}
