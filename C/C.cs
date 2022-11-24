using System.Security.Claims;

namespace ABC
{
    public class C : A
    {        
        public C()
        {
            
        }
        public String OpenDay()
        {
            return base.OpenDay().Split(" le ")[0]+"... bof. je n'y vais pas !";
        }
        
        public override string ToString()
        {
            return "Je suis malade avec un certificat!";
        }
    }
}