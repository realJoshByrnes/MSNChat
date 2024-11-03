using AxMSNChat;

namespace MSNChatControlLibrary
{
  public partial class ChatSettingsControl : UserControl
  {
    private AxChatSettings? axChatSettings;
    private Dictionary<string, object> propertyValues = new Dictionary<string, object>();
    private bool interfacesAttached = false;

    public ChatSettingsControl()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      SuspendLayout();
      //
      // ChatSettingsControl
      //
      Name = "ChatSettingsControl";
      Load += ChatSettingsControl_Load;
      ResumeLayout(false);
    }

    private void AxChatSettings_ControlReady(object? sender, EventArgs e)
    {
      interfacesAttached = true;
      foreach (var property in propertyValues)
      {
        var propertyInfo = typeof(AxChatSettings).GetProperty(property.Key);
        if (propertyInfo != null)
        {
          propertyInfo.SetValue(axChatSettings, property.Value);
        }
      }
      propertyValues.Clear();
    }

    private void SetPropertyValue(string propertyName, object value)
    {
      if (interfacesAttached)
      {
        var propertyInfo = typeof(AxChatSettings).GetProperty(propertyName);
        if (propertyInfo != null)
        {
          propertyInfo.SetValue(axChatSettings, value);
        }
      }
      else
      {
        propertyValues[propertyName] = value;
      }
    }

    private void ChatSettingsControl_Load(object sender, EventArgs e)
    {
      if (DesignMode)
      {
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
      // Initialize AxChatSettings
      axChatSettings = new AxChatSettings();
      axChatSettings.Dock = DockStyle.Fill;
      axChatSettings.ControlReady += AxChatSettings_ControlReady;
      this.Controls.Add(axChatSettings);
    }

    private T GetPropertyValue<T>(string propertyName)
    {
      if (interfacesAttached)
      {
        var propertyInfo = typeof(AxChatSettings).GetProperty(propertyName);
        if (propertyInfo != null)
        {
          return (T)propertyInfo.GetValue(axChatSettings)!;
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

    // Properties to expose AxChatSettings properties
    public new Color BackColor
    {
      get { return GetPropertyValue<Color>(nameof(BackColor)); }
      set { SetPropertyValue(nameof(BackColor), value); }
    }

    public new Color ForeColor
    {
      get { return GetPropertyValue<Color>(nameof(ForeColor)); }
      set { SetPropertyValue(nameof(ForeColor), value); }
    }

    public string RedirectURL
    {
      get { return GetPropertyValue<string>(nameof(RedirectURL)); }
      set { SetPropertyValue(nameof(RedirectURL), value); }
    }

    public string ResDLL
    {
      get { return GetPropertyValue<string>(nameof(ResDLL)); }
      set { SetPropertyValue(nameof(ResDLL), value); }
    }
  }
}
