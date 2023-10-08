using ShiftComparingUI.ViewModels;

namespace ShiftComparingUI.Views.Persons;

public partial class AllPersonsView : ContentPage
{
    public AllPersonsView(PersonsViewModel pvm)
    {
        InitializeComponent();
        BindingContext = pvm;
    }
}