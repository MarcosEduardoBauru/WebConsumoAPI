using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System.Text;
using WebConsumoAPI.Interfaces;
using WebConsumoAPI.Models;

namespace WebConsumoAPI.Repository
{
    public class RepositoryAtividade : IAtividade
    {
        private readonly string uprApi = "https://www.boredapi.com/api/activity/";

        public List<Atividade> List()
        {
            {
                var retorno = new List<Atividade>();
                try
                {
                    using (var cliente = new HttpClient())
                    {

                        var resposta = cliente.GetStringAsync(uprApi);
                        string resp = resposta.Result.ToString();
                        resposta.Wait();


                       // Atividade? atividade  = JsonSerializer.Deserialize<resposta.Result>(jsonString);
                        retorno = JsonConvert.DeserializeObject<Atividade[]>("["+resposta.Result+"]").ToList();
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                return retorno;
               
            }
        }



        public Atividade Participants(int codigo)
        {
            throw new NotImplementedException();
        }

    }
}
