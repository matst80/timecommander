using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Configuration;

namespace TimeCommander2.Helpers
{
    public abstract class AppSettings
    {
        // Load the settings.
        public virtual void Load()
        {
            PropertyInfo[] properties = GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (!property.PropertyType.IsArray)
                {
                    string appValue = ConfigurationManager.AppSettings[property.Name];
                    if (appValue != null)
                    {
                        try
                        {
                            // Attempt to change the type from System.String to
                            // the property type, and set the property value.
                            property.SetValue(
                              this,
                              Convert.ChangeType(appValue, property.PropertyType),
                              null);
                        }
                        catch {/*ignore*/}
                    }
                }
            }
        }
        // Save the settings.
        public virtual void Save()
        {
            // Get the configuration file.
            System.Configuration.Configuration configuration =
              ConfigurationManager.OpenExeConfiguration(
                ConfigurationUserLevel.None);
            // Get the public properties of the class.
            PropertyInfo[] properties = GetType().GetProperties();
            // Save each property setting.
            foreach (PropertyInfo property in properties)
            {
                // Save if not an array type.
                if (!property.PropertyType.IsArray)
                {
                    // Remove the setting if it exists.
                    if (configuration.AppSettings.Settings[property.Name] != null)
                    {
                        configuration.AppSettings.Settings.Remove(property.Name);
                    }
                    // Add the setting.
                    configuration.AppSettings.Settings.Add(
                      property.Name,
                      property.GetValue(this, null).ToString());
                }
            }
            // Save the configuration settings.
            configuration.Save(ConfigurationSaveMode.Modified);
            // Force a reload of the whole section.
            ConfigurationManager.RefreshSection("appSettings");
        }
        protected AppSettings()
        {
            // Load the settings when class instance is constructed.
            Load();
        }
        ~AppSettings()
        {
            // Save settings when instance is destroyed.
            Save();
        }
    }
}
