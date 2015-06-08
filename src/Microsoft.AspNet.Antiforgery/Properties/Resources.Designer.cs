// <auto-generated />
namespace Microsoft.AspNet.Antiforgery
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Antiforgery.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The provided identity of type '{0}' is marked IsAuthenticated = true but does not have a value for Name. By default, the anti-forgery system requires that all authenticated identities have a unique Name. If it is not possible to provide a unique Name for this identity, consider extending IAdditionalDataProvider by overriding the DefaultAdditionalDataProvider or a custom type that can provide some form of unique identifier for the current user.
        /// </summary>
        internal static string AntiForgeryTokenValidator_AuthenticatedUserWithoutUsername
        {
            get { return GetString("AntiForgeryTokenValidator_AuthenticatedUserWithoutUsername"); }
        }

        /// <summary>
        /// The provided identity of type '{0}' is marked IsAuthenticated = true but does not have a value for Name. By default, the anti-forgery system requires that all authenticated identities have a unique Name. If it is not possible to provide a unique Name for this identity, consider extending IAdditionalDataProvider by overriding the DefaultAdditionalDataProvider or a custom type that can provide some form of unique identifier for the current user.
        /// </summary>
        internal static string FormatAntiForgeryTokenValidator_AuthenticatedUserWithoutUsername(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiForgeryTokenValidator_AuthenticatedUserWithoutUsername"), p0);
        }

        /// <summary>
        /// The provided anti-forgery token failed a custom data check.
        /// </summary>
        internal static string AntiForgeryToken_AdditionalDataCheckFailed
        {
            get { return GetString("AntiForgeryToken_AdditionalDataCheckFailed"); }
        }

        /// <summary>
        /// The provided anti-forgery token failed a custom data check.
        /// </summary>
        internal static string FormatAntiForgeryToken_AdditionalDataCheckFailed()
        {
            return GetString("AntiForgeryToken_AdditionalDataCheckFailed");
        }

        /// <summary>
        /// The provided anti-forgery token was meant for a different claims-based user than the current user.
        /// </summary>
        internal static string AntiForgeryToken_ClaimUidMismatch
        {
            get { return GetString("AntiForgeryToken_ClaimUidMismatch"); }
        }

        /// <summary>
        /// The provided anti-forgery token was meant for a different claims-based user than the current user.
        /// </summary>
        internal static string FormatAntiForgeryToken_ClaimUidMismatch()
        {
            return GetString("AntiForgeryToken_ClaimUidMismatch");
        }

        /// <summary>
        /// The required anti-forgery cookie "{0}" is not present.
        /// </summary>
        internal static string AntiForgeryToken_CookieMissing
        {
            get { return GetString("AntiForgeryToken_CookieMissing"); }
        }

        /// <summary>
        /// The required anti-forgery cookie "{0}" is not present.
        /// </summary>
        internal static string FormatAntiForgeryToken_CookieMissing(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiForgeryToken_CookieMissing"), p0);
        }

        /// <summary>
        /// The anti-forgery token could not be decrypted.
        /// </summary>
        internal static string AntiForgeryToken_DeserializationFailed
        {
            get { return GetString("AntiForgeryToken_DeserializationFailed"); }
        }

        /// <summary>
        /// The anti-forgery token could not be decrypted.
        /// </summary>
        internal static string FormatAntiForgeryToken_DeserializationFailed()
        {
            return GetString("AntiForgeryToken_DeserializationFailed");
        }

        /// <summary>
        /// The required anti-forgery form field "{0}" is not present.
        /// </summary>
        internal static string AntiForgeryToken_FormFieldMissing
        {
            get { return GetString("AntiForgeryToken_FormFieldMissing"); }
        }

        /// <summary>
        /// The required anti-forgery form field "{0}" is not present.
        /// </summary>
        internal static string FormatAntiForgeryToken_FormFieldMissing(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiForgeryToken_FormFieldMissing"), p0);
        }

        /// <summary>
        /// The anti-forgery cookie token and form field token do not match.
        /// </summary>
        internal static string AntiForgeryToken_SecurityTokenMismatch
        {
            get { return GetString("AntiForgeryToken_SecurityTokenMismatch"); }
        }

        /// <summary>
        /// The anti-forgery cookie token and form field token do not match.
        /// </summary>
        internal static string FormatAntiForgeryToken_SecurityTokenMismatch()
        {
            return GetString("AntiForgeryToken_SecurityTokenMismatch");
        }

        /// <summary>
        /// Validation of the provided anti-forgery token failed. The cookie "{0}" and the form field "{1}" were swapped.
        /// </summary>
        internal static string AntiForgeryToken_TokensSwapped
        {
            get { return GetString("AntiForgeryToken_TokensSwapped"); }
        }

        /// <summary>
        /// Validation of the provided anti-forgery token failed. The cookie "{0}" and the form field "{1}" were swapped.
        /// </summary>
        internal static string FormatAntiForgeryToken_TokensSwapped(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiForgeryToken_TokensSwapped"), p0, p1);
        }

        /// <summary>
        /// The provided anti-forgery token was meant for user "{0}", but the current user is "{1}".
        /// </summary>
        internal static string AntiForgeryToken_UsernameMismatch
        {
            get { return GetString("AntiForgeryToken_UsernameMismatch"); }
        }

        /// <summary>
        /// The provided anti-forgery token was meant for user "{0}", but the current user is "{1}".
        /// </summary>
        internal static string FormatAntiForgeryToken_UsernameMismatch(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiForgeryToken_UsernameMismatch"), p0, p1);
        }

        /// <summary>
        /// The anti-forgery system has the configuration value AntiForgeryOptions.RequireSsl = true, but the current request is not an SSL request.
        /// </summary>
        internal static string AntiForgeryWorker_RequireSSL
        {
            get { return GetString("AntiForgeryWorker_RequireSSL"); }
        }

        /// <summary>
        /// The anti-forgery system has the configuration value AntiForgeryOptions.RequireSsl = true, but the current request is not an SSL request.
        /// </summary>
        internal static string FormatAntiForgeryWorker_RequireSSL()
        {
            return GetString("AntiForgeryWorker_RequireSSL");
        }

        /// <summary>
        /// Value cannot be null or empty.
        /// </summary>
        internal static string ArgumentCannotBeNullOrEmpty
        {
            get { return GetString("ArgumentCannotBeNullOrEmpty"); }
        }

        /// <summary>
        /// Value cannot be null or empty.
        /// </summary>
        internal static string FormatArgumentCannotBeNullOrEmpty()
        {
            return GetString("ArgumentCannotBeNullOrEmpty");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
