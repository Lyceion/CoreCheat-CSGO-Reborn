using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections.Generic;

//GITHUB API WRAPPER BY LUFZYS & MRCYLOPS
//PLEASE GIVE CREDITS WHEN YOU ARE USING THIS API.
//https://github.com/Lufzys
//https://github.com/MrCylops
//Github.NET
//Last Update -> 28.08.2019

namespace GithubNET
{
    /// <summary>
    /// Brings Repostry Information Classes.
    /// </summary>
    public class Users
    {
        #region Fields
        private static string Username;
        private static bool IsGettedUserInfo = false;
        private static UserItems User;
        #endregion
        public static void SelectUser(string username)
        {
            if (Username != username)
            {
                Username = username;
                IsGettedUserInfo = false;
            }
            if (!IsGettedUserInfo)
                GetUserInformation();
        }
        private static bool AnyErrorFix()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://www.google.com"))
                {
                    if (Username != string.Empty || Username != null || Username != "")
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.ToString(), "Github.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #region User Information
        private static void GetUserInformation()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            IsGettedUserInfo = true;

            string json = Methods.GetJsonText("https://api.github.com/users/" + Username);
            User = JsonConvert.DeserializeObject<UserItems>(json);
        }
        /// <summary>
        /// Retruns User's Login Name
        /// </summary>
        public static string LoginName
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.Login;
                }
                else
                    return User.Login;
            }
        }
        /// <summary>
        /// ReturnsUser's ID
        /// </summary>
        public static int Id
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.Id;
                }
                else
                    return User.Id;
            }
        }
        /// <summary>
        /// Returns User's Avatar URL
        /// </summary>
        public static string AvatarUrl
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.Avatar_url;
                }
                else
                    return User.Avatar_url;
            }
        }
        /// <summary>
        /// Returns User's Profile URL
        /// </summary>
        public static string ProfileUrl
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.Html_url;
                }
                else
                    return User.Html_url;
            }
        }
        /// <summary>
        /// Returns User's Profile Type
        /// </summary>
        public static string ProfileType
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.Type;
                }
                else
                    return User.Type;
            }
        }
        /// <summary>
        /// Returns User's Profile Name
        /// </summary>
        public static string ProfileName
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.Name;
                }
                else
                    return User.Name;
            }
        }
        /// <summary>
        /// Returns User's Blog Address
        /// </summary>
        public static string Blog
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.Blog;
                }
                else
                    return User.Blog;
            }
        }
        /// <summary>
        /// Returns User's Location Information
        /// </summary>
        public static string Location
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.Location;
                }
                else
                    return User.Location;
            }
        }
        /// <summary>
        /// Returns User's E-Mail Address
        /// </summary>
        public static string Email
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.Email;
                }
                else
                    return User.Email;
            }
        }
        /// <summary>
        /// Returns User's Biography Information
        /// </summary>
        public static string Biography
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.bio;
                }
                else
                    return User.bio;
            }
        }
        /// <summary>
        /// Returns User's Repostory Count
        /// </summary>
        public static int ReposCount
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.Public_repos;
                }
                else
                    return User.Public_repos;
            }
        }
        /// <summary>
        /// Returns User's Follower Count
        /// </summary>
        public static int FollowerCount
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.Followers;
                }
                else
                    return User.Followers;
            }
        }
        #endregion

        #region User Classes

        private class UserItems
        {
            public string Login { get; set; }
            public int Id { get; set; }
            public string Node_id { get; set; }
            public string Avatar_url { get; set; }
            public string Gravatar_id { get; set; }
            public string Url { get; set; }
            public string Html_url { get; set; }
            public string Followers_url { get; set; }
            public string Following_url { get; set; }
            public string Gists_url { get; set; }
            public string Starred_url { get; set; }
            public string Subscriptions_url { get; set; }
            public string Organizations_url { get; set; }
            public string Repos_url { get; set; }
            public string Events_url { get; set; }
            public string Received_events_url { get; set; }
            public string Type { get; set; }
            public bool Site_admin { get; set; }
            public string Name { get; set; }
            public object Company { get; set; }
            public string Blog { get; set; }
            public string Location { get; set; }
            public string Email { get; set; }
            public object Hireable { get; set; }
            public string bio { get; set; }
            public int Public_repos { get; set; }
            public int Public_gists { get; set; }
            public int Followers { get; set; }
            public int Following { get; set; }
            public DateTime Created_at { get; set; }
            public DateTime Updated_at { get; set; }
        }

        #endregion
    }

    /// <summary>
    /// Repo Info Classes.
    /// </summary>
    public class Repository
    {

        #region Fields
        private static string ReposName;
        private static bool IsGettedReposInfo = false;
        private static ReposItems Repos;
        #endregion

        public static void SelectRepository(string reposName)
        {
            if (ReposName != reposName)
            {
                ReposName = reposName;
                IsGettedReposInfo = false;
            }
            if (!IsGettedReposInfo)
                GetReposInformation();
        }
        private static bool AnyErrorFix()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://www.google.com"))
                {
                    if (Users.LoginName != string.Empty || Users.LoginName != null || Users.LoginName != "" || ReposName != string.Empty || ReposName != null || ReposName != "")
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.ToString(), "Github.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #region Repository Information

        private static void GetReposInformation()
        {
            IsGettedReposInfo = true;
            string json = Methods.GetJsonText("https://api.github.com/repos/" + Users.LoginName + "/" + ReposName + "/releases/latest");
            Repos = JsonConvert.DeserializeObject<ReposItems>(json);
        }
        /// <summary>
        /// Returns Repostory's ID
        /// </summary>
        public static int Id
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.id;
                }
                else
                    return Repos.id;
            }
        }
        /// <summary>
        /// Returns Repostory's Name
        /// </summary>
        public static string Name
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.name;
                }
                else
                    return Repos.name;
            }
        }
        /// <summary>
        /// Returns Repostory's Tag
        /// </summary>
        public static string Tag
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.tag_name;
                }
                else
                    return Repos.tag_name;
            }
        }
        /// <summary>
        /// Returns Repostory's File Name
        /// </summary>
        public static string FileName
        {
            get
            {
                var a = string.Empty;
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                        a = Assets.name;
                    return a;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                        a = Assets.name;
                    return a;
                }
            }
        }
        /// <summary>
        /// Returns Repostory's Author's ID
        /// </summary>
        public static int AuthorId
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.author.id;
                }
                else
                    return Repos.author.id;
            }
        }
        /// <summary>
        /// Returns Repostory's Author's Name
        /// </summary>
        public static string AuthorName
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.author.login;
                }
                else
                    return Repos.author.login;
            }
        }
        /// <summary>
        /// Returns Repostory's Author's Avatar URL
        /// </summary>
        public static string AuthorAvatarUrl
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.author.avatar_url;
                }
                else
                    return Repos.author.avatar_url;
            }
        }
        /// <summary>
        /// Returns Repostory's Last Uploader's ID
        /// </summary>
        public static int LastUploaderId
        {
            get
            {
                var a = 0;
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                        a = Assets.uploader.id;
                    return a;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                        a = Assets.uploader.id;
                    return a;
                }
            }
        }
        /// <summary>
        /// Returns Repostory's Last Uploader's Name
        /// </summary>
        public static string LastUploaderName
        {
            get
            {
                var a = string.Empty;
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                        a = Assets.uploader.login;
                    return a;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                        a = Assets.uploader.login;
                    return a;
                }
            }
        }
        /// <summary>
        /// Returns Repostory's Last Uploader's Avatar URL
        /// </summary>
        public static string LastUploaderAvatarUrl
        {
            get
            {
                var a = string.Empty;
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                        a =  Assets.uploader.avatar_url;
                    return a;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                        a = Assets.uploader.avatar_url;
                    return a;
                }
            }
        }
        /// <summary>
        /// Returns Repostory's Last Release's URL
        /// </summary>
        public static string LatestReleasesUrl
        {
            get
            {
                var a = string.Empty;
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                        a = Assets.browser_download_url;
                    return a;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                        a = Assets.browser_download_url;
                    return a;
                }
            }
        }
        /// <summary>
        /// Returns Repostory's Source's .ZIP File
        /// </summary>
        public static string SourceZip
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.zipball_url;
                }
                else
                    return Repos.zipball_url;
            }
        }
        /// <summary>
        /// Returns Repostory's Source's .TAR File
        /// </summary>
        public static string SourceTar
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.tarball_url;
                }
                else
                    return Repos.tarball_url;
            }
        }
        /// <summary>
        /// Returns Repostory's Dwonload Count
        /// </summary>
        public static int DownloadCount
        {
            get
            {
                var a = 0;
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                        a = Assets.download_count;
                    return a;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                        a = Assets.download_count;
                    return a;
                }
            }
        }
        /// <summary>
        /// Returns Repostory's File's Size
        /// </summary>
        public static string FileSize
        {
            get
            {
                var a = string.Empty;
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                        a = Methods.FormatBytes(Assets.size);
                    return a;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                        a = Methods.FormatBytes(Assets.size);
                    return a;
                }
            }
        }

        #endregion

        #region Repository Classes
        private class Author
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
        }

        private class Uploader
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
        }

        private class Asset
        {
            public string url { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string name { get; set; }
            public object label { get; set; }
            public Uploader uploader { get; set; }
            public string content_type { get; set; }
            public string state { get; set; }
            public int size { get; set; }
            public int download_count { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public string browser_download_url { get; set; }
        }

        private class ReposItems
        {
            public string url { get; set; }
            public string assets_url { get; set; }
            public string upload_url { get; set; }
            public string html_url { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string tag_name { get; set; }
            public string target_commitish { get; set; }
            public string name { get; set; }
            public bool draft { get; set; }
            public Author author { get; set; }
            public bool prerelease { get; set; }
            public DateTime created_at { get; set; }
            public DateTime published_at { get; set; }
            public IList<Asset> assets { get; set; }
            public string tarball_url { get; set; }
            public string zipball_url { get; set; }
            public string body { get; set; }
        }

        #endregion
    }

    /// <summary>
    /// General Methods.
    /// </summary>
    internal class Methods
    {
        /// <summary>
        /// Gets JSON To Inside as Text.
        /// </summary>
        /// <param name="JSON"></param>
        /// <returns>JSON as Plaint Text.</returns>
        public static string GetJsonText(string JSON)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(JSON);
            myHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.77 Safari/537.36";
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Stream streamResponse = myHttpWebResponse.GetResponseStream();
            using (StreamReader r = new StreamReader(streamResponse))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }
        /// <summary>
        /// Converts bytes to Size Format.
        /// </summary>
        /// <param name="Bytes"></param>
        /// <returns>File's byte size.</returns>
        public static string FormatBytes(long Bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = Bytes;
            for (i = 0; i < Suffix.Length && Bytes >= 1024; i++, Bytes /= 1024)
                dblSByte = Bytes / 1024.0;
            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }
    }
}
