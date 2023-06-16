using LibraryDemo.Client.Models;
using LIbraryDemo.Client.Interfaces;

namespace LIbraryDemo.Client;

public partial class AuthorView : Form
{
    private readonly IGenericClientServices<Author, CreateAuthor> _authorServices;
    Author author = new Author();

    public AuthorView(IGenericClientServices<Author, CreateAuthor> authorServices)
    {
        InitializeComponent();
        _authorServices = authorServices;
    }

    private void ChargeDgv(IEnumerable<Author> authors)
    {

        dtgData.DataSource = null;
        dtgData.DataSource = authors;
        dtgData.Columns[3].Visible = false;

        dtgData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dtgData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dtgData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private async void AuthorView_Load(object sender, EventArgs e)
    {
        var authors = await _authorServices.ListAsync();
        ChargeDgv(authors);
        btnUpdate.Enabled = false;
    }

    private async void btnCreate_Click(object sender, EventArgs e)
    {
        try
        {
            CreateAuthor author = new CreateAuthor()
            {
                Name = txtAuthorName.Text,
                Nationality = txtnationality.Text,
                DateOfBirth = dtBirth.Value
            };

            await _authorServices.CreateAsync(author);
            var authors = await _authorServices.ListAsync();
            ChargeDgv(authors);
            RemoveText();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void dtgData_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            author.Id = dtgData.Rows[e.RowIndex].Cells[3].Value.ToString()!;
            author.Name = dtgData.Rows[e.RowIndex].Cells[0].Value.ToString()!;
            author.Nationality = dtgData.Rows[e.RowIndex].Cells[1].Value.ToString()!;
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            if (dtgData.Rows.Count <= 0) throw new Exception("Please add an author");
            if (string.IsNullOrEmpty(author.Id)) throw new Exception("Select an author");

            await _authorServices.DeleteAsync(author.Id);
            MessageBox.Show($"The author {author.Name} was removed");

            // This is not a good practices
            var authors = await _authorServices.ListAsync();
            ChargeDgv(authors);
            RemoveText();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (dtgData.Rows.Count <= 0) throw new Exception("Please add an author");
            if (string.IsNullOrEmpty(author.Id)) throw new Exception("Select an author");

            CreateAuthor authorToUpdate = new CreateAuthor()
            {
                Name = txtnationality.Text,
                Nationality = txtnationality.Text,
                DateOfBirth = dtBirth.Value
            };

            await _authorServices.UpdateAsync(authorToUpdate, author.Id);
            MessageBox.Show($"The author {author.Name} was updated");

            // This is not a good practices
            var authors = await _authorServices.ListAsync();
            ChargeDgv(authors);
            RemoveText();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void tgUpdate_ToggledChanged()
    {
        try
        {
            if (dtgData.Rows.Count <= 0) throw new Exception("Please add an author");
            if (string.IsNullOrEmpty(author.Id)) throw new Exception("Select an author");

            if (tgUpdate.Toggled)
            {
                ChargeLabels();
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                RemoveText();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ChargeLabels()
    {
        txtAuthorName.Text = author.Nationality;
        txtnationality.Text = author.Name;
        btnUpdate.Enabled = true;
    }

    private void RemoveText()
    {
        txtAuthorName.Text = string.Empty;
        txtnationality.Text = string.Empty;
    }
}
