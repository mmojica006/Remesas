
using System;
using System.DirectoryServices;
using System.Text;

namespace Helper
{
    public class ServicioActiveDirectory
    {
        private const string dominio = "crediexpress.local";
        private const string domain = "crediexpress";
        private String _path;
        private String _filterAttribute;

 

        public void Autenticar(string usuario, string contrasena)
        {
            var tipoAutenticacion =
                AuthenticationTypes.None | AuthenticationTypes.FastBind;

            var identificador =
                string.Format("CN={0},OU=ADAM users,DC=prueba,DC=adam", usuario);

            using (var entry =
                new DirectoryEntry("LDAP://" + dominio + "/OU=ADAM users,DC=crediexpress,DC=local",
                    identificador,
                    contrasena,
                    tipoAutenticacion))
            {
                object nativeObject = entry.NativeObject;
            }
        }

        public void CambiarContrasena(string usuario, string contrasenaAntigua, string contrasenaNueva)
        {
            var dn =
                string.Format("LDAP://localhost:389/CN={0},OU=ADAM users,DC=prueba,DC=adam", usuario);

            var tipoAutenticacion =
                AuthenticationTypes.Signing | AuthenticationTypes.Sealing
                | AuthenticationTypes.Secure;

            using (var entry = new DirectoryEntry(dn, null, null, tipoAutenticacion))
            {

                entry.RefreshCache();

                entry.Options.PasswordPort = 389;
                entry.Options.PasswordEncoding = PasswordEncodingMethod.PasswordEncodingClear;
                ;

                entry.Invoke("ChangePassword", new object[] {contrasenaAntigua, contrasenaNueva});

                entry.CommitChanges();
            }
        }

        public void ResetearContrasena(string usuario, string contrasenaNueva)
        {
            var dn =
                string.Format("LDAP://localhost:389/CN={0},OU=ADAM users,DC=prueba,DC=adam", usuario);

            var tipoAutenticacion =
                AuthenticationTypes.Signing | AuthenticationTypes.Sealing
                | AuthenticationTypes.Secure;

            using (var entry = new DirectoryEntry(dn, null, null, tipoAutenticacion))
            {

                entry.RefreshCache();

                entry.Options.PasswordPort = 389;
                entry.Options.PasswordEncoding = PasswordEncodingMethod.PasswordEncodingClear;
                ;

                entry.Invoke("SetPassword", new object[] { contrasenaNueva });

                entry.CommitChanges();
            }
        }

        public void ObtenerInformacionUsuario(string nombreUsuario)
        {
            using (var entryRoot = new DirectoryEntry("LDAP://localhost:389/OU=ADAM users,DC=prueba,DC=adam"))
            {
                using (var buscadorDirectorio = new DirectorySearcher(entryRoot))
                {

                    buscadorDirectorio.Filter =
                        string.Format("(&(objectCategory=person)(objectClass=user)(cn={0}))", nombreUsuario);

                    buscadorDirectorio.PropertiesToLoad.Add("businessCategory");
                    buscadorDirectorio.PropertiesToLoad.Add("url");
                    buscadorDirectorio.PropertiesToLoad.Add("mail");
                    buscadorDirectorio.PropertiesToLoad.Add("company");
                    buscadorDirectorio.PropertiesToLoad.Add("name");
                    buscadorDirectorio.PropertiesToLoad.Add("distinguishedName");

                    SearchResult resultado = buscadorDirectorio.FindOne();

                    Console.WriteLine("DistinguishedName: {0}", resultado.Properties["distinguishedName"][0]);
                    Console.WriteLine("BusinessCategory: {0}", resultado.Properties["businessCategory"][0]);
                    Console.WriteLine("Url: {0}", resultado.Properties["url"][0]);
                    Console.WriteLine("Mail: {0}", resultado.Properties["mail"][0]);
                    Console.WriteLine("Company: {0}", resultado.Properties["company"][0]);
                    Console.WriteLine("Name: {0}", resultado.Properties["name"][0]);
                }
            }
        }

        public bool existeUsuario(string username)
        {
            bool respuesta = true;

            DirectoryEntry directoryEntry = new DirectoryEntry(string.Format("LDAP://crediexpress.local/DC=crediexpress, DC=local"));
            DirectorySearcher _dSearch = new DirectorySearcher(directoryEntry, string.Format("(SAMAccountName={0})", username));
            SearchResult _result = _dSearch.FindOne();
            if (_result != null)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;

        }


        public bool IsAuthenticated(String username, String pwd)
        {
            string path = "LDAP://crediexpress.local/DC=crediexpress, DC=local";
            String domainAndUsername = domain + @"\" + username;
            DirectoryEntry entry = new DirectoryEntry(path, domainAndUsername, pwd);

            try
            {	//Bind to the native AdsObject to force authentication.			
                Object obj = entry.NativeObject;

                DirectorySearcher search = new DirectorySearcher(entry);

                search.Filter = "(SAMAccountName=" + username + ")";
                search.PropertiesToLoad.Add("cn");
                SearchResult result = search.FindOne();

                if (null == result)
                {
                    return false;
                }

                //Update the new path to the user in the directory.
                _path = result.Path;
                _filterAttribute = (String)result.Properties["cn"][0];

            }
            catch (Exception ex)
            {
               // throw new Exception("Error autenticando usuario. " + ex.Message);
                return false;
            }

            return true;
        }

        public String GetGroups()
        {

            responseResult respuesta = new responseResult();
            //DirectorySearcher search = new DirectorySearcher(_path);
            DirectorySearcher search = new DirectorySearcher("LDAP://crediexpress.local/DC=crediexpress, DC=local");
            search.Filter = "(cn=" + _filterAttribute + ")";
            search.PropertiesToLoad.Add("memberOf");
            StringBuilder groupNames = new StringBuilder();

            try
            {
                SearchResult result = search.FindOne();

                int propertyCount = result.Properties["memberOf"].Count;

                String dn;
                int equalsIndex, commaIndex;

                for (int propertyCounter = 0; propertyCounter < propertyCount; propertyCounter++)
                {
                    dn = (String)result.Properties["memberOf"][propertyCounter];

                    equalsIndex = dn.IndexOf("=", 1);
                    commaIndex = dn.IndexOf(",", 1);
                    if (-1 == equalsIndex)
                    {
                        return null;
                    }

                    groupNames.Append(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1));
                    groupNames.Append("|");

                }
                respuesta.response = true;
                respuesta.message = groupNames.ToString();

            }
            catch (Exception ex)
            {
                respuesta.ErrorMessage = ex.Message;
                respuesta.response = false;
                throw new Exception("Error obteniendo grupo de nombres . " + ex.Message + " " + groupNames.ToString());

            }
            return groupNames.ToString();
        }

        public bool IsUserInGroup(string username, string groupepath)
        {
            string path = "LDAP://localhost:389/CN={0},OU=ADAM users,DC=prueba,DC=adam";

            DirectoryEntry rootEntry = new DirectoryEntry(path);

            DirectorySearcher srch = new DirectorySearcher(rootEntry);
            srch.SearchScope = SearchScope.Subtree;

            srch.Filter = "(&(objectClass=user)(sAMAccountName=*" + username + "*)(memberof=CN=GastzugangUser,OU=SubFolderB,OU=FolderB,DC=company,DC=com))";


            SearchResultCollection res = srch.FindAll();

            if (res == null || res.Count <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        //Checks to see if a user is in a group and returns a bool



    }
}
