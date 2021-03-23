using System;
using System.Collections.Generic;
using System.Text;
using ShopOnlineApp.Data.Enums;

namespace ShopOnlineApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
