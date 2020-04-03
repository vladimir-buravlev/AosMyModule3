using System.Collections.Generic;
using VirtoCommerce.Platform.Core.Settings;

namespace AosMyModule3.Core
{
    public static class ModuleConstants
    {
        public static class Security
        {
            public static class Permissions
            {
                public const string Create = "AosMyModule3:create";
                public const string Access = "AosMyModule3:access";
                public const string Read = "AosMyModule3:read";
                public const string Update = "AosMyModule3:update";
                public const string Delete = "AosMyModule3:delete";

                public static string[] AllPermissions = { Read, Create, Access, Update, Delete };
            }
        }

        public static class Settings
        {
            public static class General
            {
                public static SettingDescriptor AosMyModule3Enabled = new SettingDescriptor
                {
                    Name = "AosMyModule3.AosMyModule3Enabled",
                    GroupName = "Store|General",
                    ValueType = SettingValueType.Boolean,
                    DefaultValue = false
                };

                public static SettingDescriptor AosMyModule3Password = new SettingDescriptor
                {
                    Name = "AosMyModule3.AosMyModule3Password",
                    GroupName = "Store|Advanced",
                    ValueType = SettingValueType.SecureString,
                    DefaultValue = "qwerty"
                };

                public static IEnumerable<SettingDescriptor> AllSettings
                {
                    get
                    {
                        yield return AosMyModule3Enabled;
                        yield return AosMyModule3Password;
                    }
                }
            }

            public static IEnumerable<SettingDescriptor> AllSettings
            {
                get
                {
                    return General.AllSettings;
                }
            }
        }
    }
}
