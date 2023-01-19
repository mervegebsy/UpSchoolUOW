﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW_DataAccessLayer.Abstract;
using UOW_DataAccessLayer.Concrete;
using UOW_DataAccessLayer.Repository;
using UOW_EntityLayer.Concrete;

namespace UOW_DataAccessLayer.EntityFramework
{
    public class EfProcessDetailDal: GenericRepository<ProcessDetail>, IProcessDetailDal
    {
        public EfProcessDetailDal(Context context): base(context)
        {

        }
    }
}
