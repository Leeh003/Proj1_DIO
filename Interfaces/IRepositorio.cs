using System.Collections.Generic;

namespace Dio.Animation.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(T entidade);
         int ProximoId();
    }
}