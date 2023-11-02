using Entity_Framework.Interfaces;

namespace Entity_Framework.Managers
{
    public class SBI : IBank
    {
        public string createAcountHolder()
        {
            return "SBI Acount";
        }
    }
}
