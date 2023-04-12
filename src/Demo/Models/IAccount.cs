namespace Demo.Models
{
    [InterfaceType("Account")]
    public interface IAccount
    {
        public string AccessNumber { get; set; }
    }
}
