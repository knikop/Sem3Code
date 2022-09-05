using System;
using System.Windows.Forms;

namespace Keyboard_Event
{
    public partial class KeyDemo : Form
    {
        public KeyDemo()
        {
            InitializeComponent();
        }

        private void KeyDemo_KeyPress(object sender, KeyPressEventArgs e)
        {
            charLabel.Text = $"Key pressed: {e.KeyChar}";
        }           
        // display modifier keys, key code, key data and key value
        private void KeyDemo_KeyDown(object sender, KeyEventArgs e)
        {
            keyInfoLabel.Text =
            $"Alt: {(e.Alt ? "Yes" : "No")}\n" +
            $"Shift: {(e.Shift ? "Yes" : "No")}\n" +
            $"Ctrl: {(e.Control ? "Yes" : "No")}\n" +
            $"KeyCode: {e.KeyCode}\n" +
            $"KeyData: {e.KeyData}\n" +
            $"KeyValue: {e.KeyValue}";
        }

        // clear Labels when key released
        private void KeyDemo_KeyUp(object sender, KeyEventArgs e)
        {
            charLabel.Text = "";
            keyInfoLabel.Text = "";
        }
    }
}
