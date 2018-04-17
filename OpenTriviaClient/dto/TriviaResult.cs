using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenTriviaClient.dto {
    public class TriviaResult {
        [JsonProperty("response_code")]
        public int ResponseCode { get; set; }
        [JsonProperty("results")]
        public List<TriviaQuestion> Results { get; set; }
    }
}