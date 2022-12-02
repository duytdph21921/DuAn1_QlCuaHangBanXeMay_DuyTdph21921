using A_DAL.DomaninClass;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IService;
using B_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace B_BUS.Service
{
    public class DongCoService : IDongCoService
    {
        IDongCo _IDongCoService;
        public DongCoService()
        {
            _IDongCoService= new DongCos();
        }
        public string add(DongCoviewmodel dongCoviewmodel)
        {
            try
            {
                if (dongCoviewmodel == null) return " thêm thất bại";
                dongCo dongCo = new dongCo()
                {

                    Ma = dongCoviewmodel.Ma,
                    Ten = dongCoviewmodel.Ten,
                };
                if (_IDongCoService.add(dongCo)) return " thêm thành công";
             
              
            }
            catch (Exception e )
            {
                return e.Message;
            }
            return " thêm thất bại";
        }

        public string delete(DongCoviewmodel dongCoviewmodel)
        {
            try
            {
                if (dongCoviewmodel == null) return " xóa thất bại";
                dongCo dongCo = new dongCo()
                {
                    id = dongCoviewmodel.id,
                
                };
                if (_IDongCoService.delete(dongCo)) return " xóa thành công";


            }
            catch (Exception e)
            {
                return e.Message;
            }
            return " xóa thất bại";
        }

        public List<DongCoviewmodel> Getall()
        {  
            var dongco = (from a in _IDongCoService.GetAll()
                          select new DongCoviewmodel()
                          {
                              id = a.id,
                              Ma = a.Ma,
                              Ten = a.Ten,
                          }).ToList();
            return  dongco;
        }

        public string update(DongCoviewmodel dongCoviewmodel)
        {
            try
            {
                if (dongCoviewmodel == null) return " sửa thất bại";
                dongCo dongCo = new dongCo()
                {
                    id= dongCoviewmodel.id,
                    Ma = dongCoviewmodel.Ma,
                    Ten = dongCoviewmodel.Ten,
                };
                if (_IDongCoService.update(dongCo)) return " sửa thành công";


            }
            catch (Exception e)
            {
                return e.Message;
            }
            return " sửa thất bại";
        }
    }
}
