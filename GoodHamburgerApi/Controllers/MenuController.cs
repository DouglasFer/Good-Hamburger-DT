using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoodHamburgerApi.Controllers;

[Authorize]
[ApiController]
[Microsoft.AspNetCore.Components.Route("api/v1/[controller]")]
[ApiExplorerSettings(GroupName = "Erp v1")]
public class MenuController
{
    
}