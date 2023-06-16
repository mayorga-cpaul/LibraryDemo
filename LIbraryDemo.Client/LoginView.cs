using LibraryDemo.Client.Models;
using LIbraryDemo.Client.Common;
using LIbraryDemo.Client.Interfaces;

namespace LIbraryDemo.Client;

public partial class LoginView : Form
{
    private readonly AuthorView _authorView;
    private readonly IUserServices _userServices;

    public LoginView(AuthorView authorView, IUserServices userServices)
    {
        InitializeComponent();
        _authorView = authorView;
        _userServices = userServices;
        loading.Visible = false;
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            var issuer = new Login()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };

            var result = await _userServices.AccessToAPI(issuer);


            if (Counter.Count == 2)
            {
                MessageBox.Show("Too many failed attempts please wait 10 minutes");
                btnLogin.Visible = false;
                loading.Visible = true;
                await Task.Delay(600000);
                btnLogin.Visible = true;
                loading.Visible = false;
                Counter.Count = 0;
            }

            if (result is null)
            {
                MessageBox.Show("Error, try again, wait a moment");
                btnLogin.Visible = false;
                loading.Visible = true;
                await Task.Delay(10000);
                btnLogin.Visible = true;
                loading.Visible = false;
                Counter.Count++;
            }

            if (result != null) 
            {
                _authorView.Show();
                this.Hide();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
