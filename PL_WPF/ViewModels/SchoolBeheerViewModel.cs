﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Repository;

namespace PL_WPF.ViewModels
{
    class SchoolTypeViewModel : KlantTypeViewModel
    {
        public SchoolTypeViewModel(UnitOfWork ctx) : base(ctx)
        {
            AddType.Type = "School";
        }

        public override void GetData()
        {
            ViewSource.Source = Ctx.KlantTypes.Find(s => s.Type == "School");
        }

        public override void Add()
        {
            base.Add();
            AddType.Type = "School";
        }
    }
}
