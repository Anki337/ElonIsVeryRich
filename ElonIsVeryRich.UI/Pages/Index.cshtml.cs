using ElonIsVeryRich.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace ElonIsVeryRich.UI.Pages
{
    public class IndexModel : PageModel
    {
        public List<RootRocketModel?> RocketModels { get; set; } = new();
        public List<RootModel?> Launches { get; set; } = new();
        public async Task OnGet()
        {
            List<RootModel?> roots = await new DataAccess().GetLaunchData();
            List<RootRocketModel?> rockets = await new DataAccess().GetRocketData();

            if (roots != null)
            {
                Launches.AddRange(roots);
            }
            if (rockets != null)
            {
                RocketModels.AddRange(rockets);
            }   
        }
    }
}
