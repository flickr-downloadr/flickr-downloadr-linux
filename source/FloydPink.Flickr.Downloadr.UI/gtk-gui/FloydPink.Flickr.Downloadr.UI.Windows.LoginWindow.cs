
// This file has been generated by the GUI designer. Do not modify.
namespace FloydPink.Flickr.Downloadr.UI.Windows
{
	public partial class LoginWindow
	{
		private global::Gtk.VBox LoggedOutCanvas;

		private global::Gtk.VBox vbox5;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Alignment alignment8;

		private global::Gtk.Image image5;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Button buttonAbout;

		private global::Gtk.VBox vbox6;

		private global::Gtk.Alignment alignment6;

		private global::Gtk.HBox hboxAvatar;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Image imageBuddyIcon;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Alignment alignment10;

		private global::Gtk.Label labelWelcomeUsername;

		private global::Gtk.Alignment alignment7;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.Label labelMessage;

		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hboxUpdate;

		private global::Gtk.Label labelUpdate;

		private global::Gtk.Alignment alignment11;

		private global::Gtk.HBox hboxLogin;

		private global::Gtk.Alignment alignment5;

		private global::Gtk.Button buttonLogin;

		private global::Gtk.Alignment alignment4;

		private global::Gtk.VBox vbox7;

		private global::Gtk.Alignment alignment9;

		private global::Gtk.HBox hboxBottomButtons;

		private global::Gtk.Button buttonLogout;

		private global::Gtk.Button buttonPrefs;

		private global::Gtk.Button buttonContinue;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget FloydPink.Flickr.Downloadr.UI.Windows.LoginWindow
			this.WidthRequest = 495;
			this.HeightRequest = 287;
			this.Name = "FloydPink.Flickr.Downloadr.UI.Windows.LoginWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Welcome - flickr downloadr");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource("FloydPink.Flickr.Downloadr.UI.Assets.icon.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Resizable = false;
			this.AllowGrow = false;
			this.DefaultWidth = 495;
			this.DefaultHeight = 287;
			// Container child FloydPink.Flickr.Downloadr.UI.Windows.LoginWindow.Gtk.Container+ContainerChild
			this.LoggedOutCanvas = new global::Gtk.VBox();
			this.LoggedOutCanvas.Name = "LoggedOutCanvas";
			this.LoggedOutCanvas.Spacing = 6;
			// Container child LoggedOutCanvas.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.vbox3.BorderWidth = ((uint)(3));
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.alignment8 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment8.Name = "alignment8";
			this.hbox8.Add(this.alignment8);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.alignment8]));
			w1.Position = 0;
			// Container child hbox8.Gtk.Box+BoxChild
			this.image5 = new global::Gtk.Image();
			this.image5.Name = "image5";
			this.image5.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("FloydPink.Flickr.Downloadr.UI.Assets.logo-Small.png");
			this.hbox8.Add(this.image5);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.image5]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.buttonAbout = new global::Gtk.Button();
			this.buttonAbout.WidthRequest = 65;
			this.buttonAbout.HeightRequest = 35;
			this.buttonAbout.CanFocus = true;
			this.buttonAbout.Name = "buttonAbout";
			this.buttonAbout.UseUnderline = true;
			this.buttonAbout.Label = global::Mono.Unix.Catalog.GetString("About");
			this.vbox4.Add(this.buttonAbout);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.buttonAbout]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			w3.Padding = ((uint)(5));
			this.hbox8.Add(this.vbox4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox4]));
			w4.Position = 2;
			w4.Expand = false;
			this.vbox3.Add(this.hbox8);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox8]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox5.Add(this.vbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.vbox3]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.alignment6 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment6.Name = "alignment6";
			this.vbox6.Add(this.alignment6);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.alignment6]));
			w7.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hboxAvatar = new global::Gtk.HBox();
			this.hboxAvatar.Name = "hboxAvatar";
			this.hboxAvatar.Spacing = 6;
			// Container child hboxAvatar.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.hboxAvatar.Add(this.alignment1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hboxAvatar[this.alignment1]));
			w8.Position = 0;
			// Container child hboxAvatar.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.imageBuddyIcon = new global::Gtk.Image();
			this.imageBuddyIcon.Name = "imageBuddyIcon";
			this.hbox4.Add(this.imageBuddyIcon);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.imageBuddyIcon]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment10 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment10.Name = "alignment10";
			this.vbox1.Add(this.alignment10);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.alignment10]));
			w10.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelWelcomeUsername = new global::Gtk.Label();
			this.labelWelcomeUsername.Name = "labelWelcomeUsername";
			this.labelWelcomeUsername.LabelProp = global::Mono.Unix.Catalog.GetString("Welcome, username!");
			this.labelWelcomeUsername.UseMarkup = true;
			this.vbox1.Add(this.labelWelcomeUsername);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelWelcomeUsername]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.vbox1.Add(this.alignment7);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.alignment7]));
			w12.Position = 2;
			this.hbox4.Add(this.vbox1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox1]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.hboxAvatar.Add(this.hbox4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hboxAvatar[this.hbox4]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hboxAvatar.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.hboxAvatar.Add(this.alignment2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hboxAvatar[this.alignment2]));
			w15.Position = 2;
			this.vbox6.Add(this.hboxAvatar);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hboxAvatar]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.labelMessage = new global::Gtk.Label();
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.LabelProp = global::Mono.Unix.Catalog.GetString("Welcome to flickr downloadr. Click \'Login\' to continue.");
			this.vbox6.Add(this.labelMessage);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.labelMessage]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox5.Add(this.vbox6);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.vbox6]));
			w18.Position = 1;
			this.LoggedOutCanvas.Add(this.vbox5);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.LoggedOutCanvas[this.vbox5]));
			w19.Position = 0;
			// Container child LoggedOutCanvas.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hboxUpdate = new global::Gtk.HBox();
			this.hboxUpdate.Name = "hboxUpdate";
			this.hboxUpdate.Spacing = 6;
			// Container child hboxUpdate.Gtk.Box+BoxChild
			this.labelUpdate = new global::Gtk.Label();
			this.labelUpdate.Name = "labelUpdate";
			this.labelUpdate.UseMarkup = true;
			this.hboxUpdate.Add(this.labelUpdate);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hboxUpdate[this.labelUpdate]));
			w20.Position = 0;
			this.vbox2.Add(this.hboxUpdate);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hboxUpdate]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment11 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment11.Name = "alignment11";
			this.vbox2.Add(this.alignment11);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.alignment11]));
			w22.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hboxLogin = new global::Gtk.HBox();
			this.hboxLogin.Name = "hboxLogin";
			this.hboxLogin.Spacing = 6;
			// Container child hboxLogin.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			this.hboxLogin.Add(this.alignment5);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hboxLogin[this.alignment5]));
			w23.Position = 0;
			// Container child hboxLogin.Gtk.Box+BoxChild
			this.buttonLogin = new global::Gtk.Button();
			this.buttonLogin.WidthRequest = 130;
			this.buttonLogin.HeightRequest = 40;
			this.buttonLogin.CanFocus = true;
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.UseUnderline = true;
			this.buttonLogin.Label = global::Mono.Unix.Catalog.GetString("Login");
			this.hboxLogin.Add(this.buttonLogin);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hboxLogin[this.buttonLogin]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hboxLogin.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.hboxLogin.Add(this.alignment4);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hboxLogin[this.alignment4]));
			w25.Position = 2;
			this.vbox2.Add(this.hboxLogin);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hboxLogin]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.alignment9 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment9.Name = "alignment9";
			this.vbox7.Add(this.alignment9);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.alignment9]));
			w27.Position = 0;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hboxBottomButtons = new global::Gtk.HBox();
			this.hboxBottomButtons.Name = "hboxBottomButtons";
			this.hboxBottomButtons.Homogeneous = true;
			this.hboxBottomButtons.Spacing = 6;
			// Container child hboxBottomButtons.Gtk.Box+BoxChild
			this.buttonLogout = new global::Gtk.Button();
			this.buttonLogout.CanFocus = true;
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.UseUnderline = true;
			this.buttonLogout.Label = global::Mono.Unix.Catalog.GetString("Logout");
			this.hboxBottomButtons.Add(this.buttonLogout);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hboxBottomButtons[this.buttonLogout]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			// Container child hboxBottomButtons.Gtk.Box+BoxChild
			this.buttonPrefs = new global::Gtk.Button();
			this.buttonPrefs.CanFocus = true;
			this.buttonPrefs.Name = "buttonPrefs";
			this.buttonPrefs.UseUnderline = true;
			this.buttonPrefs.Label = global::Mono.Unix.Catalog.GetString("Preferences");
			this.hboxBottomButtons.Add(this.buttonPrefs);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hboxBottomButtons[this.buttonPrefs]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			// Container child hboxBottomButtons.Gtk.Box+BoxChild
			this.buttonContinue = new global::Gtk.Button();
			this.buttonContinue.CanFocus = true;
			this.buttonContinue.Name = "buttonContinue";
			this.buttonContinue.UseUnderline = true;
			this.buttonContinue.Label = global::Mono.Unix.Catalog.GetString("Continue");
			this.hboxBottomButtons.Add(this.buttonContinue);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hboxBottomButtons[this.buttonContinue]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			this.vbox7.Add(this.hboxBottomButtons);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hboxBottomButtons]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			w31.Padding = ((uint)(5));
			this.vbox2.Add(this.vbox7);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox7]));
			w32.Position = 3;
			w32.Fill = false;
			this.LoggedOutCanvas.Add(this.vbox2);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.LoggedOutCanvas[this.vbox2]));
			w33.Position = 1;
			this.Add(this.LoggedOutCanvas);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.hboxUpdate.Hide();
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.buttonAbout.Clicked += new global::System.EventHandler(this.buttonAboutClick);
			this.labelUpdate.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler(this.UpdateNotificationClick);
			this.buttonLogin.Clicked += new global::System.EventHandler(this.buttonLoginClick);
			this.buttonLogout.Clicked += new global::System.EventHandler(this.buttonLogoutClick);
			this.buttonPrefs.Clicked += new global::System.EventHandler(this.buttonPrefsClick);
			this.buttonContinue.Clicked += new global::System.EventHandler(this.buttonContinueClick);
		}
	}
}
