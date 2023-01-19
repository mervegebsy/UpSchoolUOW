﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOW_BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetByID(int id);
        void TMultipleUpdate(List<T> t);
    }
}
