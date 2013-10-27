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
    public partial class FormFindStud : Form
    {
        static FileStream aFile;
        static public Stud stud;
        public FormFindStud()
        {
            InitializeComponent();
        }

        private void SetGrid()
        {
            aFile = new FileStream("Stud.dat", FileMode.Open);
            aFile.Seek(0, SeekOrigin.Begin);
            int adr = 0;
            int L = (int)aFile.Length / stud.size;
            int L2 = 0;
            gridStud.RowCount = 0;
            for (int i = 0; i <= L - 1; i++)
            {
                stud.Read(aFile, adr++, false);
                string s = FormGroup.findStr;
                if ((stud.isExists != 0) && 
                    ((stud.fio.S.IndexOf(s) == 0) 
                    || (s.Length == 0)))
                {
                    gridStud.RowCount = ++L2;
                    gridStud[0, L2 - 1].Value = i;
                    gridStud[1, L2 - 1].Value = stud.idGroup;
                    gridStud[2, L2 - 1].Value = stud.idStud;
                    gridStud[3, L2 - 1].Value = stud.fio.S;
                }
            }
            aFile.Close();
            aFile.Dispose();
        }
        private void FormFindStud_Load(object sender, EventArgs e)
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
            SetGrid();
        }
    }
}
