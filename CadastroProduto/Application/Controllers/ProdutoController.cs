using AutoMapper;
using Application.Model;
using Domain.Servicies.Interface;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;

namespace Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;

        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoController(ILogger<ProdutoController> logger, IProdutoService produtoService, IMapper mapper)
        {
            _logger = logger;
            _produtoService = produtoService;
            _mapper = mapper;
        }

        /// <summary>
        /// Traz os produto de acordo com o filtro da tela 
        /// </summary>
        /// <returns>Objetos contendo valores de produto</returns>
        [HttpGet]
        [Route("getprodutos/{codigoFornecedor}/{cnpjFornecedor}")]
        public async Task<ActionResult> Index(string codigoFornecedor, string cnpjFornecedor)
        {
            var produtos = _mapper.Map<List<ProdutoModel>>( await _produtoService.GetAllProdutos(codigoFornecedor, cnpjFornecedor));
            return Ok(produtos);
        }

        /// <summary>
        /// Traz o produto filtrado pelo codigo do produto 
        /// </summary>
        /// <returns>Objetos contendo valores de produto</returns>
        [HttpGet]
        [Route("getproduto/{codigo}")]
        public async Task<ActionResult> GetProdutoCodigo(int codigo)
        {
            var produto = _mapper.Map<ProdutoModel>( await _produtoService.GetProdutoPorCodigo(codigo));
            return Ok(produto);
        }

        /// <summary>
        /// Savar Produto
        /// </summary>
        /// <returns>Objetos contendo valores de produto</returns>
        [HttpPost]
        [Route("salvar")]
        public async Task<ActionResult> Salvar([FromBody] ProdutoModel model)
        {
            var produto = await _produtoService.InserirProduto(_mapper.Map<Produto>(model));
            return Ok(produto);
        }

        /// <summary>
        /// Editar Produto
        /// </summary>
        /// <returns>Objetos contendo valores de produto</returns>
        [HttpPut]
        [Route("editar")]
        public async Task<ActionResult> Editar([FromBody] ProdutoModel model)
        {
            var produto = await _produtoService.EditarProduto(_mapper.Map<Produto>(model));
            return Ok(produto);
        }

        /// <summary>
        /// Excluir Produto
        /// </summary>
        /// <returns>Objetos boleano (true ou false)</returns>
        [HttpDelete]
        [Route("excluir")]
        public async Task<ActionResult> Excluir(int id)
        {
            var produto = await _produtoService.ExcluirProduto(id);
            return Ok(produto);
        }

    }
}
