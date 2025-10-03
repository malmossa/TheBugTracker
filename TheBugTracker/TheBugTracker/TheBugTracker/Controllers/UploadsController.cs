using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using TheBugTracker.Data;
using TheBugTracker.Models;

[Route("uploads")]
[ApiController]
public class UploadsController(ApplicationDbContext context) : ControllerBase
{
    [HttpGet("{id:guid}")]
    [OutputCache(VaryByRouteValueNames = ["id"], Duration = 60 * 60 * 24)]
    public async Task<IActionResult> GetImage(Guid id)
    {
        FileUpload? image = await context.Images.FirstOrDefaultAsync(i => i.Id == id);

        if (image is null) return NotFound();

        return File(image.Data!, image.Type!);
    }
}