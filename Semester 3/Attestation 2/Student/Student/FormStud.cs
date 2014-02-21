using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Student
{
    public partial class FormStud : Form
    {
        static FileStream aFile;
        static public Stud stud;
        Stud studR;
        public FormStud()
        {
            InitializeComponent();
        }
        private void FormStud_Load(object sender, EventArgs e)
        {
            gridStud.Columns.Add("adr", "adr");
            gridStud.Columns["adr"].Width = 30;

            gridStud.Columns.Add("IdGroup", "IdGroup");
            gridStud.Columns["IdGroup"].Width = 30;

            gridStud.Columns.Add("IdStud", "IdStud");
            gridStud.Columns["IdStud"].Width = 30;

            gridStud.Columns.Add("FIO", "FIO");
            gridStud.Columns["FIO"].Width = 200;

            gridStud.AllowUserToAddRows = false; //нет новой строки

            stud = new Stud();
            studR = new Stud();
        }
        private void SetGrid()
        {
            aFile = new FileStream("Stud.dat", FileMode.Open);
            aFile.Seek(0, SeekOrigin.Begin);
            int adr = 0;
            int L = (int)aFile.Length / studR.size;
            int L2 = 0;
            gridStud.RowCount = 0;
            for (int i = 0; i <= L - 1; i++)
            {
                studR.Read( aFile, adr++,false);
                if ((studR.isExists != 0) && (studR.idGroup == FormGroup.group.id))
                {
                    gridStud.RowCount = ++L2;
                    gridStud[0, L2 - 1].Value = i;
                    gridStud[1, L2 - 1].Value = studR.idGroup;
                    gridStud[2, L2 - 1].Value = studR.idStud;
                    gridStud[3, L2 - 1].Value = studR.fio.S;
                }
            }
            
            aFile.Close();
            aFile.Dispose();
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            stud.SetData(FormGroup.group.id);
            if (Program.formEditStud.ShowDialog() == DialogResult.OK)
            {
                stud.Write(aFile, -1);
                SetGrid();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int i = gridStud.CurrentCell.RowIndex;
            int adr = (int)gridStud[0, i].Value;
            stud.Read( aFile, adr, true);
            if (Program.formEditStud.ShowDialog() == DialogResult.OK)
            {
                stud.Write(aFile, adr);
                SetGrid();
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            int i = gridStud.CurrentCell.RowIndex;
            int adr = (int)gridStud[0, i].Value;
            stud.Read( aFile, adr, true);
            stud.isExists = 0;
            stud.Write(aFile, adr);
            SetGrid();
        }

        private void FormStud_Deactivate(object sender, EventArgs e)
        {
            //aFile.Close();
        }

        private void FormStud_Activated(object sender, EventArgs e)
        {
            //aFile = new FileStream("Stud.dat", FileMode.Open);
            SetGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
