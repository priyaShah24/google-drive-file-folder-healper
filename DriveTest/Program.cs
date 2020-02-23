
using System;

namespace DriveTest
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string jsonCredFilePath = @"C:\Users\priya\Downloads\credentials.json";
            var service = GoogleDriveSeviceHelper.AuthenticateOauth(jsonCredFilePath, "User");
            var files = GoogleDriveSeviceHelper.ListFiles(service);
            var folders = GoogleDriveSeviceHelper.ListFiles(service, new FilesListOptionalParms { Q = "mimeType = 'application/vnd.google-apps.folder'" });
            //application/vnd.google-apps.folder
            //DriveId = "1gSw2S10ysii23lO_xuQgnj6J3C1zuW2H"



            var request = service.Files.List();
            request.Q = "name='DriveTest'";
            var result = await request.ExecuteAsync();

            foreach (var file in result.Files)
            {
                //await DownloadFile(file.Id, service);
            }

            Console.WriteLine("Hello World!");


        }
    }
}
