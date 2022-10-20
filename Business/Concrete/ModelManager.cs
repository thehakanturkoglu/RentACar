using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;


namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        private IModelDal _modelDal;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public IResult Add(Model model)
        {
            _modelDal.Add(model);
            return new SuccessResult(Messages.ModelAdded);
        }

        public IResult Delete(Model model)
        {
            _modelDal.Delete(model);
            return new SuccessResult(Messages.ModelDeleted);

        }

        public IDataResult<List<Model>> GetAll()
        {
            var data =  _modelDal.GetAll();
            return new SuccessDataResult<List<Model>>(data);
        }

        public IDataResult<Model> GetById(int modelId)
        {
            var data =  _modelDal.Get(m => m.Id == modelId);
            return new SuccessDataResult<Model>(data);
        }

        public IResult Update(Model model)
        {
            _modelDal.Update(model);
            return new SuccessResult(Messages.ModelUpdated);
        }
    }


}
