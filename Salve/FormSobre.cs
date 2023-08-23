using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormSobre: Form
    {
        FormMenu formMenu;

        public FormSobre(FormMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            formMenu.player.SoundLocation = "./sound/sobre.wav";
            formMenu.player.Play();
        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            formMenu.player.Stop();
            formMenu.player.SoundLocation = "./sound/menu.wav";
            formMenu.player.PlayLooping();
            this.Close();
        }
    }
}
