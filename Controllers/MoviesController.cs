using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore02.Controllers
{
    public class MoviesController:Controller
    {
        //PUBLIC NON STATIC Function has special return types
        //default type text/html
        //use iactionresult when i need flexibility in returning multiple types of responses.
        //use actionresult when i return only json file (APIS)
        public IActionResult index()
        {
            //without helper method
            //ContentResult result = new ContentResult();
            //result.Content = "Black Adam";
            //result.ContentType = "text/html"; 
            //return result;

            //use helper method
            return Content("Black Adam", "text/html");
        }
        public IActionResult hamada()
        {
            //without helper method
            // RedirectResult result=new RedirectResult("https://localhost:44318/Movie/inde");
            //return result;

            //use helpermethod
            return RedirectToAction(nameof(index));
        }

        public IActionResult GetMovie(Movie movie) //get parameter from 1)Html Form 2)segment 3)Query string (usable) 4)file
        {
            return Content($"Movie with id:{movie.id} ::: with Name {movie.name}");
        }
    }
}
