﻿using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMDT_MOHINHMACCA.Models;
using TMDT_MOHINHMACCA.ViewComponents;
using TMDT_MOHINHMACCA.ViewModels;
using X.PagedList;

namespace TMDT_MOHINHMACCA.Controllers
{
    public class ShopController : Controller
    {
        private readonly ShopmaccaContext _db;
       
        private readonly IMapper _mapper;
        public ShopController(ShopmaccaContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
    
        }
        [Route("/shop")]
        public IActionResult Index(int? categoryid, int? page)
        {   
            ViewBag.Category = _db.Categories.Find(categoryid);  
            if (categoryid!=null)
                ViewBag.CateId=categoryid.Value;
            else
                ViewBag.CateId = null;
            if (page != null)
                ViewBag.Page = page.Value;
            else
                ViewBag.Page = 1;
            return View();
        }
        
    }
}