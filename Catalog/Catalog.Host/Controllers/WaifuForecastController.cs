using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[ApiController]
[Route("[controller]")]
public class WaifuForecastController : ControllerBase
{
    private static readonly WaifuForecast[] _party = 
    {
        new WaifuForecast { Name = "Kristina",
        DateOfBirth = new DateTime(2023,02,13),
        Image = "will be add in future"
        },
        new WaifuForecast { Name = "Albedo",
        DateOfBirth = new DateTime(2012,07,30),
        Image = "https://static.wikia.nocookie.net/overlordanime/images/6/60/Albedo_Profile.png/revision/latest?cb=20180916105542&path-prefix=ru"
        },
        new WaifuForecast { Name = "Shalltear",
        DateOfBirth = new DateTime(2012, 07, 30),
        Image = "https://static.wikia.nocookie.net/overlordmaruyama/images/f/fe/Shalltear_Anime_Updated.png/revision/latest/scale-to-width-down/1000?cb=20220209052132"
        },
    };

    private readonly ILogger<WaifuForecastController> _logger;

    public WaifuForecastController(ILogger<WaifuForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<WaifuForecast> Get()
    {
        return Enumerable.Range(0, 3).Select(index => new WaifuForecast
        {
            Name = _party[index].Name,
            DateOfBirth = _party[index].DateOfBirth,
            Image = _party[index].Image,
        })
            .ToArray();
    }
}