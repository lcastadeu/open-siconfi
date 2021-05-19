using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace OpenSiconfi.Infrastructure
{
	public class OSMensagem
	{		
		public string Mensagem { get; set; }
		public object Data { get; set; }
		public HttpStatusCode HttpCode { get; set; }

		public OSMensagem(object data = null,
                    	HttpStatusCode httpCode = HttpStatusCode.OK)
		{
      HttpCode = httpCode;
      Data = JsonSerializer.Serialize(data,
                                      new JsonSerializerOptions()
                                      {
                                        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                                        WriteIndented = false,
                                        AllowTrailingCommas = false
                                      });

			if (string.IsNullOrEmpty(Mensagem))
      {
        Mensagem = "Informação obtida com sucesso!";
        if (Data == null)
        {
          Mensagem = "Não foi possivel obter a informação!";
          HttpCode = HttpStatusCode.NoContent;
        }
			}
		}

		public OSMensagem SetMensagem(string menssagem){
			Mensagem = menssagem;
			return this;
		}
	}
}