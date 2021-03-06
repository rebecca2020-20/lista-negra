using System;

namespace backend.utils
{
    public class conversorlistanegra
    {
        public Models.TbListaNegra paramodelotabela(Models.request.listanegrarequest req)
        {
            Models.TbListaNegra tabela=new Models.TbListaNegra();
            tabela.NmPessoa=req.Nome;
            tabela.DsMotivo=req.Motivo;
            tabela.DsLocal=req.Local;
            tabela.DtInclusao=DateTime.Now;
            return tabela;
        }
        public Models.response.listanegraresponse paramodeloresponse(Models.TbListaNegra tabela)
        {
            Models.response.listanegraresponse resp=new Models.response.listanegraresponse();
            resp.Id=tabela.IdListaNegra;
            resp.Nome=tabela.NmPessoa;
            resp.Motivo=tabela.DsMotivo;
            resp.Local=tabela.DsLocal;
            resp.Inclusao=tabela.DtInclusao;
            resp.Foto=tabela.DsFoto;
            
            return resp;
        }
    }
}