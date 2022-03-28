using Cadastro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Interfaces
{
   public interface IProductViewModelService
    {
        public ProdutoViewModel Get(int id);
        IEnumerable<ProdutoViewModel> GetAll();
        void Insert(ProdutoViewModel viewModel);
        void Update(ProdutoViewModel viewModel);
        void Delete(int id);

    }
}
