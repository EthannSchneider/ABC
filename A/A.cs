namespace ABC
{
    public class A
    {
        public A()
        {

        }
        public String OpenDay()
        {
            return "Les portes ouverte du CPNV sont le " + DateTime.Today.ToString();
        }
        public override string ToString()
        {
            return "Coucou je suis A";
        }
    }
}