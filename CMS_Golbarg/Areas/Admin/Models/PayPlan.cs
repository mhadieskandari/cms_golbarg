﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS_Golbarg.Areas.Admin.Models
{
    public class PayPlan
    {
        [Key]
        public int Id { set; get; }

        public string PlanName { set; get; }

        public string PlanDes { set; get; }

        public int Fi { set; get; }

        public int NumberOfCoin { set; get; }

        public DateTime? StartDate { set; get; }

        public DateTime? EndDate { set; get; }

        public bool State { set; get; }

        public virtual IEnumerable<Pay> Pays { set; get; }

        public int PayAmount
        {
            get { return NumberOfCoin * Fi; }
        }
    }
}