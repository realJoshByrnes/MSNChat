using System.ComponentModel.Design;
using System.ComponentModel;
using MSNChat45;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSNChatControl
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class ChatSettings : UserControl
    {
        private bool interfacesAttached = false;
        private AxChatSettings? chatSettings;

        //private Color? _backColor;
        //[DefaultValue(typeof(Color), "255, 255, 255, 255")]
        //public override Color BackColor
        //{
        //    set
        //    {
        //        if (interfacesAttached)
        //        {
        //            chatSettings!.BackColor = value;
        //        }
        //        else
        //        {
        //            this._backColor = value;
        //        }
        //    }
        //    get
        //    {
        //        if (interfacesAttached)
        //        {
        //            return chatSettings!.BackColor;
        //        }
        //        else
        //        {
        //            return this._backColor ?? Color.FromArgb(255, 255, 255, 231);
        //        }
        //    }
        //}

        //private Color? _foreColor;
        //[DefaultValue(typeof(Color), "255, 0, 0, 0")]
        //public override Color ForeColor
        //{
        //    set
        //    {
        //        if (interfacesAttached)
        //        {
        //            chatSettings!.ForeColor = value;
        //        }
        //        else
        //        {
        //            this._foreColor = value;
        //        }
        //    }
        //    get
        //    {
        //        if (interfacesAttached)
        //        {
        //            return chatSettings!.ForeColor;
        //        }
        //        else
        //        {
        //            return this._foreColor ?? Color.FromArgb(255, 0, 0, 0);
        //        }
        //    }
        //}

        private string? _redirectURL;
        [DefaultValue("")]
        public string RedirectURL
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatSettings!.RedirectURL;
                }
                else
                {
                    return this._redirectURL ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatSettings!.RedirectURL = value;
                }
                else
                {
                    this._redirectURL = value;
                }
            }
        }

        private string? _resDLL;
        [DefaultValue("")]
        public string ResDLL
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatSettings!.ResDLL;
                }
                else
                {
                    return this._resDLL ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatSettings!.ResDLL = value;
                }
                else
                {
                    this._resDLL = value;
                }
            }
        }

        public ChatSettings()
        {
            InitializeComponent();
        }

        private void ChatSettings_Load(object sender, EventArgs e)
        {
            // The 32-bit ActiveX control won't work in the designer, so we have to create it ONLY at runtime.
            if (!this.DesignMode)
            {
                chatSettings = new AxChatSettings();
                chatSettings.OcxCreated += (s, e) =>
                {
                    //chatSettings.BackColor = this.BackColor; // TODO: This causes an exception.
                    //chatSettings.ForeColor = this.ForeColor; // TODO: This causes an exception.
                    chatSettings.RedirectURL = this.RedirectURL;
                    chatSettings.ResDLL = this.ResDLL;

                    interfacesAttached = true;
                };
                chatSettings.Dock = DockStyle.Fill;
                try
                {
                    Controls.Add(chatSettings);
                }
                catch (COMException ce)
                {
                    if (ce.ErrorCode == -2147221164) // REGDB_E_CLASSNOTREG
                    {
                        chatSettings.Dispose();
                        MessageBox.Show("The MSN Chat Control could not be found.", "Unable to load MsnChat45.ocx", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
    }
}
