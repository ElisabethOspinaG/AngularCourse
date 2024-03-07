namespace TestApi.Services
{
    public class TestService
    {
        public string IsOlderThan18(int age)
        {
            if(age > 18)
            {
                return "is older than 18";
            }
            else
            {
                return "is NOT older than 18";
            }
        }
    }
}
