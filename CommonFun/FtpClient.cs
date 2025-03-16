using System.Net;

namespace CommonFun;

public class FtpClient
{
    public  void Download(string ftpServer, string ftpFilePath, string username, string password, string localFilePath)
    {
        //ftpServer = "ftp://example.com"; // Replace with your FTP server address
        //ftpFilePath = "/path/to/remote/file.txt"; // Remote file path on the server
        //localFilePath = @"C:\path\to\local\file.txt"; // Local file path
        try
        {
            // Create an FTP request to download the file
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer + ftpFilePath);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // Provide credentials
            request.Credentials = new NetworkCredential(username, password); // Replace with your FTP credentials
            request.UseBinary = true; // Set to true if you want binary transfer (for non-text files)
            request.UsePassive = true; // Set to true for passive mode
            request.KeepAlive = false; // Set to false to close the connection after the transfer

            // Get the response from the FTP server
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (FileStream fileStream = new FileStream(localFilePath, FileMode.Create))
            {
                // Read data from the response stream and write it to the local file
                responseStream.CopyTo(fileStream);
                Console.WriteLine($"Download Complete, status {response.StatusDescription}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error uploading file: " + ex.Message);
        }
    }

    public  void upload(string ftpServer, string ftpFilePath, string username, string password, string localFilePath)
    {
        //ftpServer = "ftp://example.com"; // Replace with your FTP server address
        //ftpFilePath = "/path/to/remote/file.txt"; // Remote file path on the server
        //localFilePath = @"C:\path\to\local\file.txt"; // Local file path
        try
        {
            // Create an FTP request to upload the file
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer + ftpFilePath);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // Provide credentials
            request.Credentials = new NetworkCredential(username, password); // Replace with your FTP credentials
            request.UseBinary = true; // Set to true if you want binary transfer (for non-text files)
            request.UsePassive = true; // Set to true for passive mode
            request.KeepAlive = false; // Set to false to close the connection after the transfer

            // Read the local file into a byte array
            byte[] fileContents = File.ReadAllBytes(localFilePath);

            // Upload the file
            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }

            // Get the response from the FTP server
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"Upload Complete, status {response.StatusDescription}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error uploading file: " + ex.Message);
        }
    }

    // Method to rename a file on the FTP server
    public  void RenameFileOnFTP(string ftpServer, string oldFilePath, string newFilePath)
    {
        try
        {
            // Create an FTP request to rename the file
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer + oldFilePath);
            request.Method = WebRequestMethods.Ftp.Rename;

            // Provide credentials
            request.Credentials = new NetworkCredential("username", "password"); // Replace with your FTP credentials
            request.RenameTo = newFilePath; // Specify the new name for the file

            // Get the response from the FTP server
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"Rename Complete, status: {response.StatusDescription}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error renaming file: " + ex.Message);
        }
    }

    public bool FileExistsOnFTP(string ftpServer, string remoteFilePath, string username, string password)
    {
        try
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer + remoteFilePath);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            // Provide credentials
            request.Credentials = new NetworkCredential(username, password); // Replace with your FTP credentials
            request.UsePassive = true;
            request.KeepAlive = false;

            // Try to get the file size to check if the file exists
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                return response.StatusCode == FtpStatusCode.FileActionOK;
            }
        }
        catch (WebException)
        {
            // If the file does not exist or other errors occur, return false
            return false;
        }
    }
}
