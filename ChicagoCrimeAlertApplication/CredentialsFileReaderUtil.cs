using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChicagoCrimeAlertApplication
{
    class CredentialsFileReaderUtil
    {
        private CredentialsFileReaderUtil() { /*Hiding constructor, since this will be a utility class.*/}

        //We will keep the credentialsFile.txt in the root directory, named "credentialsFile.txt"
        private const String CREDENTIALS_FILE_LOCATION = "../../credentialsFile.txt";

        /**
         * A method for retrieving sensitive credentials from a privately shared file ('credentialsFile.txt)'.
         * The `credentialsFile.txt` file is organized suh that each row contains a sensitive data item in
         * a key/value pair format, separated by a single space -- as shown below:
         * 
         * <key> <value>
         * <key> <value>
         * <key> <value>
         * 
         * In the example below, 'myUsername' is the `key` for the `value` `username1234`.
         * `myPassword` is the key for `password1234`.
         * 
         * myUsername username1234
         * myPassword password1234
         * 
         * This scheme keeps secret credentials safe given that the key can be publicly visible in the
         * source code, but only the `credentialsFile.txt` file will know the correct value to return.
         * 
         * The method will receive the key value for a sensitive data item.
         * **/
        public static String retrieveFromCredentialsFile(String credentialKey) {

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(CREDENTIALS_FILE_LOCATION);

            //`credential` will store the mapped value of the given key
            String credential = "";

            //iterate through each line in the file and check to see if a key matches the specified key.
            foreach (string line in lines)
            {
                if (!line.Equals("")) { //Ignoring blank lines.
                    string[] keyValuePair = line.Split(' '); //space is the delimiter
                    string key = keyValuePair[0];
                    string value = keyValuePair[1];

                    if (key.Equals(credentialKey))
                    {
                        credential = value;
                        break; //no need to keep checking the rest of the file, so breaking out of loop.
                    }
                }
            }

            return credential;
        }
    }
}
