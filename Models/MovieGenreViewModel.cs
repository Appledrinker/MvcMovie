using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    /*
     * 
    A list of movies.
    A SelectList containing the list of genres. This allows the user to select a genre from the list.
    MovieGenre, which contains the selected genre.
    SearchString, which contains the text users enter in the search text box.

     */
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
