using System;
using System.Windows.Forms;
using Kyanid.managers;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Kyanid.gui
{
    public partial class CheatMenu : MaterialForm
    {
        
        private Kyanid _kyanid;
        public CheatMenu(Kyanid kyanid)
        {
            this._kyanid = kyanid;
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple600, Primary.DeepPurple800, Primary.DeepPurple600, Accent.DeepPurple400, TextShade.WHITE);
            InitializeComponent();
        }

        private void CheatMenu_Load(object sender, EventArgs e)
        {
            var modulesManager = Managers.Get<ModulesManager>();
            var manager = Managers.Get<SettingsManager>();

            var autoclicker = modulesManager.GetModule("AutoClicker");
            minCpsSlider.Value = manager.GetSetting<int>(autoclicker, "minCps");
            maxCpsSlider.Value = manager.GetSetting<int>(autoclicker, "maxCps");
            attackRequiredSwitch.Checked = manager.GetSetting<bool>(autoclicker, "attackRequired");
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _kyanid.Stop();
        }

        private void minCpsSlider_onValueChanged(object sender, int newValue)
        {
            var modulesManager = Managers.Get<ModulesManager>();
            var manager = Managers.Get<SettingsManager>();

            var autoclicker = modulesManager.GetModule("AutoClicker");
            manager.SetSetting(autoclicker, "minCps", newValue);
        }

        private void maxCpsSlider_onValueChanged(object sender, int newValue)
        {
            var modulesManager = Managers.Get<ModulesManager>();
            var manager = Managers.Get<SettingsManager>();

            var autoclicker = modulesManager.GetModule("AutoClicker");
            manager.SetSetting(autoclicker, "maxCps", newValue);
        }

        private void attackRequiredSwitch_CheckStateChanged(object sender, EventArgs e)
        {
            var modulesManager = Managers.Get<ModulesManager>();
            var manager = Managers.Get<SettingsManager>();

            var autoclicker = modulesManager.GetModule("AutoClicker");
            manager.SetSetting(autoclicker, "attackRequired", attackRequiredSwitch.Checked);
        }

        private void autoclicker_CheckedChanged(object sender, EventArgs e)
        {
            var modulesManager = Managers.Get<ModulesManager>();

            var autoclicker = (AutoClicker) modulesManager.GetModule("AutoClicker");
            if (autoclicker.IsRunning())
            {
                autoclicker.Stop();
                attackRequiredSwitch.Enabled = false;
                minCpsSlider.Enabled = false;
                maxCpsSlider.Enabled = false;
                autoclickerLabel.Enabled = false;
            } else
            {
                autoclicker.Start();
                attackRequiredSwitch.Enabled = true;
                minCpsSlider.Enabled = true;
                maxCpsSlider.Enabled = true;
                autoclickerLabel.Enabled = true;
            }
        }
    }
}