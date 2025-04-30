using Microsoft.AspNetCore.Mvc;
using modul10_103022300109;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul10_103022300109.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //ya bagian ini intinya buat staticnya untuk data yang akan digunakan untuk dianalisis atau dipake lah
    public class MovieController : ControllerBase
    {
        public static List<string> stars1 = new List<string> {
            "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"
        };
        public static List<string> stars2 = new List<string> {
            "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"
        };
        public static List<string> stars3 = new List<string> {
            "Christian Bale", "Heath Ledger", "Michael Caine", "Aaron Eckhart"
        };
        public static List<Movie> movies = new List<Movie>
        {
            new("The Shawshank Redemption", "Frank Darabont", stars1, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict," +
                " while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new("The Godfather", "Francis Ford Coppola", stars2, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new("The Dark Knight", "Christopher Nolan", stars3, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman," +
                " James Gordon and Harvey Dent must work together to put an end to the madness.")

        };

        // GET: api/<MovieController>
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            return movies; //buat ngambil data movies
        }


        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return movies[id];//buat ngambil si data movies berdasarkan idnya
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            movies.Add(value); //nambahin data movies
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movies.RemoveAt(id);//ngehapus data movies berdasarkan id
        }
    }
}



