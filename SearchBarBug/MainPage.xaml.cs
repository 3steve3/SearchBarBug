namespace SearchBarBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        searchBar.Unfocus();
    }
}

