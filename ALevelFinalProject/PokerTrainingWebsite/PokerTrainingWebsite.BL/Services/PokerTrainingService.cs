﻿using PokerTrainingWebsite.BL.Interfaces;
using PokerTrainingWebsite.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTrainingWebsite.BL.Services
{
    public abstract class PokerTrainingService<ModelBL, ModelDL> : IPokerTrainingService<ModelBL>
        where ModelBL : class
        where ModelDL : class
    {
        public readonly IGenerickRepository<ModelDL> _repository;

        public PokerTrainingService(IGenerickRepository<ModelDL> repository)
        {
            _repository = repository;
        }

        public void Add(ModelBL modelBL)
        {
            var model = Map(modelBL);
            _repository.Add(model);
        }

        public IEnumerable<ModelBL> GetAll()
        {
            var models = _repository.GetAll().ToList();

            return Map(models);
        }

        public ModelBL GetById(int id)
        {
            var model = _repository.GetById(id);

            return Map(model);
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Update(ModelBL modelBL)
        {
            var model = Map(modelBL);
            _repository.Update(model);
        }

        public abstract ModelBL Map(ModelDL modelDL);
        public abstract ModelDL Map(ModelBL modelBL);

        public abstract IEnumerable<ModelBL> Map(IList<ModelDL> modelsDL);
        public abstract IEnumerable<ModelDL> Map(IList<ModelBL> modelsBL);
    }
}
