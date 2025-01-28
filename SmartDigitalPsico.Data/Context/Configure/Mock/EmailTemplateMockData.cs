using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class EmailTemplateMockData
    {
        public static EmailTemplate[] GetMock()
        {
            return [
                new EmailTemplate
                {
                    Id = 1,
                    Enable = true,
                    Language = EntityTypeConfigurationConstants.Language_Default_PTBR,
                    Description = "Welcome Email",
                    Subject ="Access Granted",
                    Body = @"<html>
<head>
    <style>
        body {{ font-family: Arial, sans-serif; background-color: #f4f4f9; color: #333; padding: 20px; }}
        .container {{ max-width: 600px; margin: 0 auto; background-color: #fff; padding: 20px; border-radius: 10px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); }}
        .header {{ text-align: center; padding-bottom: 20px; }}
        .header h1 {{ margin: 0; color: #4CAF50; }}
        .content {{ line-height: 1.6; }}
        .footer {{ text-align: center; padding-top: 20px; font-size: 0.9em; color: #777; }}
    </style>
</head>
<body>
    <div class='container'>
        <div class='header'>
            <h1>Access Granted</h1>
        </div>
        <div class='content'>
            <p>Hello,</p>
            <p>Your access has been granted. Below are your login details:</p>
            <p><strong>URL:</strong> <a href='[{AccessUrl}]'>[{AccessUrl}]</a></p>
            <p><strong>Email:</strong> [{Email}]</p>
            <p><strong>Temporary Password:</strong> [{Password}]</p>
            <p>Please change your password after your first login.</p>
        </div>
        <div class='footer'>
            <p>Thank you for joining us!</p>
        </div>
    </div>
</body>
</html>",                    
                    CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                    ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                    LastAccessDate = DateHelper.GetDateTimeNowFromUtc()
            } ];
        }
    }
}