using Movies.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Entities.Concrete
{
    public class Director : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

    }
}
