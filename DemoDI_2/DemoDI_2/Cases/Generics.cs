using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI_2.Cases
{
    public interface IGenericRepository<T> where T : class
    {
        void Adicionar(T obj);
    }
    
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        public void Adicionar(T obj)
        {
            //faz algo
        }

    }
}
