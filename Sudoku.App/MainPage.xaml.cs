

namespace Sudoku.App;
public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}
    protected override bool OnBackButtonPressed()
    {
        return Sudoku.Core.Page.Current.Back();
    }
}
