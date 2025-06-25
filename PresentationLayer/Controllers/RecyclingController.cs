using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using SürdürülebilirTürkiye.DataAccessLayer;
using System;
using System.Linq;

public class RecyclingController : Controller
{
    private readonly Context _context;

    public RecyclingController(Context context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var city = _context.Cities
            .Where(c => c.IsMapped)
            .Select(c => new City
            {
                CityID = c.CityID,
                CityName = c.CityName,
                Latitude = c.Latitude,
                Longitude = c.Longitude

            })
            .ToList();

        return View(city);
    }
}
