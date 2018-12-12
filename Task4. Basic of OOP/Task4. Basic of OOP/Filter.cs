using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4.Basic_of_OOP
{
    public class Filter
    {
        public string Style;
        public string Actor;
        public string NameFilm;
        public string FilmMaker;
        public string Mark;
        public string DateOfPublishing;

        public DetailsFilm DetailsFilm
        {
            get => default(DetailsFilm);
            set
            {
            }
        }
    }
}