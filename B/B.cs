namespace ABC
{
    public class B : A
    {

        public B()
        {

        }

        public String OpenDay()
        {
            return base.OpenDay() + " heu non, dans 2 jours";
        }

        public override string ToString()
        {
            return base.ToString() + ", et B";
            
        }
    }
}