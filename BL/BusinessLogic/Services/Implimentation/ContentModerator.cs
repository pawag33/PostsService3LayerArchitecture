using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Implimentation
{
    public class ContentModerator : IContentModerator
    {
        private readonly string[] stopWords = {"fuck"};

        public void ModerateContent(string content)
        {
            if(content.ToLower().Split(' ').Intersect(stopWords).Any())
            {
                // TODO: create dedicate exception
                throw new Exception("Content contains a stop word");
            }
        }
    }
}
