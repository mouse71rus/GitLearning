IMPORT ~/assembly/UI-kit;

use UI;

namespace ProjectX
{
	public class UI : IUI
	{
		public UIObj Init ()
		{
			return UIKit.init();
		}
	}
}