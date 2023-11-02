using Entity_Framework.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

namespace Entity_Framework.Managers
{
    [ApiController]
    public class BankManagerController : ControllerBase
    {
        readonly public Interfaces.IBank _IBank;
       
        public BankManagerController(Interfaces.IBank iBank)
        {
            _IBank = iBank;
        }
        [Microsoft.AspNetCore.Mvc.Route("Test/[action]")]
        public void testmethod([FromServices] IBank bank)
        {
           Response.WriteAsync(bank.createAcountHolder());

        }
    }
}
