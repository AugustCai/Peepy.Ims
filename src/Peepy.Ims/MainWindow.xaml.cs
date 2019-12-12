using Peepy.Ims.Domain;
using System.Windows;

namespace Peepy.Ims
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IUserService _userService;
        public MainWindow(IUserService userService)
        {
            _userService = userService;
            //_userService.CreateDb();
            InitializeComponent();
        }
    }
}
