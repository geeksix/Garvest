using System;
using Gtk;

namespace Garvest {



	public partial class LoginWindow: Gtk.Window
	{
		public LoginWindow () : base (Gtk.WindowType.Toplevel)
		{
			Build ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnButton3Clicked (object sender, EventArgs e)
		{
			//Handle Login

			//Launch New Window
			MainWindow window = new MainWindow ();
			window.Show ();
		}
	}

}