using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using VisualStudioSummit.Models;

namespace VisualStudioSummit.Application
{
    public class ControladorDeEmocoes
    {
        private const string _cognitiveServiceUrl = "https://westus.api.cognitive.microsoft.com/emotion/v1.0/";
        private const string _key = "";

        public IEnumerable<Emotion> DescobrirEmocoes(byte[] arquivo)
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(_cognitiveServiceUrl)
            };

            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _key);

            using(var content = new ByteArrayContent(arquivo))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                var response = httpClient.PostAsync("recognize", content).Result;

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Ai meu Deus :(");

                var result = response.Content.ReadAsStringAsync().Result;

                var emocoes = JsonConvert.DeserializeObject<IEnumerable<Emotion>>(result);

                return emocoes;
            }
        }

    }
}
