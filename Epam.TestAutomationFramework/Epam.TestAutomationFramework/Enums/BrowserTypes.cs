using System.ComponentModel;

namespace Epam.TestAutomationFramework.Core.Enums
{
    public enum BrowserTypes
    {
        [Description("Chrome")] 
        Chrome,

        [Description("Mozilla Firefox")]
        Firefox,

        [Description("Undefined")]
        Undefined,
    }
}
