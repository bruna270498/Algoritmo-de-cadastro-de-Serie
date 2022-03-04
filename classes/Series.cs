namespace DIO.Series
{
    public class Series : entidadeBase
    {
        //atributos
        private Genero genero { get; set; }
        private string titulo { get; set; }
        private string descricao { get; set; }
        private int ano { get; set; }
        private bool Excluido {get; set;}

        //metodos
        public Series(int Id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = Id;
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero:" + this.genero + Environment.NewLine;
            retorno += "Título:" + this.titulo + Environment.NewLine;
            retorno += "Descrição: " + this.descricao + Environment.NewLine;
            retorno += "Ano:" + this.ano + Environment.NewLine;
            retorno += "Excluído:" + this.Excluido;
            return retorno;
        }
        public string retornaTítulo()
        {
            return this.titulo;
        }
         public int retornaId()
         {
             return this.Id;

         }
         public bool retornaExcluido()
         {
             return this.Excluido;
         }
         public void Exclui()
         {
             this.Excluido = true;
         }



    }
}