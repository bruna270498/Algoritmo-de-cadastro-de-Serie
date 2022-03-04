using System.Collections.Generic;

namespace DIO.Series.Interface
{
    public interface irepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int Id);
         void Insere( T entidade);
         void Atualiza(int Id, T entidade);
        void Exclui(int Id);
         int ProximoId();
    
    }
}
