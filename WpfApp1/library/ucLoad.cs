using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.library
{
    public class ucLoad
    {
        public static void uc_Load(Grid grid, UserControl userControl)
        {
            if(grid.Children.Count > 0)
            {
                grid.Children.Clear();
                grid.Children.Add(userControl);
            }
            else
            {
                grid.Children.Add(userControl);
            }
        }
    }
}
