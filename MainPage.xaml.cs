using MauiApp1.Classes;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	Car audi;
	Car nissan;
	bool isFinish = false;

	public MainPage()
	{
		InitializeComponent();

		audi = new Car("A1",220,10);
		audi.UseFuelRate = 10;
		nissan = new Car("S1",180,3);
		nissan.UseFuelRate = 8;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if(!this.isFinish)
		{
			var screenwidth = Application.Current.MainPage.Width;
		    this.audiRun(screenwidth);
			this.nissanRun(screenwidth);
			this.myLabel.Text = audi.ShowInfo() + "\n" + nissan.ShowInfo();
			this.isFinish = true;
		}
		else
		{
			ImageCar1.TranslateTo(0,0,0,Easing.Linear);
			ImageCar2.TranslateTo(0,0,0,Easing.Linear);
			this.isFinish = false;
		}
		
        //audi.Run(10);
		//nissan.Run(5);
		//myLabel.Text = audi.ShowInfo() + "\n" + nissan.ShowInfo();
	}
	private void audiRun (double distance)
	{
		var timeuse = audi.TimeUseForRun(distance);
		ImageCar1.TranslateTo(distance-100,0,timeuse*1000,Easing.Linear);
	}
	private void nissanRun (double distance)
	{
		var timeuse = nissan.TimeUseForRun(distance);
		ImageCar2.TranslateTo(distance-100,0,timeuse*1000,Easing.Linear);
	}
		
}
