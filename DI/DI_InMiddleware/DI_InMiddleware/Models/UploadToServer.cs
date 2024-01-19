using Microsoft.AspNetCore.Http;

namespace DI_InMiddleware.Models
{

    public interface IuploadServer
    {
        void Upload(IFormFile file);
    }

    public class UploadToServer : IuploadServer
    {
        public string _ServerIp;
        public string username;
        public string password;

        public UploadToServer(string Ip, string UserFtp,
            string Password, string p1)
        {
            _ServerIp = Ip;
            username = UserFtp;
            password = Password;
        }

        public void Upload(IFormFile file)
        {
            //
        }
    }
}
