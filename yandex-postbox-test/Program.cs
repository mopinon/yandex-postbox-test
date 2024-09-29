using Amazon.SimpleEmailV2;
using Amazon.SimpleEmailV2.Model;

var awsAccessKeyId = "";
var awsSecretAccessKey = "";
var postboxUrl = "https://postbox.cloud.yandex.net";

var toAddresses = "";
var sourceEmail = "";


using var client = new AmazonSimpleEmailServiceV2Client(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleEmailServiceV2Config()
{
    ServiceURL = postboxUrl,
    AuthenticationRegion = "ru-central1"

});

var response = await client.SendEmailAsync(new SendEmailRequest
{
    Destination = new Destination
    {
        ToAddresses = [toAddresses],
    },
    Content = new EmailContent
    {
        Simple = new Message
        {
            Subject = new Content
            {
                Data = "Тема"
            },
            Body = new Body
            {
                Text = new Content
                {
                    Data = "Ваш код: 1234"
                }
            },
        }
    },
    FromEmailAddress = sourceEmail,
});





