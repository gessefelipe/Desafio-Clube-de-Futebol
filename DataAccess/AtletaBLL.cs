using Project_Clube_Futebol.Services;
using System.Collections.Generic;

namespace Project_Clube_Futebol.DataAccess
{
    public class AtletaBLL
    {
        private AtletaDAL atletaDAL = new AtletaDAL();

        public List<Atleta> GetAtletas()
        {
            return atletaDAL.GetAtletas();
        }

        public void AddAtleta(Atleta atleta)
        {
            atletaDAL.AddAtleta(atleta);
        }

        public void UpdateAtleta(Atleta atleta)
        {
            atletaDAL.UpdateAtleta(atleta);
        }

        public void DeleteAtleta(int id)
        {
            atletaDAL.DeleteAtleta(id);
        }
    }
}