using AnalogClock.Classes;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class AnalogClock : Form
    {
        public AnalogClock()
        {
            InitializeComponent();
            Clock clock = new Clock(ref Surface);
        }
    }
}
