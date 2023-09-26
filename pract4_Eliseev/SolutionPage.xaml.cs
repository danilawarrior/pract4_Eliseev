namespace pract4_Eliseev;

public partial class SolutionPage: ContentPage
{
	public SolutionPage()
	{
		InitializeComponent();
	}

    void checkChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton selectedRadioButton = ((RadioButton)sender);
        if (selectedRadioButton.Content.ToString() == "Январь" || selectedRadioButton.Content.ToString() == "Февраль" || selectedRadioButton.Content.ToString() == "Декабрь")
        {
            labelSeasons.Text = "Время года:Зима";
        }
        else if (selectedRadioButton.Content.ToString() == "Март" || selectedRadioButton.Content.ToString() == "Апрель" || selectedRadioButton.Content.ToString() == "Май")
        {
            labelSeasons.Text = "Время года:Весна";
        }
        else if (selectedRadioButton.Content.ToString() == "Июнь" || selectedRadioButton.Content.ToString() == "Июль" || selectedRadioButton.Content.ToString() == "Август")
        {
            labelSeasons.Text = "Время года:Лето";
        }
        else if (selectedRadioButton.Content.ToString() == "Сентябрь" || selectedRadioButton.Content.ToString() == "Октябрь" || selectedRadioButton.Content.ToString() == "Ноябрь")
        {
            labelSeasons.Text = "Время года:Осень";
        }
    }
}