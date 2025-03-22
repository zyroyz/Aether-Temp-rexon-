using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "advantages", method =() => SettingsMods.advantages(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "movement", method =() => SettingsMods.movement(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
                new ButtonInfo { buttonText = "advantages", method =() => SettingsMods.advantages(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "safety", method =() => SettingsMods.safety(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
                new ButtonInfo { buttonText = "fun", method =() => SettingsMods.fun(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "guardian", method =() => SettingsMods.guardian(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home page for the menu."},
                new ButtonInfo { buttonText = "Right/Left Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Advantages
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home page for the menu."},
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
                new ButtonInfo { buttonText = "Gun Temp", method =() => mods.AetherGunTemplate(), isTogglable = true, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // Movement
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home page for the menu."},
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // visuals
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home page for the menu."},
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // overpowered
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home page for the menu."},
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // safety
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home page for the menu."},
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // fun
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home page for the menu."},
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },

            new ButtonInfo[] { // guardian
                new ButtonInfo { buttonText = "home", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the home page for the menu."},
                new ButtonInfo { buttonText = "placeholder", method =() => mods.placeholder(), isTogglable = false, toolTip = "placeholder."},
            },


        };
    }
}
