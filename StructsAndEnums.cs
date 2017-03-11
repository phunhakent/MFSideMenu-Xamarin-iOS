namespace MFSideMenu
{
	public enum MFSideMenuPanMode : uint
	{
		None = 0,
		CenterViewController = 1 << 0,
		SideMenu = 1 << 1,
		Default = CenterViewController | SideMenu
	}

	public enum MFSideMenuState : uint
	{
		Closed,
		LeftMenuOpen,
		RightMenuOpen
	}

	public enum MFSideMenuStateEvent : uint
	{
		WillOpen,
		DidOpen,
		WillClose,
		DidClose
	}
}
