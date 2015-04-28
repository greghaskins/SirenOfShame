﻿using System;

using Foundation;
using AppKit;
using System.Runtime.InteropServices;
using System.Text;

namespace SirenOfShame.Extruder.Mac
{
	public partial class MainWindowController : NSWindowController
	{
		SosOnlineService _sosOnlineService;

		public MainWindowController (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
		}

		public MainWindowController () : base ("MainWindow")
		{
		}

		[DllImport("libMyCppLib")]
		public static extern string GetHelloCount();

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
			_sosOnlineService = new SosOnlineService ();
			GoButton.Activated += GoButtonClicked;
			TestSirenButton.Activated += TestSirenButtonClicked;

//			using (var sirenOfShameDevice = new SirenOfShameDevice ()) {
//				if (sirenOfShameDevice.TryConnect ()) {
//					MainLabel.StringValue = "Found it !!!!";
//					System.Threading.Thread.Sleep (500);
//					MainLabel.StringValue = sirenOfShameDevice.ReadDeviceInfo ();
//				} else {
//					MainLabel.StringValue = "No Device Found :(";
//				}
//			}
		}

		private string GetEncryptedPassword() {
			var tdse = new TripleDesStringEncryptor ();
			string unencryptedPassword = Password.StringValue;
			return tdse.EncryptString(unencryptedPassword);
		}

		[DllImport("libMyCppLib", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		public static extern void ReadLedPatterns(StringBuilder str, ref Int32 ledId);

		void TestSirenButtonClicked (object sender, EventArgs e) 
		{
			try {
				StringBuilder sb = new StringBuilder(20);
				int ledId = 2;
				ReadLedPatterns(sb, ref ledId);
				MainLabel.StringValue = sb + " " + ledId + "!";
			} catch (Exception ex) {
				MainLabel.StringValue = "Error: " + ex;
			}
		}

		async void GoButtonClicked (object sender, EventArgs e)
		{
			var url = new NSUrl ("http://www.sirenofshame.com/Mobile/App");
			var extruderName = NSHost.Current.Name;
			var encryptedPassword = GetEncryptedPassword();
			var credentialsAsString = "username=" + Username.StringValue + "&encryptedpassword=" + encryptedPassword + "&extruderName=" + extruderName;
			NSMutableUrlRequest request = new NSMutableUrlRequest (url);
			NSData bodyNsData = new NSData (Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(credentialsAsString)), NSDataBase64DecodingOptions.None);
			request.Body = bodyNsData;
			request.HttpMethod = "POST";
			request["content-type"] = "application/x-www-form-urlencoded";

			Browser.MainFrame.LoadRequest(request);

			await _sosOnlineService.ConnectExtruder (new ConnectExtruderModel () {
				UserName = Username.StringValue,
				Password = encryptedPassword,
				Name = extruderName,
				LedPatterns = "",
				AudioPatterns = "",
			});
		}

		public new MainWindow Window {
			get { return (MainWindow)base.Window; }
		}
	}
}
