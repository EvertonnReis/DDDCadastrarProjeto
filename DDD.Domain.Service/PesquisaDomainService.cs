using DDD.Domain.PicContext;

namespace DDD.Domain.Service
{
    // Domain Service
    //public interface IPesquisaDomainService
    //{
    //    void ValidarTitulacaoMestre(Pesquisador pesquisador);
    //    void ValidarProjetoPosGraduacao(Projeto projeto);
    //}

    public class PesquisaDomainService : IPesquisaDomainService
    {
        public class BusinessException : Exception
        {
            public BusinessException(string message) : base(message)
            {
            }
        }

        public void ValidarTitulacaoMestre(Pesquisador pesquisador)
        {
            if (pesquisador.Titulacao != "Mestre")
            {
                throw new BusinessException("O pesquisador deve ter no mínimo a titulação de Mestre.");
            }
        }

        public void ValidarProjetoPosGraduacao(Projeto projeto)
        {
            if (!projeto.CadastradoNoSetorPosGraduacao)
            {
                throw new BusinessException("O projeto deve estar cadastrado no setor de Pós Graduação.");
            }
        }
        public void ValidarDuracaoProjeto(Projeto projeto)
        {
            if (projeto.Duracao <= 1)
            {
                throw new BusinessException("O projeto deve ter mais de 1 ano de duração.");
            }
        }
        public void ValidarPesquisadorAssociadoAoProjeto(Projeto projeto)
        {
            if (projeto.Pesquisador == null)
            {
                throw new BusinessException("O projeto deve ter um pesquisador associado.");
            }
        }

    }

}