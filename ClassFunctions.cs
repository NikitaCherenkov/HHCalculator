using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HHCalculator
{
    internal class ClassFunctions
    {
        public static void CreateNewFile(string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("version=" + ClassData.Version);
                string[] keys = ClassData.Variables.Keys.ToArray();
                for (int i = 0; i < keys.Length; i++)
                {
                    sw.WriteLine(keys[i] + "=0");
                }
            }
        }

        public static void RewriteFile(string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("version=" + ClassData.Version);
                string[] keys = ClassData.Variables.Keys.ToArray();
                for (int i = 0; i < keys.Length; i++)
                {
                    sw.WriteLine(keys[i] + "=" + ClassData.Qualities[keys[i]]);
                }
            }
        }

        public static void ReadFile(string pth)
        {
            string[] Lines = File.ReadAllLines(pth);
            string[] Variables = ClassData.Variables.Keys.ToArray();
            string[] temp = new string[2];
            temp = Lines[0].Split('=');
            bool Contains = false;
            for (int i = 0; i < Variables.Length; i++)
            {
                Contains = false;
                for (int j = 0; j < Lines.Length; j++)
                {
                    if (Lines[j].Contains(Variables[i]))
                    {
                        temp = Lines[j].Split('=');
                        if (temp[1] != null & temp[1] != "")
                        {
                            ClassData.Qualities.Add(temp[0], Int32.Parse(temp[1]));
                        }
                        else
                        {
                            ClassData.Qualities.Add(temp[0], 0);
                        }
                        Contains = true;
                        break;
                    }
                }
                if (!Contains)
                {
                    ClassData.Qualities.Add(Variables[i], 0);
                }
            }
        }

        public static void FillList(ListBox listbox)
        {
            listbox.Items.Clear();
            string[] keys = ClassData.Variables.Keys.ToArray();
            for (int i = 0; i < keys.Length; i++)
            {
                listbox.Items.Add(ClassData.Variables[keys[i]] + " = " + ClassData.Qualities[keys[i]]);
            }
        }

        public static void CreateConvertVariables()
        {
            string[] variables = ClassData.Variables.Keys.ToArray();
            for (int i = 0; i < variables.Length; i++)
            {
                ClassData.ConvertVariables.Add(ClassData.Variables[variables[i]], variables[i]);
            }
        }

        public static void Edit(string Name, int NewQuality)
        {
            ClassData.Qualities[ClassData.ConvertVariables[Name]] = NewQuality;
        }
    }
}
