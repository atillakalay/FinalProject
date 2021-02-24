﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Ürün kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExist = "Bu isimde ürün zaten mevcut";
        public static string CategoryLimitExcited = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
