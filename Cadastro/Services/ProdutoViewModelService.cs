using AutoMapper;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces;
using Cadastro.Interfaces;
using Cadastro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Services
{
    public class ProdutoViewModelService : IProductViewModelService
    {
        private readonly IProductRepository _produtorepository;
        private readonly IMapper _mapper;

        public ProdutoViewModelService(IProductRepository productRepository, IMapper mapper)
        {
            _produtorepository = productRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            Delete(id);
        }

        public ProdutoViewModel Get(int id)
        {
            var entity = _produtorepository.Get(id);
            if (entity == null)
                return null;

            return _mapper.Map<ProdutoViewModel>(entity);
        }

        public IEnumerable<ProdutoViewModel> GetAll()
        {
            var list = _produtorepository.GetAll();
            if (list == null)
                return new ProdutoViewModel[] { };

            return _mapper.Map<IEnumerable<ProdutoViewModel>>(list);
        }

        public void Insert(ProdutoViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _produtorepository.Insert(entity);
        }

        public void Update(ProdutoViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _produtorepository.Update(entity);
        }
    }
}
