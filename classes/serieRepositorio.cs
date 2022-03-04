using System;
using System.Collections.Generic;
using DIO.Series.Interface;

namespace DIO.Series
{
    public class serieRepositorio : irepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();

        public void Atualiza(int Id, Series entidade)
        {
            listaSerie[Id] = entidade;
        }

        public void Exclui(int Id)
        {
            listaSerie[Id].Exclui();
        }

        public void Insere(Series entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Series> Lista()
        {
           return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Series RetornaPorId(int Id)
        {
            return listaSerie[Id];
        }
    }
}