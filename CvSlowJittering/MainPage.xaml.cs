using System.Collections.ObjectModel;

namespace CvSlowJittering;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;

		for (int i = 0; i < 40; i++)
		{
			StopTimesGroups.Add(new StopTimesGroup
			{
				CodMode = "8",
				Line = "BUG",
				Name = "Slow",
				StopTimeNames = new List<StopTimeName>
				{
					new StopTimeName
					{
						Name = "BUG",
						Times = new List<string>
						{
							"8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8",
                            "8"
                        }
                    },
                     new StopTimeName
                    {
                        Name = "SLOW",
                        Times = new List<string>
                        {
                            "9",
                            "9",
                            "9",
                            "9",
                            "9",
                            "9",
                            "9",
                            "9",
                            "9",
                            "9",
                            "9",
                            "9",
                            "9",
                            "9",
                            "9",
                            "9"
                        }
                    }
                }
			});

        }
	}

    public ObservableCollection<StopTimesGroup> StopTimesGroups { get; set; } = new ObservableCollection<StopTimesGroup>();
}

