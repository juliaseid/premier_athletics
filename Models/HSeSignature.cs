using System.Threading.Tasks;
using RestSharp;


namespace PremierAthletics.Models
{
  public class HSeSignature
  {
    public string HSeSignatureId {get; set;}
    public string SignatureRequestID {get; set;}
    public string DocumentId {get; set;}
    public Document Document {get; set;}
    public string AthleteId {get; set;}
    public Athlete Athlete {get; set;}
    public static Task CreateEmbeddedSignatureRequest(Document document, Athlete athlete)
    //TODO: Add error handling 
    {
      var client = new HelloSign.Client(Keys.APIKey);
      var request = new HelloSign.SignatureRequest();
        request.Title = document.Title;
        request.Subject = document.Subject;
        request.Message = document.Message;
        request.AddSigner(athlete.Email, athlete.FirstName);
        request.AddCc("manager@premierathletics.com");
        request.AddFile(document.Filepath);
        request.TestMode = true;
      var response = client.CreateEmbeddedSignatureRequest(request, Keys.ClientID);
      return Task.FromResult(response);
    }

    public static Task GetSignURL(HSeSignature signatureRequest)
    {
      var client = new HelloSign.Client(Keys.APIKey);
      var response = client.GetSignUrl(signatureRequest.SignatureRequestID);
      return Task.FromResult(response); 
    }

    public static Task GetSignatureRequest(HSeSignature signatureRequest)
    {
      var client = new HelloSign.Client(Keys.APIKey);
      var response = client.GetSignatureRequest(signatureRequest.SignatureRequestID);
      return Task.FromResult(response);
    }


  }
}