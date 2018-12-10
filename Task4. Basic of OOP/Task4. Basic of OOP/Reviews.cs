using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4.Basic_of_OOP
{
    public class Reviews
    {
        private string IdFilm;
        private string IdUser;
        public string Review;

        public Person Person
        {
            get => default(Person);
            set
            {
            }
        }

        public DetailsFilm DetailsFilm
        {
            get => default(DetailsFilm);
            set
            {
            }
        }
    }
}