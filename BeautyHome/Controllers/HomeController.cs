﻿using BeautyHome.Context;
using BeautyHome.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BeautyHome.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection connection = DBUtils.GetDBConnection();
        public BeautyHomeEntities db = new BeautyHomeEntities();
        public ActionResult Index()
        {
            var listtype = db.type_product.ToList();
            var listfur = db.furnitures.ToList();
            /*            var listpr = db.products.ToList();*/

            TypeProductView objtypeProductView = new TypeProductView();
            objtypeProductView.listtype = listtype;
            objtypeProductView.listfur = listfur;

            return View(objtypeProductView);
        }
    }
}