using System.Collections.ObjectModel;
using System.ComponentModel;
using CollectionViewHeaderEntryFocus.Models;

namespace CollectionViewHeaderEntryFocus;

public partial class MainPage : INotifyPropertyChanged
{
	private ObservableCollection<Article> _items;
	public ObservableCollection<Article> Items
	{
		get => _items;
		set
		{
			_items = value;
			OnPropertyChanged(nameof(Items));
		}
	}
	
	public MainPage()
	{
		InitializeComponent(); 
		Items = [];
		BindingContext = this;
	}

	private void InputView_OnTextChanged(object? sender, TextChangedEventArgs e)
	{
		AddListItems();
	}
	
	private void AddListItems()
	{
		Items.Clear();
		for (var i = 0; i < 10; i++)
		{
			Items.Add(new Article("Title " + i, "Description " + i));
		}
	}
	
	public new event PropertyChangedEventHandler? PropertyChanged;

	protected override void OnPropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}