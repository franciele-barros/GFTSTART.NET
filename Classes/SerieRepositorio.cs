using System;
using System.Collections.Generic;
using series.Interfaces;


namespace series
{
    public class SerieRepositorio : irepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
      
      public void Atualiza(int id, Serie objeto)
      {
          listaSerie[id] = objeto;
      }

       public void Exclui(int id)
      {
          listaSerie[id].Excluir();
      }

       public void Insere (Serie objeto)
      {
          listaSerie.Add(objeto);
      }

       public List<Serie> Lista()
      {
          return listaSerie;
      }

          public int Proximoid()
      {
          return listaSerie.Count;
      }

       public Serie RetornaPorid(int id)
      {
          return listaSerie[id];
      }
     
    }
}