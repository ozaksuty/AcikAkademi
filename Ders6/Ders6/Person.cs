namespace Ders6
{
    public class Person
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return UserName;
        }
    }
}