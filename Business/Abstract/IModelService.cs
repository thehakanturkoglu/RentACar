using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IModelService
    {
        IDataResult<List<Model>> GetAll();
        IDataResult<Model> GetById(int modelId);
        IResult Add(Model model);
        IResult Delete(Model model);
        IResult Update(Model model);
    }

}
