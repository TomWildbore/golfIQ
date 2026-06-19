using golfIQ.Models;
using golfIQ.Services;

namespace golfIQ.Views;

public partial class NewRoundPage : ContentPage
{
    private readonly DatabaseService _database;

    public NewRoundPage(DatabaseService database)
    {
        InitializeComponent();
        _database = database;
    }

    private async void OnSaveRoundClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(CourseEntry.Text))
        {
            await DisplayAlert(
                "Missing Course",
                "Please enter a course name.",
                "OK");

            return;
        }

        if (!int.TryParse(ScoreEntry.Text, out int score))
        {
            await DisplayAlert(
                "Invalid Score",
                "Please enter a valid score.",
                "OK");

            return;
        }

        var round = new Round
        {
            CourseName = CourseEntry.Text,
            Date = RoundDatePicker.Date,
            Score = score
        };

        await _database.AddRoundAsync(round);

        await DisplayAlert(
            "Success",
            "Round saved successfully!",
            "OK");

        await Shell.Current.GoToAsync("..");
    }
}