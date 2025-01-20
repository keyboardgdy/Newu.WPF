using Newu.WPF.UI.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace Newu.WPF.UI.Views.Pages
{
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
}
