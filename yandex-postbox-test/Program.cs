using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;

var awsAccessKeyId = "";
var awsSecretAccessKey = "";
var postboxUrl = "https://postbox.cloud.yandex.net";

var toAddresses = "";
var sourceEmail = "";


using var client = new AmazonSimpleEmailServiceClient(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceConfig
{
    ServiceURL = postboxUrl
});

var response = await client.SendEmailAsync(new SendEmailRequest
{
    Destination = new Destination([toAddresses]),
    Message = new Message(new Content("Тема"), new Body(new Content("Hello World!"))),
    Source = sourceEmail,
});