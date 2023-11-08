﻿using System.Collections.Generic;

namespace HospitalApp.Models
{
    public class BillViewModel
    {
        public Bill BillInfo { get; set; }
        public Bill BillForm { get; set; }

        public BillItem BillItemForm { get; set; }
        public List<BillItem> BillItemsAdded { get; set; }
    }
}
