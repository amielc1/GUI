using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ServerBox;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IServerBoxOperations _ServerBoxOperations;
        GUIDataContext _GUIDataContext;
        public MainWindow()
        {
            _ServerBoxOperations = new RemoteServerBox();
            _GUIDataContext = new GUIDataContext();
            InitializeComponent();
            this.DataContext = _GUIDataContext;
        }

        private async void BtnGetPosts_Click(object sender, RoutedEventArgs e)
        {
            //_GUIDataContext.AllPosts = _ServerBoxOperations.GetAllPossts();
            try
            {
                var result = await InsertPostAsync("AmielNewPost");
                listBox.ItemsSource = new List<string>() { "AmielNewPost" };
                _GUIDataContext.AllPosts = await GetAllPostsAsync();
                listBox.ItemsSource = _GUIDataContext.AllPosts;
            }
            catch (Exception ex)
            {

                listBox.ItemsSource = new List<string>() { ex.Message };
            }
         
        }

        Task<IEnumerable<string>> GetAllPostsAsync()
        {
            var posts = Task<IEnumerable<string>>.Factory.StartNew(
                () => _ServerBoxOperations.GetAllPossts()
                    );
            return posts;
        }

        Task<bool> InsertPostAsync(string post)
        {
            var result = Task<bool>.Factory.StartNew(
                () => _ServerBoxOperations.Insert(post)
                    );
            return result;
        }
    }
}
