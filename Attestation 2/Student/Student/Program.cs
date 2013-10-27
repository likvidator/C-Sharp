using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Student
{
    static class Program
    {
        public static FormEditGroup formEditGroup;
        public static FormGroup formGroup;
        public static FormStud formStud;
        public static FormFindStud formFindStud;
        public static FormEditStud formEditStud;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //formStud = new FormStud();
            //formFindStud = new FormFindStud();
            formEditStud = new FormEditStud();
            formGroup = new FormGroup();
            formEditGroup = new FormEditGroup();
            Application.Run(formGroup);
        }
    }
}
