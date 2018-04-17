using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using OpenTriviaClient.dto;

namespace OpenTriviaClient {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void buttonAskNext_Click(object sender, EventArgs e) {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://opentdb.com/api.php?amount=1&type=multiple");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromSeconds(3);

            string result = client.GetStringAsync("").Result;
            TriviaResult answer = JsonConvert.DeserializeObject<TriviaResult>(result);
            StringBuilder buf = new StringBuilder(WebUtility.HtmlDecode(answer.Results[0].Question)).AppendLine();
            string[] allAnswers = { answer.Results[0].CorrectAnswer, answer.Results[0].IncorrectAnswers[0], answer.Results[0].IncorrectAnswers[1], answer.Results[0].IncorrectAnswers[2] };
            Random rnd = new Random();
            string[] randomized = allAnswers.OrderBy(x => rnd.Next()).ToArray();
            foreach (string item in randomized) {
                buf.Append("*) ").AppendLine(WebUtility.HtmlDecode(item));
            }

            buf.AppendLine();
            buf.AppendLine(WebUtility.HtmlDecode(answer.Results[0].CorrectAnswer));

            textAskOutput.Text = buf.ToString();
        }
    }
}
