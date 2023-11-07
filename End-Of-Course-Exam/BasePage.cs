using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace End_Of_Course_Exam
{
    abstract class BasePage
    {
        private string pageName;
        public virtual string PageName {  get { return pageName; } set {  pageName = value; } }

    }
}
