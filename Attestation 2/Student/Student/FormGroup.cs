using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Student
{
    public partial class FormGroup : Form
    {
        public static Group group;
        public static string findStr = "";
        static FileStream aFile = 
            new FileStream("Group.dat", FileMode.Open);
        BinaryWriter fw = new BinaryWriter(aFile);
        BinaryReader fr = new BinaryReader(aFile);

        public FormGroup()
        {
            InitializeComponent();
        }
        private void FormGroup_Load(object sender, EventArgs e)
        {
            gridGroup.Columns.Add("adr", "adr");
            gridGroup.Columns["adr"].Width = 30;

            gridGroup.Columns.Add("ID", "ID");
            gridGroup.Columns["ID"].Width = 30;
            
            gridGroup.Columns.Add("Name", "Название");
            gridGroup.Columns["Name"].Width = 200;
            
            gridGroup.Columns.Add("Data", "Дата");
            gridGroup.Columns["Data"].Width = 100;
            
            gridGroup.AllowUserToAddRows = false; //нет новой строки

            group = new Group();
            SetGrid();
        }
        private void SetGrid()
        {
            fr.BaseStream.Seek(0,SeekOrigin.Begin);
            int adr = 0;
            int L = (int)fr.BaseStream.Length / group.size;
            //gridGroup.RowCount = L;
            int L2 = 0; // gridGroup.RowCount;
            for (int i = 0; i <= L - 1; i++)
            {
                group.Read(aFile, adr++);
                //group.Read(fr, adr++);
                if (group.isExists != 0)
                {
                    gridGroup.RowCount = ++L2;
                    gridGroup[0, L2 - 1].Value = i;
                    gridGroup[1, L2 - 1].Value = group.id;
                    gridGroup[2, i].Value = group.name.S;
                    DateTime d = 
                        new DateTime(group.year, group.month, group.day);
                    gridGroup[3, L2 - 1].Value = 
                        d.ToShortDateString();

                    //gridGroup.Rows[0] [,].V .Rows. .Add .CurrentCell.ColumnIndex .CurrentCell.Value .CurrentRow.Index CurrentCell.Value  .Columns[].
                    //Thread.Sleep(1000,); // 1sec
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            group.SetData(0, "", DateTime.Now);
            if (Program.formEditGroup.ShowDialog() == 
                DialogResult.OK)
            {
                //group.Write(fw,-1);
                group.Write(/*FileStream*/ aFile, -1);
                SetGrid();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int i = gridGroup.CurrentCell.RowIndex;
            int adr = (int)gridGroup[0, i].Value;
            group.Read(aFile, adr);
            if (Program.formEditGroup.ShowDialog() == 
                DialogResult.OK)
            {
                group.Write(aFile, adr);
                SetGrid();
            }
        }
        
        private void buttonStud_Click(object sender, EventArgs e)
        {
            Program.formStud = new FormStud();
            int i = gridGroup.CurrentCell.RowIndex;
            int adr = (int)gridGroup[0, i].Value;
            group.Read(aFile, adr);
            Program.formStud.ShowDialog(); // .Show();
        }
        
        private void buttonDel_Click(object sender, EventArgs e)
        {
            int i = gridGroup.CurrentCell.RowIndex;
            int adr = (int)gridGroup[0, i].Value;
            group.Read(aFile, adr);
            group.isExists = 0;
            group.Write(aFile, adr);
            SetGrid();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Program.formFindStud = new FormFindStud();
            findStr = textBox1.Text;
            Program.formFindStud.ShowDialog(); // .Show();
        }
    }
}
