using Movies.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Entities.Concrete
{
    public class Movie : IEntity
    {
        public int Id { get; set; }

        public int DirectorId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        public int Budget { get; set; }
        public virtual Director Director { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }



    }
}
