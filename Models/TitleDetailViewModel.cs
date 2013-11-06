using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace turnerdevchallenge.Models
{
    public class TitleDetailViewModel
    {
        public Title thisTitle;
        public IList<Participant> participants;
        public IList<StoryLine> storylines;

    }
}