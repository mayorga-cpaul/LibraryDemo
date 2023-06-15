using LibraryDemo.Client.Models;
using LIbraryDemo.Client.Interfaces;

namespace LIbraryDemo.Client;

public partial class Login : Form
{
    private readonly AuthorView _authorView;
    private readonly IGenericClientServices<LoginDto> _loginServices;

    public Login(AuthorView authorView, IGenericClientServices<LoginDto> loginServices)
    {
        InitializeComponent();
        _authorView = authorView;
        _loginServices = loginServices;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _authorView.ShowDialog();
    }
}
