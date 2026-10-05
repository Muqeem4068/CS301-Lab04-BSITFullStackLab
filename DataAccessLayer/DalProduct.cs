using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class DalProduct: IProductDal
    {
        public void GetData() 
        {
            DBHelper.MSSQLServer();
           
        }
    }
}
