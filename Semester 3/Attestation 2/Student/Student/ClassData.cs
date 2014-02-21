using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Student
{
    public class ShortString
    { 
        public int len;
        string s;
        public string S
        {
            get { return s; }
            set
            {
                s = value;
                if (s.Length > len)
                    s = s.Substring(0, len);
                else
                    while (s.Length < len) s = s + ' ';
            }
        }
        public ShortString(int val, string st)
        {
            len = val;
            S = st;
        }
    }

    public class Group
    {
        public ShortString name; // 20*4
        public int id;           // 4
        public byte isExists;    // 2
        public UInt16 year;      // 2
        public UInt16 day;       // 2
        public UInt16 month;     // 2
        public int size;
        byte[] byData;

        public Group() 
        {
            name = new ShortString(20,"");
            size = 2 + 4 + 6 + 4*20;
            byData = new byte[size];
        }
        
        public void SetData(int ID, string Name, DateTime date)
        {
            this.id = ID; 
            this.name.S = Name;
            this.isExists = 1;
            this.year = (UInt16)date.Year;
            this.month = (UInt16)date.Month;
            this.day = (UInt16)date.Day;
        }
        
        public void Write(FileStream aFile, int adr)
        {
            int ofs = 0;
            int offset;
            if (adr != -1)
                offset = adr * size;
            else
                offset = (int)aFile.Length;

            byte[] byByte;
            byByte = BitConverter.GetBytes(isExists);
            byByte.CopyTo(byData, ofs); ofs = ofs + 2;

            byByte = BitConverter.GetBytes(id);
            byByte.CopyTo(byData, ofs); ofs = ofs + 4;

            byByte = BitConverter.GetBytes(day);
            byByte.CopyTo(byData, ofs); ofs = ofs + 2;

            byByte = BitConverter.GetBytes(month);
            byByte.CopyTo(byData, ofs); ofs = ofs + 2;

            byByte = BitConverter.GetBytes(year);
            byByte.CopyTo(byData, ofs); ofs = ofs + 2;

            char[] charData = name.S.ToCharArray();
            byByte = new byte[4*charData.Length];
            Encoder e = Encoding.UTF32.GetEncoder();
            e.GetBytes(charData, 0, charData.Length, byByte, 0, true);
            byByte.CopyTo(byData, ofs); 

            aFile.Seek(offset,SeekOrigin.Begin);
            aFile.Write(byData,0,size);
            aFile.Flush();
        }
        
        public void Read(FileStream aFile, int adr)
        {
            aFile.Seek(adr * size, SeekOrigin.Begin);
            aFile.Read(byData, 0, size);
            int ofs = 0;
            isExists = (byte)BitConverter.ToInt16(byData, ofs); ofs = ofs + 2;
            id = (Int32)BitConverter.ToInt32(byData, ofs); ofs = ofs + 4;
            day = (UInt16)BitConverter.ToInt16(byData, ofs); ofs = ofs + 2;
            month = (UInt16)BitConverter.ToInt16(byData, ofs); ofs = ofs + 2;
            year = (UInt16)BitConverter.ToInt16(byData, ofs); ofs = ofs + 2;
            
            byte[] byByte = new byte[4*20];
            for (int i=0; i<=4*20-1; i++)
                byByte[i] = byData[i+ofs];
            char[] charData = new char[20];
            Decoder d = Encoding.UTF32.GetDecoder();
            d.GetChars(byByte, 0, byByte.Length, charData, 0);

            string s = ""; 
            for (int i = 0; i < charData.Length; i++)
                s += charData[i];
            name.S = s;
        }
    }

    public class Stud
    {
        public byte isExists;    // 2
        public ShortString fio;  // 4*40
        public int idGroup;      // 4
        public int idStud;       // 4
        public int size;         // 170
        byte[] byData;
        public Stud() 
        {
            fio = new ShortString(40, "");
            size = 9 + 4 * this.fio.len + 1;
            byData = new byte[size];
        }
        public void SetData(int IdGroup)
        {
            this.idGroup = IdGroup;
            this.idStud = 0;
            this.fio.S = "";
            this.isExists = 1;
        }
        public void Write(FileStream aFile, int adr)
        {
            aFile = new FileStream("Stud.dat", FileMode.Open);
            int ofs = 0;
            int offset;
            if (adr != -1)
                offset = adr * size;
            else
                offset = (int)aFile.Length;

            byte[] byByte;
            byByte = BitConverter.GetBytes(isExists);
            byByte.CopyTo(byData, ofs); ofs = ofs + 2;

            byByte = BitConverter.GetBytes(idGroup);
            byByte.CopyTo(byData, ofs); ofs = ofs + 4;

            byByte = BitConverter.GetBytes(idStud);
            byByte.CopyTo(byData, ofs); ofs = ofs + 4;

            char[] charData = fio.S.ToCharArray();
            byByte = new byte[4 * charData.Length];
            Encoder e = Encoding.UTF32.GetEncoder();
            e.GetBytes(charData, 0, charData.Length, byByte, 0, true);
            byByte.CopyTo(byData, ofs);

            aFile.Seek(offset, SeekOrigin.Begin);
            aFile.Write(byData, 0, size);
            aFile.Flush();
            aFile.Close();
            aFile.Dispose();
        }
        public void Read(FileStream aFile, int adr, bool fl)
        {
            if (fl)
            aFile = new FileStream("Stud.dat", FileMode.Open);
            aFile.Seek(adr * size, SeekOrigin.Begin);
            aFile.Read(byData, 0, size);
            int ofs = 0;
            isExists = (byte)BitConverter.ToInt16(byData, ofs); ofs = ofs + 2;
            idGroup = (Int32)BitConverter.ToInt32(byData, ofs); ofs = ofs + 4;
            idStud = (Int32)BitConverter.ToInt32(byData, ofs); ofs = ofs + 4;

            byte[] byByte = new byte[4 * fio.len];
            for (int i = 0; i <= 4 * fio.len - 1; i++)
                byByte[i] = byData[i + ofs];
            char[] charData = new char[fio.len];
            Decoder d = Encoding.UTF32.GetDecoder();
            d.GetChars(byByte, 0, byByte.Length, charData, 0);

            string s = "";
            for (int i = 0; i < charData.Length; i++)
                s += charData[i];
            fio.S = s;
            if (fl)
            {
                aFile.Close();
                aFile.Dispose();
            }
        }
    }
}
