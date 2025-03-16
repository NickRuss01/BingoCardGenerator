using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BingoCardGenerator;

/// <summary>
/// BingoCardGenerator allows a user to customize a 5x5 grid of bingo squares to enter custom text into.
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        //bingoCardTitle();
        //userInput();
    }

}

public partial class FiveByFiveGrid : Grid
{
    //grid that the user's input displays onto
    public FiveByFiveGrid()
    {
 
    }
}