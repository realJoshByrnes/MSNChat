using System.ComponentModel.Design;
using System.ComponentModel;
using MSNChat45;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSNChatControl
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class ChatFrame : UserControl
    {
        private bool interfacesAttached = false;
        private AxMSNChatFrame? chatFrame;

        public ChatFrame()
        {
            InitializeComponent();
        }

        private Color? _backColor;
        [DefaultValue(typeof(Color), "255, 255, 255, 231")]
        public override Color BackColor
        {
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.BackColor = value;
                }
                else
                {
                    this._backColor = value;
                }
            }
            get
            {
                //if (interfacesAttached)
                //{
                //    return chatFrame!.BackColor;
                //}
                //else
                //{
                    return this._backColor ?? Color.FromArgb(255, 255, 255, 231);
                //}
            }
        }

        private string? _roomName;
        [DefaultValue("The Lobby")]
        public string RoomName
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.RoomName;
                }
                else
                {
                    return this._roomName ?? "The Lobby";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.RoomName = value;
                }
                else
                {
                    this._roomName = value;
                }
            }
        }

        private string? _hexRoomName;
        [DefaultValue("")]
        public string HexRoomName
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.HexRoomName;
                }
                else
                {
                    return this._hexRoomName ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.HexRoomName = value;
                }
                else
                {
                    this._hexRoomName = value;
                }
            }
        }

        private string? _nickName;
        [DefaultValue("")] // Why can't we use a random number here without a prefix?
        public string NickName {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.NickName;
                }
                else
                {
                    return this._nickName ?? $"X{new Random().Next(1111, 9999).ToString("D4")}";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.NickName = value;
                }
                else
                {
                    this._nickName = value;
                }
            }
        }

        //[DefaultValue("207.68.167.253:6667")]
        //public string Server { get; set; } = "207.68.167.253:6667";
        private string? _server;
        [DefaultValue("dir.irc7.com:6667")]
        public string Server
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.Server;
                }
                else
                {
                    return this._server ?? "dir.irc7.com:6667";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.Server = value;
                }
                else
                {
                    this._server = value;
                }
            }
        }

        private Color? _backHighlightColor;
        [DefaultValue(typeof(Color), "255, 239, 239, 247")]
        public Color BackHighlightColor
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.BackHighlightColor;
                }
                else
                {
                    return this._backHighlightColor ?? Color.FromArgb(255, 239, 239, 247);
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.BackHighlightColor = value;
                }
                else
                {
                    this._backHighlightColor = value;
                }
            }
        }

        private Color? _buttonFrameColor;
        [DefaultValue(typeof(Color), "255, 102, 153, 255")]
        public Color ButtonFrameColor
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.ButtonFrameColor;
                }
                else
                {
                    return this._buttonFrameColor ?? Color.FromArgb(255, 102, 153, 255);
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.ButtonFrameColor = value;
                }
                else
                {
                    this._buttonFrameColor = value;
                }
            }
        }

        private Color? _topBackHighlightColor;
        [DefaultValue(typeof(Color), "255, 165, 178, 206")]
        public Color TopBackHighlightColor
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.TopBackHighlightColor;
                }
                else
                {
                    return this._topBackHighlightColor ?? Color.FromArgb(255, 165, 178, 206);
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.TopBackHighlightColor = value;
                }
                else
                {
                    this._topBackHighlightColor = value;
                }
            }
        }

        private int? _chatMode;
        [DefaultValue(0)]
        public int ChatMode
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.ChatMode;
                }
                else
                {
                    return this._chatMode ?? 0;
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.ChatMode = value;
                }
                else
                {
                    this._chatMode = value;
                }
            }
        }

        // Was set to "messenger.msnw" when embedded in MSN Messenger.
        private string? _urlBack;
        [DefaultValue("")]
        public string URLBack
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.URLBack;
                }
                else
                {
                    return this._urlBack ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.URLBack = value;
                }
                else
                {
                    this._urlBack = value;
                }
            }
        }

        private string? _category;
        [DefaultValue("")]
        public string Category
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.Category;
                }
                else
                {
                    return this._category ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.Category = value;
                }
                else
                {
                    this._category = value;
                }
            }
        }

        private string? _topic;
        [DefaultValue("")]
        public string Topic
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.Topic;
                }
                else
                {
                    return this._topic ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.Topic = value;
                }
                else
                {
                    this._topic = value;
                }
            }
        }

        private string? _welcomeMsg;
        [DefaultValue("")]
        public string WelcomeMsg
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.WelcomeMsg;
                }
                else
                {
                    return this._welcomeMsg ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.WelcomeMsg = value;
                }
                else
                {
                    this._welcomeMsg = value;
                }
            }
        }

        private string? _baseURL;
        [DefaultValue("http://chat.msn.com/")]
        public string BaseURL
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.BaseURL;
                }
                else
                {
                    return this._baseURL ?? "http://chat.msn.com/";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.BaseURL = value;
                }
                else
                {
                    this._baseURL = value;
                }
            }
        }

        private Color? _inputBorderColor;
        [DefaultValue(typeof(Color), "255, 74, 101, 156")]
        public Color InputBorderColor
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.InputBorderColor;
                }
                else
                {
                    return this._inputBorderColor ?? Color.FromArgb(255, 74, 101, 156);
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.InputBorderColor = value;
                }
                else
                {
                    this._inputBorderColor = value;
                }
            }
        }

        // Was set to "create.msnw?fMsgr=true&" when embedded in MSN Messenger.
        private string? _createRoom;
        [DefaultValue("")]
        public string CreateRoom
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.CreateRoom;
                }
                else
                {
                    return this._createRoom ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.CreateRoom = value;
                }
                else
                {
                    this._createRoom = value;
                }
            }
        }

        // Was set to "messenger.msnw" when embedded in MSN Messenger.
        private string? _chatHome;
        [DefaultValue("")]
        public string ChatHome
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.ChatHome;
                }
                else
                {
                    return this._chatHome ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.ChatHome = value;
                }
                else
                {
                    this._chatHome = value;
                }
            }
        }

        private string? _locale;
        [DefaultValue("")]
        public string Locale
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.Locale;
                }
                else
                {
                    return this._locale ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.Locale = value;
                }
                else
                {
                    this._locale = value;
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
                    return chatFrame!.ResDLL;
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
                    chatFrame!.ResDLL = value;
                }
                else
                {
                    this._resDLL = value;
                }
            }
        }

        private Color? buttonTextColor;
        [DefaultValue(typeof(Color), "Black")]
        public Color ButtonTextColor
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.ButtonTextColor;
                }
                else
                {
                    return this.buttonTextColor ?? Color.Black;
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.ButtonTextColor = value;
                }
                else
                {
                    this.buttonTextColor = value;
                }
            }
        }

        private Color? buttonBackColor;
        [DefaultValue(typeof(Color), "255, 202, 224, 245")]
        public Color ButtonBackColor
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.ButtonBackColor;
                }
                else
                {
                    return this.buttonBackColor ?? Color.FromArgb(255, 202, 224, 245);
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.ButtonBackColor = value;
                }
                else
                {
                    this.buttonBackColor = value;
                }
            }
        }

        private string? passportTicket;
        [DefaultValue("")]
        public string PassportTicket
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.PassportTicket;
                }
                else
                {
                    return this.passportTicket ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.PassportTicket = value;
                }
                else
                {
                    this.passportTicket = value;
                }
            }
        }

        private string? passportProfile;
        [DefaultValue("")]
        public string PassportProfile
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.PassportProfile;
                }
                else
                {
                    return this.passportProfile ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.PassportProfile = value;
                }
                else
                {
                    this.passportProfile = value;
                }
            }
        }

        private uint? feature;
        [DefaultValue(0)]
        public uint Feature
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.Feature;
                }
                else
                {
                    return this.feature ?? 0;
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.Feature = value;
                }
                else
                {
                    this.feature = value;
                }
            }
        }

        private string? messageOfTheDay;
        [DefaultValue("Welcome to MSN Chat! MSN does not control or endorse the content, messages or information found in chat. MSN specifically disclaims any liability with regard to these areas. To review the MSN Chat guidelines, go to http://groups.msn.com/conduct NOTICE: To help protect you from spam, MSN Chat is now available by subscription only. Learn more at http://getchat.msn.com")]
        public string MessageOfTheDay
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.MessageOfTheDay;
                }
                else
                {
                    return this.messageOfTheDay ?? "Welcome to MSN Chat! MSN does not control or endorse the content, messages or information found in chat. MSN specifically disclaims any liability with regard to these areas. To review the MSN Chat guidelines, go to http://groups.msn.com/conduct NOTICE: To help protect you from spam, MSN Chat is now available by subscription only. Learn more at http://getchat.msn.com";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.MessageOfTheDay = value;
                }
                else
                {
                    this.messageOfTheDay = value;
                }
            }
        }

        private string? channelLanguage;
        [DefaultValue("")]
        public string ChannelLanguage
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.ChannelLanguage;
                }
                else
                {
                    return this.channelLanguage ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.ChannelLanguage = value;
                }
                else
                {
                    this.channelLanguage = value;
                }
            }
        }

        private string? invitationCode;
        [DefaultValue("")]
        public string InvitationCode
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.InvitationCode;
                }
                else
                {
                    return this.invitationCode ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.InvitationCode = value;
                }
                else
                {
                    this.invitationCode = value;
                }
            }
        }

        private string? nicknameToInvite;
        [DefaultValue("")]
        public string NicknameToInvite
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.NicknameToInvite;
                }
                else
                {
                    return this.nicknameToInvite ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.NicknameToInvite = value;
                }
                else
                {
                    this.nicknameToInvite = value;
                }
            }
        }

        private string? msnRegCookie;
        [DefaultValue("")]
        public string MSNREGCookie
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.MSNREGCookie;
                }
                else
                {
                    return this.msnRegCookie ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.MSNREGCookie = value;
                }
                else
                {
                    this.msnRegCookie = value;
                }
            }
        }

        private string? creationModes;
        [DefaultValue("f")]
        public string CreationModes
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.CreationModes;
                }
                else
                {
                    return this.creationModes ?? "f";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.CreationModes = value;
                }
                else
                {
                    this.creationModes = value;
                }
            }
        }

        private string? msnProfile;
        [DefaultValue("")]
        public string MSNProfile
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.MSNProfile;
                }
                else
                {
                    return this.msnProfile ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.MSNProfile = value;
                }
                else
                {
                    this.msnProfile = value;
                }
            }
        }

        private string? market;
        [DefaultValue("en-us")]
        public string Market
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.Market;
                }
                else
                {
                    return this.market ?? "en-us";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.Market = value;
                }
                else
                {
                    this.market = value;
                }
            }
        }

        private string? whisperContent;
        [DefaultValue("http://chat.msn.com/whisper.msnw")]
        public string WhisperContent
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.WhisperContent;
                }
                else
                {
                    return this.whisperContent ?? "http://chat.msn.com/whisper.msnw";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.WhisperContent = value;
                }
                else
                {
                    this.whisperContent = value;
                }
            }
        }

        private string? userRole;
        [DefaultValue("")]
        public string UserRole
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.UserRole;
                }
                else
                {
                    return this.userRole ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.UserRole = value;
                }
                else
                {
                    this.userRole = value;
                }
            }
        }

        private string? auditMessage;
        [DefaultValue("Note: MSN has detected that you are connected to this chat session from the IP address <B>%1</B>.")]
        public string AuditMessage
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.AuditMessage;
                }
                else
                {
                    return this.auditMessage ?? "Note: MSN has detected that you are connected to this chat session from the IP address <B>%1</B>.";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    Debug.WriteLine("Set external auditmessage");
                    chatFrame!.AuditMessage = value;
                }
                else
                {
                    Debug.WriteLine("Set internal auditmessage");
                    this.auditMessage = value;
                }
            }
        }

        private string? subscriberInfo;
        [DefaultValue("")]
        public string SubscriberInfo
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.SubscriberInfo;
                }
                else
                {
                    return this.subscriberInfo ?? "";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.SubscriberInfo = value;
                }
                else
                {
                    this.subscriberInfo = value;
                }
            }
        }

        private string? upsellURL;
        [DefaultValue("subscribe.msnw")]
        public string UpsellURL
        {
            get
            {
                if (interfacesAttached)
                {
                    return chatFrame!.UpsellURL;
                }
                else
                {
                    return this.upsellURL ?? "subscribe.msnw";
                }
            }
            set
            {
                if (interfacesAttached)
                {
                    chatFrame!.UpsellURL = value;
                }
                else
                {
                    this.upsellURL = value;
                }
            }
        }

        private void MSNChatFrame_Load(object sender, EventArgs e)
        {
            // The 32-bit ActiveX control won't work in the designer, so we have to create it ONLY at runtime.
            if (!this.DesignMode)
            {
                chatFrame = new AxMSNChatFrame();
                chatFrame.OcxCreated += (s, e) =>
                {
                    //chatFrame.BackColor = this.BackColor; // TODO: This causes an exception.
                    chatFrame.RoomName = this.RoomName;
                    chatFrame.HexRoomName = this.HexRoomName;
                    chatFrame.NickName = this.NickName;
                    chatFrame.Server = this.Server;
                    chatFrame.BackHighlightColor = this.BackHighlightColor;
                    chatFrame.ButtonFrameColor = this.ButtonFrameColor;
                    chatFrame.TopBackHighlightColor = this.TopBackHighlightColor;
                    chatFrame.ChatMode = this.ChatMode;
                    chatFrame.URLBack = this.URLBack;
                    chatFrame.Category = this.Category;
                    chatFrame.Topic = this.Topic;
                    chatFrame.WelcomeMsg = this.WelcomeMsg;
                    chatFrame.BaseURL = this.BaseURL;
                    chatFrame.InputBorderColor = this.InputBorderColor;
                    chatFrame.CreateRoom = this.CreateRoom;
                    chatFrame.ChatHome = this.ChatHome;
                    chatFrame.Locale = this.Locale;
                    chatFrame.ResDLL = this.ResDLL;
                    chatFrame.ButtonTextColor = this.ButtonTextColor;
                    chatFrame.ButtonBackColor = this.ButtonBackColor;
                    chatFrame.PassportTicket = this.PassportTicket;
                    chatFrame.PassportProfile = this.PassportProfile;
                    chatFrame.Feature = this.Feature;
                    chatFrame.MessageOfTheDay = this.MessageOfTheDay;
                    chatFrame.ChannelLanguage = this.ChannelLanguage;
                    chatFrame.InvitationCode = this.InvitationCode;
                    chatFrame.NicknameToInvite = this.NicknameToInvite;
                    chatFrame.MSNREGCookie = this.MSNREGCookie;
                    chatFrame.CreationModes = this.CreationModes;
                    chatFrame.MSNProfile = this.MSNProfile;
                    chatFrame.Market = this.Market;
                    chatFrame.WhisperContent = this.WhisperContent;
                    chatFrame.UserRole = this.UserRole;
                    chatFrame.AuditMessage = this.AuditMessage;
                    chatFrame.SubscriberInfo = this.SubscriberInfo;
                    chatFrame.UpsellURL = this.UpsellURL;
                    interfacesAttached = true;
                };
                chatFrame.Dock = DockStyle.Fill;
                try
                {
                    Controls.Add(chatFrame);
                }
                catch (COMException ce)
                {
                    if (ce.ErrorCode == -2147221164) // REGDB_E_CLASSNOTREG
                    {
                        chatFrame.Dispose();
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
