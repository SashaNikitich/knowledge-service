namespace KnowledgeService.Settings;

public class AuthorizationSettings : IAuthorizationSettings
{
  public string SigningKey { get; set; }
  public string EncryptionKey { get; set; }
  public int ExpirationTimeInHours { get; set; }
}
