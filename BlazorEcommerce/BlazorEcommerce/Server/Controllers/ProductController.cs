using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Title = "Star Wars",
                Description = "Star Wars, conocida también en español como La guerra de las galaxias,7​8​9​ es una franquicia y universo compartido de fantasía compuesta primordialmente de una serie de películas concebidas por el cineasta estadounidense George Lucas en la década de 1970, y producidas y distribuidas inicialmente por 20th Century Fox y posteriormente por The Walt Disney Company a partir de 2012. Su trama describe las vivencias de un grupo de personajes que habitan en una galaxia ficticia e interactúan con elementos como «la Fuerza», un campo de energía metafísico y omnipresente10​ que posee un «lado luminoso» impulsado por la sabiduría, la nobleza y la justicia y utilizado por los Jedi, y un «lado oscuro» usado por los Sith y provocado por la ira, el miedo, el odio y la desesperación.",
                ImageUrl = "https://es.web.img2.acsta.net/r_1280_720/pictures/bzp/01/25802.jpg",
                Price = 9.99
            },
            new Product()
            {
                Id = 2,
                Title = "Star Wars: Episodio IV - Una nueva esperanza",
                Description = "Fue la primera película que se estrenó de la saga Star Wars, y se ordena como la cuarta en términos de su cronología interna: dos filmes siguientes continuarían la trama de la trilogía original (El Imperio contraataca y El retorno del Jedi), mientras que otra trilogía (La amenaza fantasma, El ataque de los clones y La venganza de los Sith) describiría los eventos previos a La guerra de las galaxias, centrada en torno al antagonista principal Darth Vader. ",
                ImageUrl = "https://m.media-amazon.com/images/I/81aA7hEEykL._AC_UF1000,1000_QL80_.jpg",
                Price = 10.99
            },
            new Product()
            {
                Id = 3,
                Title = "Star Wars: Episodio V - El Imperio contraataca",
                Description = "La ficción de la película se sitúa tres años después de la destrucción de la estación espacial de combate conocida como la Estrella de la Muerte, destrucción acaecida al final del episodio anterior, Una Nueva Esperanza, estrenada en el año 1977. En El Imperio contraataca Luke Skywalker, Han Solo, Leia Organa y el resto de la Alianza Rebelde son perseguidos por Darth Vader y las fuerzas de élite del Imperio Galáctico. En este episodio se desarrolla la historia de amor entre Han y Leia, mientras que Luke aprende más sobre los caminos de la Fuerza de la mano del maestro Yoda.",
                ImageUrl = "https://es.web.img2.acsta.net/r_1280_720/pictures/bzp/01/25802.jpg",
                Price = 12.99
            }
        };

        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(Products);
        }
    }
}
