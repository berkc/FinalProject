using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="bir kategoride en fazla 10 adet ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde Başka bir ürün var";
        public static string CategoryLimetExceded="Kategori limiti aşıldığı için ürün eklenemiyor";
    }
}
