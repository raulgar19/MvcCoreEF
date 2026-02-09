using MvcCoreEF.Data;
using MvcCoreEF.Models;
using System.Runtime.InteropServices;

namespace MvcCoreEF.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;

            return consulta.ToList();
        }
    }
}