using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {

            DoubleAnimation animLeft = new DoubleAnimation(Canvas.GetLeft(button), -500, new Duration(TimeSpan.FromSeconds(1)));
            DoubleAnimation animTop = new DoubleAnimation(Canvas.GetTop(button), -500, new Duration(TimeSpan.FromSeconds(1)));

            animLeft.EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut };
            animTop.EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut };

            button.BeginAnimation(Canvas.LeftProperty, animLeft, HandoffBehavior.SnapshotAndReplace);
            button.BeginAnimation(Canvas.TopProperty, animTop, HandoffBehavior.SnapshotAndReplace);

        }

        private void btn2_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation animLeft = new DoubleAnimation(Canvas.GetLeft(btn2), -500, new Duration(TimeSpan.FromSeconds(1)));
            DoubleAnimation animTop = new DoubleAnimation(Canvas.GetTop(btn2), -500, new Duration(TimeSpan.FromSeconds(1)));

            animLeft.EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut };
            animTop.EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut };

            btn2.BeginAnimation(Canvas.LeftProperty, animLeft, HandoffBehavior.SnapshotAndReplace);
            btn2.BeginAnimation(Canvas.TopProperty, animTop, HandoffBehavior.SnapshotAndReplace);
        }

        private void btn3_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation animLeft = new DoubleAnimation(Canvas.GetLeft(btn3), -500, new Duration(TimeSpan.FromSeconds(1)));
            DoubleAnimation animTop = new DoubleAnimation(Canvas.GetTop(btn3), -500, new Duration(TimeSpan.FromSeconds(1)));

            animLeft.EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut };
            animTop.EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut };

            btn3.BeginAnimation(Canvas.LeftProperty, animLeft, HandoffBehavior.SnapshotAndReplace);
            btn3.BeginAnimation(Canvas.TopProperty, animTop, HandoffBehavior.SnapshotAndReplace);
        }
    }
}
