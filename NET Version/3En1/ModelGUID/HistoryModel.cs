using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModelGUID
{
    [Serializable]
    public class HistoryModel
    {

        [JsonProperty]
        public string Time { get; set; }
        [JsonProperty]
        public string PositionA { get; set; }
        [JsonProperty]
        public string PositionB { get; set; }
        [JsonProperty]
        public string PositionC { get; set; }

    }
}
