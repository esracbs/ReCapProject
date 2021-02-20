using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal
    {
        //dal veri erişim katmanı olduğunu anlamamıza yarıyor
        //orm:veritabanındaki tabloyu sanki classmış gibi onunla ilişkilendirip sonraki tüm operasyonları
        //linq ile yaptığımız program yani veritabanı nesneleriyle kodlar arasında bir bağ kurup veritabanı işlerini yapma süreci
        
    }
}
