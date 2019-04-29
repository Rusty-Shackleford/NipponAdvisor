using Newtonsoft.Json;
using NipponAdvisor.CafeItems;
using NipponAdvisor.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NipponAdvisor
{
    static class Program
    {
        #region [ Global Static Resources ]
        public static List<Dish> DishTable { get; private set; }
        public static List<Ingredient> IngredientTable { get; private set; }

        public static List<Image> IconSet_Application { get; private set; }
        public static List<Image> IconSet_Game { get; private set; }
        #endregion


        [STAThread]
        static void Main()
        {
            // Load Dish Data
            // string DishJson = GameData.ResourceManager.GetString("DishData");
            string DishJson = GameData.DishData;
            DishTable = JsonConvert.DeserializeObject<List<Dish>>(DishJson);

            // Load Ingredient Data
            string IngredientJson = GameData.IngredientData;
            IngredientTable = JsonConvert.DeserializeObject<List<Ingredient>>(IngredientJson);

            // Load Icon Files
            IconSet_Application = new List<Image>()
            {
                AppIcons.Application,
                AppIcons.Close,
                AppIcons.Collection,
                AppIcons.Console,
                AppIcons.Document,
                AppIcons.Files,
                AppIcons.FolderClosed,
                AppIcons.FolderOpened,
                AppIcons.Info,
                AppIcons.InfoSmall,
                AppIcons.Log,
                AppIcons.NewFile,
                AppIcons.Properties,
                AppIcons.Nippon_300x,
                AppIcons.Nippon_64x,
                AppIcons.Nippon_32x
            };

            // Load GameIcons
            IconSet_Game = new List<Image>()
            {
                GameIcons.Appearance_24x,
                GameIcons.Aroma_24x,
                GameIcons.Brain_24x,
                GameIcons.Charisma_24x,
                GameIcons.Health_24x,
                GameIcons.Rarity_24x,
                GameIcons.Dish_24x
            };


            // Start WinForm
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
