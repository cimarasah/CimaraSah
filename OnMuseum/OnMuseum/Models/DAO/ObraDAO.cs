using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using OnMuseum.Models.Basic;
using Parse;


namespace OnMuseum.Models.DAO
{
    public class ObraDAO
    {
        public void Inserir(ObraBasic obra)
        {
            try
            {

                var db = new ParseObject("Obra");
                db["id"] = obra.Id;
                db["nome"] = obra.Nome;
                db["autor_id"] = obra.AutorId;
                db["criacao"] = obra.Criacao;
                db["observacao"] = obra.Observacao;
                db["id"] = obra.Id;
                db.SaveAsync();

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public async Task<List<ObraBasic>> ListarTodos()
        {
            ObraBasic obra;
            List<ObraBasic> listaObras = new List<ObraBasic>();
            ParseQuery<ParseObject> query = new ParseQuery<ParseObject>("Obra");
            List<ParseObject> db = (List<ParseObject>) await query.FindAsync();
            foreach (var parseObject in db)
            {
                obra = new ObraBasic();
                obra.Id = parseObject.Get<int>("objectId");
                obra.Nome = parseObject.Get<string>("nome");
                obra.AutorId = parseObject.Get<int>("autor_id");
                listaObras.Add(obra);

            }
            //List<ObraBasic> listaObra = db.G;
        }

    }
}