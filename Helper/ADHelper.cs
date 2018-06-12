using System;
using System.DirectoryServices;

namespace Helper
{
    public class ADHelper
    {

        private string username;
        private string password;
        public string domain;

        public ADHelper(string username, string password, string domain)
        {
            this.username = username;
            this.password = password;
            this.domain = domain;
        }

        //Looks up the DN for a user based on the sAMAccountName
        public string GetUserDN(string identity)
        {
            //Split out the identity to get just the username portion
            if (identity.Contains("\\"))
            {
                string[] identityList = identity.Split('\\');
                string userName = identityList[1];
                using (var rootEntry = new DirectoryEntry("LDAP://" + domain, this.username, this.password, AuthenticationTypes.Secure))
                {
                    using (var directorySearcher = new DirectorySearcher(rootEntry, String.Format("(sAMAccountName={0})", userName)))
                    {
                        var searchResult = directorySearcher.FindOne();
                        if (searchResult != null)
                        {
                            using (var userEntry = searchResult.GetDirectoryEntry())
                            {
                                return (string)userEntry.Properties["distinguishedName"].Value;
                            }
                        }
                    }
                }
            }
            return null;
        }


        //Looks up the DN for the group based on the name
        public string GetGroupDN(string groupname)
        {
            using (var rootEntry = new DirectoryEntry("LDAP://" + domain, this.username, this.password, AuthenticationTypes.Secure))
            {
                using (var directorySearcher = new DirectorySearcher(rootEntry, String.Format("(&(objectCategory=group)(cn={0}))", groupname)))
                {
                    var searchResult = directorySearcher.FindOne();
                    if (searchResult != null)
                    {
                        using (var userEntry = searchResult.GetDirectoryEntry())
                        {
                            return (string)userEntry.Properties["distinguishedName"].Value;
                        }
                    }
                }
            }
            return null;
        }



        //Checks to see if a user is in a group and returns a bool
        public bool isUserInGroup(string userDn, string groupDn)
        {
            bool match = false;


            DirectoryEntry user = new DirectoryEntry("LDAP://" + userDn, this.username, this.password, AuthenticationTypes.Secure);
            foreach (string group in user.Properties["memberof"])
                if (group == groupDn)
                    match = true;

            return match;
        }


        //Adds a given user to a group 
        public bool AddToGroup(string userDn, string groupDn)
        {
            bool success = false;
            try
            {
                DirectoryEntry dirEntry = new DirectoryEntry("LDAP://" + groupDn, this.username, this.password, AuthenticationTypes.Secure);
                dirEntry.Properties["member"].Add(userDn);
                dirEntry.CommitChanges();
                dirEntry.Close();
                success = true;
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException ex)
            {
                success = false;
            }

            return success;
        }

        //Removes a user from a group
        public bool RemoveUserFromGroup(string userDn, string groupDn)
        {
            bool success = false;
            try
            {
                DirectoryEntry dirEntry = new DirectoryEntry("LDAP://" + groupDn);
                dirEntry.Properties["member"].Remove(userDn);
                dirEntry.CommitChanges();
                dirEntry.Close();
                success = true;
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException ex)
            {

                success = false;
            }
            return success;
        }
    }
}