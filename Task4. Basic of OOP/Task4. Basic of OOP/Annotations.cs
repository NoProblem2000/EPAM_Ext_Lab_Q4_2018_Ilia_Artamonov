using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4.Basic_of_OOP
{
    public class Annotations
    {
        public string IdFilm;
        public string Annotation;

        public DetailsFilm DetailsFilm
        {
            get => default(DetailsFilm);
            set
            {
            }
        }
    }
}