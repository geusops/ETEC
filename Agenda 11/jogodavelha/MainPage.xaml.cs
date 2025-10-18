namespace jogodavelha
{
	public partial class MainPage : ContentPage
	{

		string turn = "X";

		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Button bnt = (Button)sender;

			bnt.IsEnabled = false;
			//Organazing the turn
			if (turn == "X")
			{
				//If it's X's turn, next turn value will be "O"
				bnt.Text = "X";
				turn = "O";
			}
			else
			{
				//If it's O's turn, next turn value will be "X"
				bnt.Text = "O";
				turn = "X";
			}

			//check winner in rows
			//
			//checking if X won 1st row

			//Using return in the end to cancel the other checks if, based on an IA feedback
			if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
			{
				DisplayAlert("Yay", "The X won the game", "Ok");
				ClearCells();
				return;
			}
			// checking if X won 2nd row (Replicado)
			if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
			{
				DisplayAlert("Yay", "The X won the game", "Ok");
				ClearCells();
				return;
			}

			// checking if X won 3rd row (Replicado)
			if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
			{
				DisplayAlert("Yay", "The X won the game", "Ok");
				ClearCells();
				return;
			}

			//checking if O won 1st row
			if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
			{
				DisplayAlert("Yay", "The O won the game", "Ok");
				ClearCells();
				return;
			}
			// checking if O won 2nd row (Replicado)
			if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
			{
				DisplayAlert("Yay", "The O won the game", "Ok");
				ClearCells();
				return;
			}

			// checking if O won 3rd row (Replicado)
			if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
			{
				DisplayAlert("Yay", "The O won the game", "Ok");
				ClearCells();
				return;
			}

			//checking winner in the columns
			//
			// checking if X won 1st column
			if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
			{
				DisplayAlert("Yay", "The X won the game", "Ok");
				ClearCells();
				return;
			}
			// checking if X won 2nd column
			if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
			{
				DisplayAlert("Yay", "The X won the game", "Ok");
				ClearCells();
				return;
			}

			// checking if X won 3rd column
			if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
			{
				DisplayAlert("Yay", "The X won the game", "Ok");
				ClearCells();
				return;
			}

			// checking if O won 1st column
			if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
			{
				DisplayAlert("Yay", "The O won the game", "Ok");
				ClearCells();
				return;
			}
			// checking if O won 2nd column
			if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
			{
				DisplayAlert("Yay", "The O won the game", "Ok");
				ClearCells();
				return;
			}

			// checking if O won 3rd column
			if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
			{
				DisplayAlert("Yay", "The O won the game", "Ok");
				ClearCells();
				return;
			}

			//checking winner in the diagonals
			//
			// checking if X won from top-left to bottom-right
			if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
			{
				DisplayAlert("Yay", "The X won the game", "Ok");
				ClearCells();
				return;
			}

			// checking if X won from top-right to bottom-left
			if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
			{
				DisplayAlert("Yay", "The X won the game", "Ok");
				ClearCells();
				return;
			}

			// checking if O won from top-left to bottom-right
			if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
			{
				DisplayAlert("Yay", "The O won the game", "Ok");
				ClearCells();
				return;
			}

			// checking if O won from top-right to bottom-left
			if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
			{
				DisplayAlert("Yay", "The O won the game", "Ok");
				ClearCells();
				return;
			}

			// checks for a draw
			//reference: https://learn.microsoft.com/pt-br/dotnet/api/system.string.isnullorwhitespace?view=net-9.0
			if (!string.IsNullOrWhiteSpace(btn10.Text) &&
			!string.IsNullOrWhiteSpace(btn11.Text) &&
			!string.IsNullOrWhiteSpace(btn12.Text) &&
			!string.IsNullOrWhiteSpace(btn20.Text) &&
			!string.IsNullOrWhiteSpace(btn21.Text) &&
			!string.IsNullOrWhiteSpace(btn22.Text) &&
			!string.IsNullOrWhiteSpace(btn30.Text) &&
			!string.IsNullOrWhiteSpace(btn31.Text) &&
			!string.IsNullOrWhiteSpace(btn32.Text))
			{
				DisplayAlert("No winner", "It's a draw :/", "Ok");
				ClearCells();
				return;
			}

		}//close method button

		//Clear clear after a game win
		void ClearCells()
		{
			//clearing the content of the button
			// I needed to add an space here because of this known bug:
			//https://github.com/dotnet/maui/issues/18235

			btn10.Text = " ";
			btn11.Text = " ";
			btn12.Text = " ";
			btn20.Text = " ";
			btn21.Text = " ";
			btn22.Text = " ";
			btn30.Text = " ";
			btn31.Text = " ";
			btn32.Text = " ";

			//reenabling the button to allow a new game
			btn10.IsEnabled = true;
			btn11.IsEnabled = true;
			btn12.IsEnabled = true;
			btn20.IsEnabled = true;
			btn21.IsEnabled = true;
			btn22.IsEnabled = true;
			btn30.IsEnabled = true;
			btn31.IsEnabled = true;
			btn32.IsEnabled = true;

			turn = "X";
		} //close method clear

	}//close class
}//close namespace
