using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTrainingWebsite.BL.Interfaces
{
    public interface IPokerTrainingService<ModelBL> where ModelBL : class
    {     
            void Add(ModelBL model);
            void Remove(int id);
            void Update(ModelBL model);
            ModelBL GetById(int id);
            IEnumerable<ModelBL> GetAll();
        
    }
}
