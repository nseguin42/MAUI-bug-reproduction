namespace BugReproduction;

public partial class MainPage : ContentPage
{
	string _searchBarText;
	string _entryText;

	public string SearchBarText
	{
		get => _searchBarText;
		set
		{
			_searchBarText = value;
			OnPropertyChanged();
		}
	}

	public string EntryText
	{
		get => _entryText;
		set
		{
			_entryText = value;
			OnPropertyChanged();
		}
	}
	

	public MainPage()
	{
		InitializeComponent();
	}
}
