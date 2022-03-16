using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace paint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Figure c = ListOfFigures.circle;
            Figure t = ListOfFigures.triangle;
            Figure e = ListOfFigures.ellipse;
            Figure l = ListOfFigures.line;
            Figure r = ListOfFigures.rhombus;
            Figure s = ListOfFigures.square;




            InitializeComponent();
            grid.Children.Add(c.DrawFigure());
            grid.Children.Add(t.DrawFigure());
            grid.Children.Add(e.DrawFigure());
            grid.Children.Add(l.DrawFigure());
            grid.Children.Add(r.DrawFigure());
            grid.Children.Add(s.DrawFigure());

        }
    }
}
