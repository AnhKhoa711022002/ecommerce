﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Orders
{
    public enum TransactionType
    {
        ConfrimOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
