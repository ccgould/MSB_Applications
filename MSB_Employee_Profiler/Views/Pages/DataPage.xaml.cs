using MSB_Employee_Profiler.ViewModels;
using Wpf.Ui.Controls;

namespace MSB_Employee_Profiler.Views.Pages;

/// <summary>
/// Interaction logic for DataView.xaml
/// </summary>
public partial class DataPage : INavigableView<DataViewModel>
{
    public DataViewModel ViewModel { get; }

    public DataPage(DataViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;

        InitializeComponent();
    }
}
