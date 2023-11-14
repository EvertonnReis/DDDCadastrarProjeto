using DDD.Domain.PicContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Service
{
    public interface IPesquisaDomainService
    {
        void ValidarTitulacaoMestre(Pesquisador pesquisador);
        void ValidarProjetoPosGraduacao(Projeto projeto);
        public void ValidarDuracaoProjeto(Projeto projeto);
        public void ValidarPesquisadorAssociadoAoProjeto(Projeto projeto);
    }
}
