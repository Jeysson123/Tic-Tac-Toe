using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using ModelGUID;
using Newtonsoft.Json;

namespace Service_GUID
{
    public static class ServiceView
    {
        public static string PaintIcon(dynamic currentIcon)
        {
            string icon = Convert.ToString(currentIcon);

            return $"{(icon == "radioX" ? "X" : "O")}";
        }

        public static string SetPlayerPosition(dynamic P)
        {
            string Position = "";

            switch (P)
            {
                case "position1":
                    Position = "position1";
                    break;
                case "position2":
                    Position = "position2";
                    break;
                case "position3":
                    Position = "position3";
                    break;
                case "position4":
                    Position = "position4";
                    break;
                case "position5":
                    Position = "position5";
                    break;
                case "position6":
                    Position = "position6";
                    break;
                case "position7":
                    Position = "position7";
                    break;
                case "position8":
                    Position = "position8";
                    break;
                case "position9":
                    Position = "position9";
                    break;
            }


            return Position;
        }

        public static int IA_Play()
        {
            Random IA_Random = new Random();

            return IA_Random.Next(9);

        }
        public static bool ValidateMaximumintelligence_IA_Play(Dictionary<string, string> listPositions)
        {
            bool IA_Attack = false;

            var positionA = "";
            var positionB = "";
            var positionC = "";

            var valueA = "";
            var valueB = "";
            var valueC = "";

            var combinatios = new List<int[]>
            {
                { new int[]{1,2,3} },
                { new int[]{4,5,6} },
                { new int[]{7,8,9} },
                { new int[]{1,4,7} },
                { new int[]{2,5,8} },
                { new int[]{3,6,9} },
                { new int[]{1,5,9} },
                { new int[]{3,5,7} },
            };

            foreach (var com in combinatios)
            {
                foreach (var entry in listPositions)
                {
                    if (entry.Key.EndsWith($"{com[0]}"))
                    {
                        positionA = entry.Key;

                        valueA = entry.Value;

                    }
                    if (entry.Key.EndsWith($"{com[1]}"))
                    {
                        positionB = entry.Key;

                        valueB = entry.Value;

                    }
                    if (entry.Key.EndsWith($"{com[2]}"))
                    {
                        positionC = entry.Key;

                        valueC = entry.Value;
                    }
                }

                if (valueA.Equals(String.Empty) && valueB.Equals(ModelView.IA_Icon) && valueC.Equals(ModelView.IA_Icon))
                {
                    IA_Attack = true;
                }
                else if (valueA.Equals(ModelView.IA_Icon) && valueB.Equals(String.Empty) && valueC.Equals(ModelView.IA_Icon))
                {

                    IA_Attack = true;
                }
                else if (valueA.Equals(ModelView.IA_Icon) && valueB.Equals(ModelView.IA_Icon) && valueC.Equals(String.Empty))
                {

                    IA_Attack = true;
                }
            }

            return IA_Attack;

          }

            public static int Maximumintelligence_IA_Play(string icon, Dictionary<string, string> listPositions)
        {
            var especificPosition = "";

            var positionA = "";
            var positionB = "";
            var positionC = "";

            var valueA = "";
            var valueB = "";
            var valueC = "";

            var combinatios = new List<int[]>
            {
                { new int[]{1,2,3} },
                { new int[]{4,5,6} },
                { new int[]{7,8,9} },
                { new int[]{1,4,7} },
                { new int[]{2,5,8} },
                { new int[]{3,6,9} },
                { new int[]{1,5,9} },
                { new int[]{3,5,7} },
            };

            foreach (var com in combinatios)
            {
                foreach (var entry in listPositions)
                {
                    if (entry.Key.Equals($"position{com[0]}"))
                    {
                        positionA = entry.Key;

                        valueA = entry.Value;

                    }
                    if (entry.Key.Equals($"position{com[1]}"))
                    {
                        positionB = entry.Key;

                        valueB = entry.Value;

                    }
                    if (entry.Key.Equals($"position{com[2]}"))
                    {
                        positionC = entry.Key;

                        valueC = entry.Value;
                    }
                }

                if(valueA.Equals(String.Empty) && valueB.Equals(icon) && valueC.Equals(icon))
                {
                    especificPosition = positionA.Replace("position", "");

                    return Convert.ToInt32(especificPosition);
                }
                else if (valueA.Equals(icon) && valueB.Equals(String.Empty) && valueC.Equals(icon))
                {
                    especificPosition = positionB.Replace("position", "");

                    return Convert.ToInt32(especificPosition);
                }
                else if (valueA.Equals(icon) && valueB.Equals(icon) && valueC.Equals(String.Empty))
                {
                    especificPosition = positionC.Replace("position", "");

                    return Convert.ToInt32(especificPosition);
                }

            }

            

            return 0;

        }

        public static string DurationMatch(int S)
        {
            return $"{S / 60} Minutos : {S} Segundos";
        }

        public static void HistoryMatch(string Time, string[] Positions)
        {          

            string contentFile = File.ReadAllText(ModelView.PATH_HISTORY);

            List<HistoryModel> listHistory = JsonConvert.DeserializeObject<List<HistoryModel>>(contentFile);

            var newHistory = new HistoryModel
            {
                Time = Time,
                PositionA = Positions[0],
                PositionB = Positions[1],
                PositionC = Positions[2]
            };

            listHistory.Add(newHistory);

            string historyAdded = JsonConvert.SerializeObject(listHistory);

            File.WriteAllText(ModelView.PATH_HISTORY, historyAdded);

        }

        public static List<string[]> LoadMatchs()
        {
            List<string[]> allMatchs = new List<string[]>();

            string contentFile = File.ReadAllText(ModelView.PATH_HISTORY);

            List<HistoryModel> listHistory = JsonConvert.DeserializeObject<List<HistoryModel>>(contentFile);

            Regex regex = new Regex(@"\d+", RegexOptions.IgnorePatternWhitespace);

            foreach (var his in listHistory)
            {
                var time = his.Time;

                var casA = "";

                var casB = "";

                var casC = "";

                foreach (Match h in regex.Matches(his.PositionA))
                {
                    var item = h.Groups[0].Value;

                    casA = his.PositionA.Replace(his.PositionA, $"Casilla # : {item}");

                }
                foreach (Match h in regex.Matches(his.PositionB))
                {
                    var item = h.Groups[0].Value;

                    casB = his.PositionA.Replace(his.PositionB, $"Casilla # : {item}");

                }
                foreach (Match h in regex.Matches(his.PositionC))
                {
                    var item = h.Groups[0].Value;

                    casC = his.PositionA.Replace(his.PositionC, $"Casilla # : {item}");

                }

                allMatchs.Add(new string[] { time, casA, casB, casC });


            }

            return allMatchs;
        }

        public static string BetterPlay()
        {
            var favoritePlay = "";

            int shortTime = 0;

            int sumElementIntegers = 0;

            int sizeList = 0;

            List<int> allIntegers = new List<int>();

            Regex regex = new Regex(@"\d+", RegexOptions.IgnorePatternWhitespace);

            string contentFile = File.ReadAllText(ModelView.PATH_HISTORY);

            var listHistory = JsonConvert.DeserializeObject< HistoryModel[]> (contentFile);

            for(int i = 0; i < listHistory.Length; i++)
            {
                foreach (Match h in regex.Matches(listHistory[i].Time))
                {
                    var item = h.Groups[0].Value;

                    sumElementIntegers += Convert.ToInt32(item);

                }

                allIntegers.Add(sumElementIntegers);

                sumElementIntegers = 0;
            }

            shortTime = allIntegers.Min();

            sizeList = allIntegers.Count() - 1;

            while (sizeList >= 0)
            {
                if (listHistory[sizeList].Time.Contains(Convert.ToString(shortTime)))
                {
                    foreach (Match h in regex.Matches(listHistory[sizeList].PositionA))
                    {
                        var item = h.Groups[0].Value;

                        listHistory[sizeList].PositionA = listHistory[sizeList].PositionA.Replace(listHistory[sizeList].PositionA, $"Casilla # : {item}");

                    }
                    foreach (Match h in regex.Matches(listHistory[sizeList].PositionB))
                    {
                        var item = h.Groups[0].Value;

                        listHistory[sizeList].PositionB = listHistory[sizeList].PositionB.Replace(listHistory[sizeList].PositionB, $"Casilla # : {item}");

                    }
                    foreach (Match h in regex.Matches(listHistory[sizeList].PositionC))
                    {
                        var item = h.Groups[0].Value;

                        listHistory[sizeList].PositionC = listHistory[sizeList].PositionC.Replace(listHistory[sizeList].PositionC, $"Casilla # : {item}");

                    }


                    favoritePlay = $"JUGADA PODEROSA\nDuracion de esa Jugada: {DurationMatch(shortTime)}\nPrimera Posicion: {listHistory[sizeList].PositionA}\nSegunda Posicion: {listHistory[sizeList].PositionB}\nTercera Posicion: {listHistory[sizeList].PositionC}";

                    break;
                }

                sizeList--;
            }



            return favoritePlay;

        }

        public static void WriteComment(string date, string comment)
        {

            File.AppendAllText(ModelView.PATH_COMMENTS, $"Fecha: {date}, Comentario: {comment}\n");

        }

        public static string LoadComments()
        {

            return File.ReadAllText(ModelView.PATH_COMMENTS);

        }

        public static List<string> LoadCommentsFormated()
        {
            List<string> ListDates = new List<string>();

            var commentsInTxt = ServiceView.LoadComments().Split("\n");

            Regex regexDate = new Regex(@"(Fecha:)", RegexOptions.IgnorePatternWhitespace);

            Regex regexComment = new Regex(@"(Comentario:)", RegexOptions.IgnorePatternWhitespace);

            var dateTable = "";

            var commentTable = "";

            foreach (var c in commentsInTxt)
            {

                foreach (Match d in regexDate.Matches(c.ToString()))
                {
                    dateTable = d.Groups[0].Value;

                    dateTable = c.Substring(c.IndexOf(dateTable) + dateTable.Length, c.IndexOf(",") - dateTable.Length);

                    ListDates.Add(dateTable);

                }

                foreach (Match m in regexComment.Matches(c.ToString()))
                {
                    commentTable = m.Groups[0].Value;

                    commentTable = c.Substring(c.IndexOf(commentTable) + commentTable.Length);

                    ModelView.ListComments.Add(commentTable);

                }
                
                


            }

            return ListDates;

        }


    }
}
