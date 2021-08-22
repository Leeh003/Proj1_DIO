using System;

namespace Dio.Animation
{
    public class Animation : EntidadeBase
    {
        // Construtor
        public Animation(int id, EnumGenero genero, string titulo, string sinopse, int ano)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Sinopse = sinopse;
            this.Genero = genero;
            this.Ano = Ano;
            Excluido = false;
        }

        // Atributos
        private EnumGenero Genero { get; set; }
        private string Titulo { get; set; }
        private string Sinopse { get; set; }
        private int Ano  { get; set; }
        private bool Excluido { get; set; }

        // Metodos
        public override string ToString()
        {
            string retorno = "Título: " + this.Titulo + Environment.NewLine +
            "Genêro: " + this.Genero + Environment.NewLine +
            "Sinopse: " + this.Sinopse + Environment.NewLine +
            "Ano: " + this.Ano + Environment.NewLine + 
            "Excluida: " + this.Excluido;

            return retorno;
        }

        public string RetornaTitulo(){
            return this.Titulo;
        }

        public int RetornaId(){
            return this.Id;
        }
        public bool RetornaExcluido(){
            return this.Excluido;
        }

        public void Excluir(){
            this.Excluido = true; 
        }
    }
}