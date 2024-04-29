using System;
using System.Collections.Generic;
using System.IO;
using ModelGUID;
using Newtonsoft.Json;

namespace ModelGUID
{
    public class ModelView
      
    {
        private static readonly string root_directory = @AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.IndexOf("3En1"));
        
        public static string PATH_JSON = root_directory+@"3En1\Configurations\Data.json";

        public static string PATH_HISTORY = root_directory+@"3En1\Configurations\Historial.json";

        public static string PATH_TXT = root_directory+@"3En1\Configurations\About.txt";

        public static string PATH_COMMENTS = root_directory +@"3En1\Configurations\Comments.txt";
        public static string PlayerIcon { get; set; }
        public static string IA_Icon { get; set; }
        public static int TurnPlayGame{ get; set; }
        public static string MsgPlayerGame { get; set; }
        public static string MsgIAGame { get; set; }
        public static Boolean playerWin { get; set; }
        public static Boolean tie { get; set; }
        public static Boolean iA_win { get; set; }

        public static List<string> ListComments = new List<string>();

        public static void InitModelVariables()
        {
            string contentFile = File.ReadAllText(ModelView.PATH_JSON);

            DataModel data = JsonConvert.DeserializeObject<DataModel>(contentFile);

            if (data != null)
            {
                ModelView.TurnPlayGame = data.TurnPlay;

                ModelView.MsgPlayerGame = data.MsgPlayer;

                ModelView.MsgIAGame = data.MsgIA;

                
            }
        }

    }

    
}
