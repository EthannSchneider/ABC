namespace ABC
{
    public class D : A
    {
        public D()
        {

        }
        
        public String OpenDay()
        {
            return base.OpenDay() + " et on attend 15'000 personne";
        }
    }
}