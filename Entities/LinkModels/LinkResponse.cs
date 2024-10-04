using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.LinkModels
{
    public class LinkResponse
    {
        public bool HasLinks { get; set; }

        public List<Entity> ShapedEntities { get; set; }

        public LinkCollectionWrapper<Entity> LinkEntities { get; set; }

        public LinkResponse() 
        {
            LinkEntities = new LinkCollectionWrapper<Entity>();
            ShapedEntities = new List<Entity>();
        }
    }
}
