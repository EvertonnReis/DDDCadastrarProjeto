using DDD.Domain.PicContext;
using DDD.Domain.Service;
using static DDD.Domain.Service.PesquisaDomainService;

namespace DDD.Application.Service
{
    // Application Layer
    public class PesquisaAppService
    {
        private readonly IPesquisaDomainService _pesquisaDomainService;

        public PesquisaAppService(IPesquisaDomainService pesquisaDomainService)
        {
            _pesquisaDomainService = pesquisaDomainService;
        }

        public class BusinessException : Exception
        {
            public BusinessException(string message) : base(message)
            {
            }
        }

        public void CadastrarPesquisador(Pesquisador pesquisador)
        {
            try
            {
                _pesquisaDomainService.ValidarTitulacaoMestre(pesquisador);

            }
            catch (BusinessException ex)
            {
                Console.WriteLine($"Erro de negócio: {ex.Message}");
            }
        }

        public void CadastrarProjeto(Projeto projeto)
        {
            try
            {
                _pesquisaDomainService.ValidarProjetoPosGraduacao(projeto);
                _pesquisaDomainService.ValidarDuracaoProjeto(projeto);


            }
            catch (BusinessException ex)
            {
                Console.WriteLine($"Erro de negócio: {ex.Message}");
            }
        }
    }

}