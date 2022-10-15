using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IModelService
    {
        List<Model> GetAll();
        Model GetById(int modelId);
        bool Add(Model model);
        bool Delete(Model model);
        bool Update(Model model);
    }

}
