﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnlineApp.Data.Interfaces
{
    public interface IMultiLanguage<T>
    {
        T LanguageId { set; get; }
    }
}
