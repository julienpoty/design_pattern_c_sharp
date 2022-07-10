namespace Models.Entities;

public class ClientMessageContext
{
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string UserTag { get; set; }
    public Dictionary<string, string> Data { get; set; } = new();
    public ClientPreferences Preferences { get; set; } = new();
}

public class ClientPreferences
{
   public bool AcceptEmail { get; set; }
   public bool AcceptSms { get; set; }
   public bool AcceptNotification { get; set; }
}