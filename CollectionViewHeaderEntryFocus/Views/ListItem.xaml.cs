namespace CollectionViewHeaderEntryFocus.Views;

public partial class ListItem
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        propertyName: nameof(Title),
        returnType: typeof(string),
        declaringType: typeof(ListItem));
    
    public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(
        propertyName: nameof(Description),
        returnType: typeof(string),
        declaringType: typeof(ListItem));
    
    public ListItem()
    {
        InitializeComponent();
        Container.BindingContext = this;
    }
    
    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string Description
    {
        get => (string)GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }
}