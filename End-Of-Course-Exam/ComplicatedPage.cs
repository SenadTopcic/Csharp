using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace End_Of_Course_Exam
{
    internal class ComplicatedPage : BasePage
    {
        public SectionOfButtons ButtonsSection { get; set; }
        public SectionOfSocialMedia SocialMedisSection { get; set; }
        public SectionOfRandomStuff RandomStuffSection { get; set; }

        public override string PageName { get => "Complicated Page"; }

    }
}
