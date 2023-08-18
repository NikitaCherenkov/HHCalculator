using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace HHCalculator
{
    internal class ClassData
    {
        public static readonly string Version = "1.1";
        public static readonly string FileName = "defaults.txt";
        public static readonly string ApplicationPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + "\\" + "HHCalculator";
        public static readonly string FilePath = ClassData.ApplicationPath + "\\" + ClassData.FileName;
        public static readonly string UpdateDownloadLink = "https://github.com/Rovok/HHCalculator/raw/main/HHCalculator.exe";
        public static readonly string UpdateInfoLink = "https://raw.githubusercontent.com/Rovok/HHCalculator/main/Info.txt";
        public static readonly string UpdaterLink = "https://github.com/Rovok/Updater/raw/main/Updater.exe";
        public static readonly Dictionary<string, Form> Forms = new Dictionary<string, Form>()
            {
                { "Ковка", new Form3() },
                { "Coade глина", new Form4() },
                { "Высадка деревьев", new FormTreePot() },
                { "Высадка садовых растений", new FormGardenPot() },
                { "Обычный крафт", new FormCommonCraft() }
            };

        public static Dictionary<string, string> Variables = new Dictionary<string, string>
            {
                { "anvil" , "Наковальня" },
                { "hammer", "Кузнечный молот" },
                { "log", "Поленья" },
                { "stone_axe", "Топор" },
                { "kiln", "Килн" },
                { "flint", "Кремень" },
                { "quartz", "Кварц" },
                { "sand", "Песок" },
                { "ball_clay", "Комовая глина" },
                { "cauldron", "Котёл" },
                { "common_water", "Вода" },
                { "salt_water", "Солёная вода" },
                { "feldspar", "Полевой шпат" },
                { "bone", "Кость" },
                { "cave_clay", "Пещерная глина" },
                { "acre_clay", "Красная глина" },
                { "gray_clay", "Серая глина" },
                { "potters_wheel", "Гончарный круг" },
                { "mulch", "Земля" },
                { "treeplanters_pot", "Горшок для деревьев" },
                { "garden_pot", "Садовый горшок" },
                { "herbalist_table", "Стол травника" }
            };

        public static Dictionary<string, string> ConvertVariables = new Dictionary<string, string>
            {
            };

        public static Dictionary<string, int> Qualities = new Dictionary<string, int>
            {
            };
        public static readonly System.Drawing.Font FontStrikeout = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        public static readonly System.Drawing.Font FontRegular = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        public static bool Form4boolean0 = false;
    }
}
