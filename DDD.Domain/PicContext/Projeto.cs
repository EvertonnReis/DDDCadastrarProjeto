namespace DDD.Domain.PicContext
{
    public class Projeto
    {
        public int Id { get; set; }
        public int Duracao { get; set; }
        public bool CadastradoNoSetorPosGraduacao { get; set; }
        public int PesquisadorId { get; set; }
        public Pesquisador Pesquisador { get; set; }
    }
}
