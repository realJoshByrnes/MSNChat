using MSNChat;

namespace AxMSNChat
{
  [AxHost.ClsidAttribute("{f58e1cef-a068-4c15-ba5e-587caf3ee8c6}")]
  [System.ComponentModel.DesignTimeVisibleAttribute(true)]
  public class AxMSNChatFrame : System.Windows.Forms.AxHost
  {
    public event EventHandler? ControlReady;
    private MSNChat.IChatFrame ocx;

    public AxMSNChatFrame()
      : base("f58e1cef-a068-4c15-ba5e-587caf3ee8c6") { }

    public MSNChatFrame MSNChatFrame
    {
      get { return (MSNChatFrame)this.ocx; }
    }

    [System.ComponentModel.Browsable(true)]
    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    [System.Runtime.InteropServices.ComAliasNameAttribute("System.UInt32")]
    public override System.Drawing.Color BackColor
    {
      get
      {
        if (((this.ocx != null) && (this.PropsValid() == true)))
        {
          return GetColorFromOleColor(((uint)(this.ocx.BackColor)));
        }
        else
        {
          return base.BackColor;
        }
      }
      set
      {
        base.BackColor = value;
        if ((this.ocx != null))
        {
          this.ocx.BackColor = ((uint)(GetOleColorFromColor(value)));
        }
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(2)]
    public virtual string RoomName
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "RoomName",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.RoomName;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "RoomName",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.RoomName = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(3)]
    public virtual string HexRoomName
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "HexRoomName",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.HexRoomName;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "HexRoomName",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.HexRoomName = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(4)]
    public virtual string NickName
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "NickName",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.NickName;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "NickName",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.NickName = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(5)]
    public virtual string Server
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Server",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.Server;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Server",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.Server = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(6)]
    [System.Runtime.InteropServices.ComAliasNameAttribute("System.UInt32")]
    public virtual System.Drawing.Color BackHighlightColor
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "BackHighlightColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return GetColorFromOleColor(((uint)(this.ocx.BackHighlightColor)));
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "BackHighlightColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.BackHighlightColor = ((uint)(GetOleColorFromColor(value)));
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(7)]
    [System.Runtime.InteropServices.ComAliasNameAttribute("System.UInt32")]
    public virtual System.Drawing.Color ButtonFrameColor
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ButtonFrameColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return GetColorFromOleColor(((uint)(this.ocx.ButtonFrameColor)));
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ButtonFrameColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.ButtonFrameColor = ((uint)(GetOleColorFromColor(value)));
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(8)]
    [System.Runtime.InteropServices.ComAliasNameAttribute("System.UInt32")]
    public virtual System.Drawing.Color TopBackHighlightColor
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "TopBackHighlightColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return GetColorFromOleColor(((uint)(this.ocx.TopBackHighlightColor)));
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "TopBackHighlightColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.TopBackHighlightColor = ((uint)(GetOleColorFromColor(value)));
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(9)]
    public virtual int ChatMode
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ChatMode",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.ChatMode;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ChatMode",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.ChatMode = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(10)]
    public virtual string URLBack
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "URLBack",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.URLBack;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "URLBack",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.URLBack = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(11)]
    public virtual string Category
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Category",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.Category;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Category",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.Category = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(12)]
    public virtual string Topic
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Topic",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.Topic;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Topic",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.Topic = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(13)]
    public virtual string WelcomeMsg
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "WelcomeMsg",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.WelcomeMsg;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "WelcomeMsg",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.WelcomeMsg = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(15)]
    public virtual string BaseURL
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "BaseURL",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.BaseURL;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "BaseURL",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.BaseURL = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(16)]
    [System.Runtime.InteropServices.ComAliasNameAttribute("System.UInt32")]
    public virtual System.Drawing.Color InputBorderColor
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "InputBorderColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return GetColorFromOleColor(((uint)(this.ocx.InputBorderColor)));
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "InputBorderColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.InputBorderColor = ((uint)(GetOleColorFromColor(value)));
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(17)]
    public virtual string CreateRoom
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "CreateRoom",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.CreateRoom;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "CreateRoom",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.CreateRoom = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(19)]
    public virtual string ChatHome
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ChatHome",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.ChatHome;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ChatHome",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.ChatHome = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(20)]
    public virtual string Locale
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Locale",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.Locale;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Locale",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.Locale = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(21)]
    public virtual string ResDLL
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ResDLL",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.ResDLL;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ResDLL",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        //this.ocx.ResDLL = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(22)]
    [System.Runtime.InteropServices.ComAliasNameAttribute("System.UInt32")]
    public virtual System.Drawing.Color ButtonTextColor
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ButtonTextColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return GetColorFromOleColor(((uint)(this.ocx.ButtonTextColor)));
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ButtonTextColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.ButtonTextColor = ((uint)(GetOleColorFromColor(value)));
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(23)]
    [System.Runtime.InteropServices.ComAliasNameAttribute("System.UInt32")]
    public virtual System.Drawing.Color ButtonBackColor
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ButtonBackColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return GetColorFromOleColor(((uint)(this.ocx.ButtonBackColor)));
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ButtonBackColor",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.ButtonBackColor = ((uint)(GetOleColorFromColor(value)));
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(24)]
    public virtual string PassportTicket
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "PassportTicket",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.PassportTicket;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "PassportTicket",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.PassportTicket = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(25)]
    public virtual string PassportProfile
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "PassportProfile",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.PassportProfile;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "PassportProfile",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.PassportProfile = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(26)]
    public virtual uint Feature
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Feature",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.Feature;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Feature",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.Feature = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(27)]
    public virtual string MessageOfTheDay
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "MessageOfTheDay",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.MessageOfTheDay;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "MessageOfTheDay",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.MessageOfTheDay = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(28)]
    public virtual string ChannelLanguage
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ChannelLanguage",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.ChannelLanguage;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ChannelLanguage",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.ChannelLanguage = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(29)]
    public virtual string InvitationCode
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "InvitationCode",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.InvitationCode;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "InvitationCode",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.InvitationCode = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(30)]
    public virtual string NicknameToInvite
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "NicknameToInvite",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.NicknameToInvite;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "NicknameToInvite",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.NicknameToInvite = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(31)]
    public virtual string MSNREGCookie
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "MSNREGCookie",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.MSNREGCookie;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "MSNREGCookie",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.MSNREGCookie = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(32)]
    public virtual string CreationModes
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "CreationModes",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.CreationModes;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "CreationModes",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.CreationModes = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(33)]
    public virtual string MSNProfile
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "MSNProfile",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.MSNProfile;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "MSNProfile",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.MSNProfile = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(34)]
    public virtual string Market
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Market",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.Market;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "Market",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.Market = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(35)]
    public virtual string WhisperContent
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "WhisperContent",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.WhisperContent;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "WhisperContent",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.WhisperContent = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(36)]
    public virtual string UserRole
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "UserRole",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.UserRole;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "UserRole",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.UserRole = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(37)]
    public virtual string AuditMessage
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "AuditMessage",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.AuditMessage;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "AuditMessage",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.AuditMessage = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(38)]
    public virtual string SubscriberInfo
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "SubscriberInfo",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.SubscriberInfo;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "SubscriberInfo",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.SubscriberInfo = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(39)]
    public virtual string UpsellURL
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "UpsellURL",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.UpsellURL;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "UpsellURL",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.UpsellURL = value;
      }
    }

    protected override void AttachInterfaces()
    {
      base.AttachInterfaces();
      try
      {
        this.ocx = ((MSNChat.IChatFrame)(this.GetOcx()));
        ControlReady?.Invoke(this, EventArgs.Empty);
      }
      catch (System.Exception) { }
    }
  }

  [System.Windows.Forms.AxHost.ClsidAttribute("{fa980e7e-9e44-4d2f-b3c2-9a5be42525f8}")]
  [System.ComponentModel.DesignTimeVisibleAttribute(true)]
  public class AxChatSettings : AxHost
  {
    public event EventHandler? ControlReady;
    private MSNChat.IChatSettings ocx;

    public AxChatSettings()
      : base("fa980e7e-9e44-4d2f-b3c2-9a5be42525f8") { }

    public ChatSettings ChatSettings
    {
      get { return (ChatSettings)this.ocx; }
    }

    [System.ComponentModel.Browsable(true)]
    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    [System.Runtime.InteropServices.ComAliasNameAttribute("System.UInt32")]
    public override System.Drawing.Color BackColor
    {
      get
      {
        if (((this.ocx != null) && (this.PropsValid() == true)))
        {
          return GetColorFromOleColor(((uint)(this.ocx.BackColor)));
        }
        else
        {
          return base.BackColor;
        }
      }
      set
      {
        base.BackColor = value;
        if ((this.ocx != null))
        {
          this.ocx.BackColor = ((uint)(GetOleColorFromColor(value)));
        }
      }
    }

    [System.ComponentModel.Browsable(true)]
    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(-513)]
    [System.Runtime.InteropServices.ComAliasNameAttribute("System.UInt32")]
    public override System.Drawing.Color ForeColor
    {
      get
      {
        if (((this.ocx != null) && (this.PropsValid() == true)))
        {
          return GetColorFromOleColor(((uint)(this.ocx.ForeColor)));
        }
        else
        {
          return base.ForeColor;
        }
      }
      set
      {
        base.ForeColor = value;
        if ((this.ocx != null))
        {
          this.ocx.ForeColor = ((uint)(GetOleColorFromColor(value)));
        }
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(1)]
    public virtual string RedirectURL
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "RedirectURL",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.RedirectURL;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "RedirectURL",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.RedirectURL = value;
      }
    }

    [System.ComponentModel.DesignerSerializationVisibility(
      System.ComponentModel.DesignerSerializationVisibility.Hidden
    )]
    [System.Runtime.InteropServices.DispIdAttribute(2)]
    public virtual string ResDLL
    {
      get
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ResDLL",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet
          );
        }
        return this.ocx.ResDLL;
      }
      set
      {
        if ((this.ocx == null))
        {
          throw new System.Windows.Forms.AxHost.InvalidActiveXStateException(
            "ResDLL",
            System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet
          );
        }
        this.ocx.ResDLL = value;
      }
    }

    protected override void AttachInterfaces()
    {
      base.AttachInterfaces();
      try
      {
        this.ocx = ((MSNChat.IChatSettings)(this.GetOcx()));
        ControlReady?.Invoke(this, EventArgs.Empty);
      }
      catch (System.Exception) { }
    }
  }
}
