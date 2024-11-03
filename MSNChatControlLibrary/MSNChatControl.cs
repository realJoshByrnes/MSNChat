using AxMSNChat;
using System.ComponentModel;
using System.Diagnostics;

namespace MSNChatControlLibrary
{
  public partial class MSNChatControl : UserControl
  {
    private AxMSNChatFrame axMSNChatFrame;
    private Dictionary<string, object> propertyValues = new Dictionary<string, object>();
    private bool interfacesAttached = false;

    public MSNChatControl()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      SuspendLayout();
      // 
      // MSNChatControl
      // 
      Name = "MSNChatControl";
      Load += MSNChatControl_Load;

      BackColor = Color.FromArgb(255, 255, 255, 231);
      RoomName = "The Lobby";
      HexRoomName = "";
      NickName = "User";
      Server = "dir.irc7.com:6667";
      BackHighlightColor = Color.FromArgb(255, 239, 239, 247);
      ButtonFrameColor = Color.FromArgb(255, 102, 153, 255);
      TopBackHighlightColor = Color.FromArgb(255, 165, 178, 206);
      ChatMode = 0;
      URLBack = "";
      Category = "";
      Topic = "";
      WelcomeMsg = "";
      BaseURL = "http://chat.msn.com/";
      InputBorderColor = Color.FromArgb(255, 74, 101, 156);
      CreateRoom = "";
      ChatHome = "";
      Locale = "";
      ResDLL = "";
      ButtonTextColor = Color.Black;
      ButtonBackColor = Color.FromArgb(255, 202, 224, 245);
      PassportTicket = "";
      PassportProfile = "";
      Feature = 0;
      MessageOfTheDay = "Welcome to MSN Chat! MSN does not control or endorse the content, messages or information found in chat. MSN specifically disclaims any liability with regard to these areas. To review the MSN Chat guidelines, go to http://groups.msn.com/conduct NOTICE: To help protect you from spam, MSN Chat is now available by subscription only. Learn more at http://getchat.msn.com";
      ChannelLanguage = "";
      InvitationCode = "";
      NicknameToInvite = "";
      MSNREGCookie = "";
      CreationModes = "f";
      MSNProfile = "";
      Market = "en-us";
      WhisperContent = "http://chat.msn.com/whisper.msnw";
      UserRole = "";
      AuditMessage = "Note: MSN has detected that you are connected to this chat session from the IP address <B>%1</B>.";
      SubscriberInfo = "";
      UpsellURL = "";

      ResumeLayout(false);
    }

    private void AxMSNChatFrame_ControlReady(object? sender, EventArgs e)
    {
      interfacesAttached = true;
      foreach (var property in propertyValues)
      {
        var propertyInfo = typeof(AxMSNChatFrame).GetProperty(property.Key);
        if (propertyInfo != null)
        {
          Debug.WriteLine(property.Key, propertyInfo);
          propertyInfo.SetValue(axMSNChatFrame, property.Value);
        }
      }
      propertyValues.Clear();
    }

    private void SetPropertyValue(string propertyName, object value)
    {
      if (interfacesAttached)
      {
        var propertyInfo = typeof(AxMSNChatFrame).GetProperty(propertyName);
        if (propertyInfo != null)
        {
          propertyInfo.SetValue(axMSNChatFrame, value);
        }
      }
      else
      {
        propertyValues[propertyName] = value;
      }
    }

    private void MSNChatControl_Load(object sender, EventArgs e)
    {
      if (DesignMode) {
          // The MSN Chat Control / Chat Settings will not load in the designer due to /NXCOMPAT:NO needing to be set.
          var lbl = new Label();
          lbl.BackColor = this.BackColor;
          lbl.Dock = DockStyle.Fill;
          lbl.ForeColor = this.ForeColor;
          lbl.Font = new Font(Font.Name, 20F, Font.Style, Font.Unit, Font.GdiCharSet);
          lbl.Text = Name;
          lbl.TextAlign = ContentAlignment.MiddleCenter;
          Controls.Add(lbl);
          return;
      }
      // Initialize AxMSNChatFrame
      axMSNChatFrame = new AxMSNChatFrame();
      axMSNChatFrame.ControlReady += AxMSNChatFrame_ControlReady;
      axMSNChatFrame.Dock = DockStyle.Fill;
      this.Controls.Add(axMSNChatFrame);
    }

    private T GetPropertyValue<T>(string propertyName)
    {
      if (interfacesAttached)
    {
        var propertyInfo = typeof(AxMSNChatFrame).GetProperty(propertyName);
        if (propertyInfo != null)
        {
          return (T)propertyInfo.GetValue(axMSNChatFrame)!;
        }
        return default!;
      }
      else if (propertyValues.ContainsKey(propertyName))
      {
        return (T)propertyValues[propertyName];
      }
      else
      {
        return default!;
      }
    }

    // Properties to expose AxMSNChatFrame properties
    [DefaultValue(typeof(Color), "255, 255, 255, 231")]
    public new Color BackColor
    {
      get { return GetPropertyValue<Color>(nameof(BackColor)); }
      set { SetPropertyValue(nameof(BackColor), value); }
    }

    [DefaultValue("The Lobby")]
    public string RoomName
    {
      get { return GetPropertyValue<string>(nameof(RoomName)); }
      set { SetPropertyValue(nameof(RoomName), value); }
    }

    [DefaultValue("")] 
    public string HexRoomName
    {
      get { return GetPropertyValue<string>(nameof(HexRoomName)); }
      set { SetPropertyValue(nameof(HexRoomName), value); }
    }

    [DefaultValue("")]
    public string NickName
    {
      get { return GetPropertyValue<string>(nameof(NickName)); }
      set { SetPropertyValue(nameof(NickName), value); }
    }

    [DefaultValue("dir.irc7.com:6667")]
    public string Server
    {
      get { return GetPropertyValue<string>(nameof(Server)); }
      set { SetPropertyValue(nameof(Server), value); }
    }

    [DefaultValue(typeof(Color), "255, 239, 239, 247")]
    public Color BackHighlightColor
    {
        get { return GetPropertyValue<Color>(nameof(BackHighlightColor)); }
        set { SetPropertyValue(nameof(BackHighlightColor), value); }
    }

    [DefaultValue(typeof(Color), "255, 102, 153, 255")]
    public Color ButtonFrameColor
    {
        get { return GetPropertyValue<Color>(nameof(ButtonFrameColor)); }
        set { SetPropertyValue(nameof(ButtonFrameColor), value); }
    }

    [DefaultValue(typeof(Color), "255, 165, 178, 206")]
    public Color TopBackHighlightColor
    {
        get { return GetPropertyValue<Color>(nameof(TopBackHighlightColor)); }
        set { SetPropertyValue(nameof(TopBackHighlightColor), value); }
    }

    [DefaultValue(0)]
    public int ChatMode
    {
        get { return GetPropertyValue<int>(nameof(ChatMode)); }
        set { SetPropertyValue(nameof(ChatMode), value); }
    }

    [DefaultValue("")]
    public string URLBack
    {
        get { return GetPropertyValue<string>(nameof(URLBack)); }
        set { SetPropertyValue(nameof(URLBack), value); }
    }

    [DefaultValue("")]
    public string Category
    {
        get { return GetPropertyValue<string>(nameof(Category)); }
        set { SetPropertyValue(nameof(Category), value); }
    }

    [DefaultValue("")]
    public string Topic
    {
        get { return GetPropertyValue<string>(nameof(Topic)); }
        set { SetPropertyValue(nameof(Topic), value); }
    }

    [DefaultValue("")]
    public string WelcomeMsg
    {
        get { return GetPropertyValue<string>(nameof(WelcomeMsg)); }
        set { SetPropertyValue(nameof(WelcomeMsg), value); }
    }

    [DefaultValue("http://chat.msn.com/")]
    public string BaseURL
    {
        get { return GetPropertyValue<string>(nameof(BaseURL)); }
        set { SetPropertyValue(nameof(BaseURL), value); }
    }

    [DefaultValue(typeof(Color), "255, 74, 101, 156")]
    public Color InputBorderColor
    {
        get { return GetPropertyValue<Color>(nameof(InputBorderColor)); }
        set { SetPropertyValue(nameof(InputBorderColor), value); }
    }

    [DefaultValue("")]
    public string CreateRoom
    {
        get { return GetPropertyValue<string>(nameof(CreateRoom)); }
        set { SetPropertyValue(nameof(CreateRoom), value); }
    }

    [DefaultValue("")]
    public string ChatHome
    {
        get { return GetPropertyValue<string>(nameof(ChatHome)); }
        set { SetPropertyValue(nameof(ChatHome), value); }
    }

    [DefaultValue("")]
    public string Locale
    {
        get { return GetPropertyValue<string>(nameof(Locale)); }
        set { SetPropertyValue(nameof(Locale), value); }
    }

    [DefaultValue("")]
    public string ResDLL
    {
        get { return GetPropertyValue<string>(nameof(ResDLL)); }
        set { SetPropertyValue(nameof(ResDLL), value); }
    }

    [DefaultValue(typeof(Color), "Black")]
    public Color ButtonTextColor
    {
        get { return GetPropertyValue<Color>(nameof(ButtonTextColor)); }
        set { SetPropertyValue(nameof(ButtonTextColor), value); }
    }

    [DefaultValue(typeof(Color), "255, 202, 224, 245")]
    public Color ButtonBackColor
    {
        get { return GetPropertyValue<Color>(nameof(ButtonBackColor)); }
        set { SetPropertyValue(nameof(ButtonBackColor), value); }
    }

    [DefaultValue("")]
    public string PassportTicket
    {
        get { return GetPropertyValue<string>(nameof(PassportTicket)); }
        set { SetPropertyValue(nameof(PassportTicket), value); }
    }

    [DefaultValue("")]
    public string PassportProfile
    {
        get { return GetPropertyValue<string>(nameof(PassportProfile)); }
        set { SetPropertyValue(nameof(PassportProfile), value); }
    }

    [DefaultValue(0)]
    public uint Feature
    {
        get { return GetPropertyValue<uint>(nameof(Feature)); }
        set { SetPropertyValue(nameof(Feature), value); }
    }

    [DefaultValue("Welcome to MSN Chat! MSN does not control or endorse the content, messages or information found in chat. MSN specifically disclaims any liability with regard to these areas. To review the MSN Chat guidelines, go to http://groups.msn.com/conduct NOTICE: To help protect you from spam, MSN Chat is now available by subscription only. Learn more at http://getchat.msn.com")]
    public string MessageOfTheDay
    {
        get { return GetPropertyValue<string>(nameof(MessageOfTheDay)); }
        set { SetPropertyValue(nameof(MessageOfTheDay), value); }
    }

    [DefaultValue("")]
    public string ChannelLanguage
    {
        get { return GetPropertyValue<string>(nameof(ChannelLanguage)); }
        set { SetPropertyValue(nameof(ChannelLanguage), value); }
    }

    [DefaultValue("")]
    public string InvitationCode
    {
        get { return GetPropertyValue<string>(nameof(InvitationCode)); }
        set { SetPropertyValue(nameof(InvitationCode), value); }
    }

    [DefaultValue("")]
    public string NicknameToInvite
    {
        get { return GetPropertyValue<string>(nameof(NicknameToInvite)); }
        set { SetPropertyValue(nameof(NicknameToInvite), value); }
    }

    [DefaultValue("")]
    public string MSNREGCookie
    {
        get { return GetPropertyValue<string>(nameof(MSNREGCookie)); }
        set { SetPropertyValue(nameof(MSNREGCookie), value); }
    }

    [DefaultValue("f")]
    public string CreationModes
    {
        get { return GetPropertyValue<string>(nameof(CreationModes)); }
        set { SetPropertyValue(nameof(CreationModes), value); }
    }

    [DefaultValue("")]
    public string MSNProfile
    {
        get { return GetPropertyValue<string>(nameof(MSNProfile)); }
        set { SetPropertyValue(nameof(MSNProfile), value); }
    }

    [DefaultValue("en-us")]
    public string Market
    {
        get { return GetPropertyValue<string>(nameof(Market)); }
        set { SetPropertyValue(nameof(Market), value); }
    }

    [DefaultValue("http://chat.msn.com/whisper.msnw")]
    public string WhisperContent
    {
        get { return GetPropertyValue<string>(nameof(WhisperContent)); }
        set { SetPropertyValue(nameof(WhisperContent), value); }
    }

    [DefaultValue("")]
    public string UserRole
    {
        get { return GetPropertyValue<string>(nameof(UserRole)); }
        set { SetPropertyValue(nameof(UserRole), value); }
    }

    [DefaultValue("Note: MSN has detected that you are connected to this chat session from the IP address <B>%1</B>.")]
    public string AuditMessage
    {
        get { return GetPropertyValue<string>(nameof(AuditMessage)); }
        set { SetPropertyValue(nameof(AuditMessage), value); }
    }

    [DefaultValue("")]
    public string SubscriberInfo
    {
        get { return GetPropertyValue<string>(nameof(SubscriberInfo)); }
        set { SetPropertyValue(nameof(SubscriberInfo), value); }
    }

    [DefaultValue("")]
    public string UpsellURL
    {
        get { return GetPropertyValue<string>(nameof(UpsellURL)); }
        set { SetPropertyValue(nameof(UpsellURL), value); }
    }
  }
}
