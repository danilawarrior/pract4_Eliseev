namespace pract4_Eliseev;

public partial class SolutionPage2 : ContentPage
{
    Dictionary<string, string> mounthDictionary = new Dictionary<string, string>()
    {
        {"июнь", "Лето" },
        {"июль", "Лето" },
        {"август" , "Лето" },
        {"сентябрь", "Осень" },
        {"октябрь" , "Осень" },
        {"ноябрь" , "Осень" },
        {"декабрь" , "Зима" },
        {"январь" , "Зима" },
        {"февраль" , "Зима" },
        {"март" , "Весна" },
        {"апрель" , "Весна" },
        {"май" , "Весна" }
    };
	public SolutionPage2()
	{
		InitializeComponent();
       
    }

    private async void entrMounth_Completed(object sender, EventArgs e)
    {
        if (mounthDictionary.ContainsKey(entrMounth.Text.ToString().ToLower()))
        {
            labelSeasons.Text = mounthDictionary[entrMounth.Text.ToString().ToLower()];
        }
        else
        {
            await DisplayAlert("Ошибка!", "Такого месяца нет", "ОK");
        }
    }





}