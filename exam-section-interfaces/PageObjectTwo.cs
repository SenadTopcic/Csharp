﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_section_interfaces
{
    internal class PageObjectTwo : IPageObject
    {
        private string pageName;

        public string PageName
        {
            get { return pageName; }
            set { pageName = value; }
        }

        public PageObjectTwo()
        {
            PageName = "Page Name 2";
        }

    }
}
