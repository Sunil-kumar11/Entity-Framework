using Entity_Framework.Interfaces;

namespace Entity_Framework.Managers
{
    public class Icici : IBank
    {
        public string createAcountHolder()
        {
           return "Icic Bank";
        }
    }
}
