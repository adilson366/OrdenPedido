﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp45.entities
{
    enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
