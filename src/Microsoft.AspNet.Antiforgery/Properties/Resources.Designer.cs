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
        internal static string AntiforgeryTokenValidator_AuthenticatedUserWithoutUsername
        {
            get { return GetString("AntiforgeryTokenValidator_AuthenticatedUserWithoutUsername"); }
        }

        /// <summary>
        /// The provided identity of type '{0}' is marked IsAuthenticated = true but does not have a value for Name. By default, the anti-forgery system requires that all authenticated identities have a unique Name. If it is not possible to provide a unique Name for this identity, consider extending IAdditionalDataProvider by overriding the DefaultAdditionalDataProvider or a custom type that can provide some form of unique identifier for the current user.
        /// </summary>
        internal static string FormatAntiforgeryTokenValidator_AuthenticatedUserWithoutUsername(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiforgeryTokenValidator_AuthenticatedUserWithoutUsername"), p0);
        }

        /// <summary>
        /// The provided anti-forgery token failed a custom data check.
        /// </summary>
        internal static string AntiforgeryToken_AdditionalDataCheckFailed
        {
            get { return GetString("AntiforgeryToken_AdditionalDataCheckFailed"); }
        }

        /// <summary>
        /// The provided anti-forgery token failed a custom data check.
        /// </summary>
        internal static string FormatAntiforgeryToken_AdditionalDataCheckFailed()
        {
            return GetString("AntiforgeryToken_AdditionalDataCheckFailed");
        }

        /// <summary>
        /// The provided anti-forgery token was meant for a different claims-based user than the current user.
        /// </summary>
        internal static string AntiforgeryToken_ClaimUidMismatch
        {
            get { return GetString("AntiforgeryToken_ClaimUidMismatch"); }
        }

        /// <summary>
        /// The provided anti-forgery token was meant for a different claims-based user than the current user.
        /// </summary>
        internal static string FormatAntiforgeryToken_ClaimUidMismatch()
        {
            return GetString("AntiforgeryToken_ClaimUidMismatch");
        }

        /// <summary>
        /// The required anti-forgery cookie "{0}" is not present.
        /// </summary>
        internal static string AntiforgeryToken_CookieMissing
        {
            get { return GetString("AntiforgeryToken_CookieMissing"); }
        }

        /// <summary>
        /// The required anti-forgery cookie "{0}" is not present.
        /// </summary>
        internal static string FormatAntiforgeryToken_CookieMissing(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiforgeryToken_CookieMissing"), p0);
        }

        /// <summary>
        /// The anti-forgery token could not be decrypted.
        /// </summary>
        internal static string AntiforgeryToken_DeserializationFailed
        {
            get { return GetString("AntiforgeryToken_DeserializationFailed"); }
        }

        /// <summary>
        /// The anti-forgery token could not be decrypted.
        /// </summary>
        internal static string FormatAntiforgeryToken_DeserializationFailed()
        {
            return GetString("AntiforgeryToken_DeserializationFailed");
        }

        /// <summary>
        /// The required anti-forgery form field "{0}" is not present.
        /// </summary>
        internal static string AntiforgeryToken_FormFieldMissing
        {
            get { return GetString("AntiforgeryToken_FormFieldMissing"); }
        }

        /// <summary>
        /// The required anti-forgery form field "{0}" is not present.
        /// </summary>
        internal static string FormatAntiforgeryToken_FormFieldMissing(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiforgeryToken_FormFieldMissing"), p0);
        }

        /// <summary>
        /// The anti-forgery cookie token and form field token do not match.
        /// </summary>
        internal static string AntiforgeryToken_SecurityTokenMismatch
        {
            get { return GetString("AntiforgeryToken_SecurityTokenMismatch"); }
        }

        /// <summary>
        /// The anti-forgery cookie token and form field token do not match.
        /// </summary>
        internal static string FormatAntiforgeryToken_SecurityTokenMismatch()
        {
            return GetString("AntiforgeryToken_SecurityTokenMismatch");
        }

        /// <summary>
        /// Validation of the provided anti-forgery token failed. The cookie "{0}" and the form field "{1}" were swapped.
        /// </summary>
        internal static string AntiforgeryToken_TokensSwapped
        {
            get { return GetString("AntiforgeryToken_TokensSwapped"); }
        }

        /// <summary>
        /// Validation of the provided anti-forgery token failed. The cookie "{0}" and the form field "{1}" were swapped.
        /// </summary>
        internal static string FormatAntiforgeryToken_TokensSwapped(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiforgeryToken_TokensSwapped"), p0, p1);
        }

        /// <summary>
        /// The provided anti-forgery token was meant for user "{0}", but the current user is "{1}".
        /// </summary>
        internal static string AntiforgeryToken_UsernameMismatch
        {
            get { return GetString("AntiforgeryToken_UsernameMismatch"); }
        }

        /// <summary>
        /// The provided anti-forgery token was meant for user "{0}", but the current user is "{1}".
        /// </summary>
        internal static string FormatAntiforgeryToken_UsernameMismatch(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AntiforgeryToken_UsernameMismatch"), p0, p1);
        }

        /// <summary>
        /// The anti-forgery system has the configuration value AntiforgeryOptions.RequireSsl = true, but the current request is not an SSL request.
        /// </summary>
        internal static string AntiforgeryWorker_RequireSSL
        {
            get { return GetString("AntiforgeryWorker_RequireSSL"); }
        }

        /// <summary>
        /// The anti-forgery system has the configuration value AntiforgeryOptions.RequireSsl = true, but the current request is not an SSL request.
        /// </summary>
        internal static string FormatAntiforgeryWorker_RequireSSL()
        {
            return GetString("AntiforgeryWorker_RequireSSL");
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