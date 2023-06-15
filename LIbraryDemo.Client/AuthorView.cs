using LibraryDemo.Client.Models;
using LIbraryDemo.Client.Interfaces;

namespace LIbraryDemo.Client;

public partial class AuthorView : Form
{
    private readonly IGenericClientServices<AuthorDto> _authorServices;
    public AuthorView(IGenericClientServices<AuthorDto> authorServices)
    {
        InitializeComponent();
        _authorServices = authorServices;
    }
}
