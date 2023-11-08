﻿
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		readonly private IProductReadRepository _productReadRepository;
		readonly private IProductWriteRepository _productWriteRepository;

		readonly private IOrderWriteRepository _orderWriteRepository;
		readonly private IOrderReadRepository _orderReadRepository;

		readonly private ICustomerWriteRepository _customerWriteRepository;

		public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
		{
			_productReadRepository = productReadRepository;
			_productWriteRepository = productWriteRepository;
			_orderWriteRepository = orderWriteRepository;
			_customerWriteRepository = customerWriteRepository;
			_orderReadRepository = orderReadRepository;
		}
		[HttpGet]
		public async Task Get()
		{
			Order order = await _orderReadRepository.GetByIdAsync("218fdfbe-f682-404d-b91a-54a9ca6c1d33");
			order.Address = "İstanbul";
			await _orderWriteRepository.SaveAsync();
		}
		
	}
}
