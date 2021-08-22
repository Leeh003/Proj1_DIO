using System;
using System.Collections.Generic;
using Dio.Animation.Interfaces;

namespace Dio.Animation
{
    public class AnimationRepositorio : IRepositorio<Animation>
    {
        private List<Animation> listaAnimation = new List<Animation>();
        public void Atualiza(Animation entidade)
        {
            listaAnimation[entidade.RetornaId()] = entidade;
        }

        public void Exclui(int id)
        {
            listaAnimation[id].Excluir();
        }

        public void Insere(Animation entidade)
        {
            listaAnimation.Add(entidade);
        }

        public List<Animation> Lista()
        {
            return listaAnimation;
        }

        public int ProximoId()
        {
            return listaAnimation.Count;
        }

        public Animation RetornaPorId(int id)
        {
            return listaAnimation[id];
        }
    }
}