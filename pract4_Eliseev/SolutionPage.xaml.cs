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
        if (selectedRadioButton.Content.ToString() == "������" || selectedRadioButton.Content.ToString() == "�������" || selectedRadioButton.Content.ToString() == "�������")
        {
            labelSeasons.Text = "����� ����:����";
        }
        else if (selectedRadioButton.Content.ToString() == "����" || selectedRadioButton.Content.ToString() == "������" || selectedRadioButton.Content.ToString() == "���")
        {
            labelSeasons.Text = "����� ����:�����";
        }
        else if (selectedRadioButton.Content.ToString() == "����" || selectedRadioButton.Content.ToString() == "����" || selectedRadioButton.Content.ToString() == "������")
        {
            labelSeasons.Text = "����� ����:����";
        }
        else if (selectedRadioButton.Content.ToString() == "��������" || selectedRadioButton.Content.ToString() == "�������" || selectedRadioButton.Content.ToString() == "������")
        {
            labelSeasons.Text = "����� ����:�����";
        }
    }
}