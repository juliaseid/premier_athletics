using System.Threading.Tasks;
using RestSharp;


namespace PremierAthletics.Models
{
  class HelloSignAPI
  {
    public static Task CreateSignatureRequest(Document document, Athlete athlete)
    //TODO: Add error handling 
    {
      var client = new HelloSign.Client(Keys.APIKey);
      var request = new HelloSign.SignatureRequest();
        request.Title = document.Title;
        request.Subject = document.Subject;
        request.Message = document.Message;
        request.AddSigner(athlete.Email, athlete.FirstName);
        request.AddCc("manager@example.com");
        request.AddCc("lawyer@premierathletics.com");
        request.AddFile(document.Filepath);
        request.TestMode = true;
      var response = client.CreateEmbeddedSignatureRequest(request, "e96dbd1624c7bb441a265d5b456a11c6");
    }
  }
}