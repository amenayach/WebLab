using System.Drawing;
using System.Windows.Forms;

namespace WebLab.Utilities
{
    public class Toastr
    {

        private readonly Form _container;
        private readonly Label _label;
        private readonly Timer _timer;
        private readonly int _showDelay;
        private readonly Point _startPoint;
        private readonly Point _endPoint;
        
        public Toastr(Form container, Point startPoint, Point endPoint, int showDelay)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _showDelay = showDelay;
            _container = container;
            _label = new Label();
            _timer = new Timer() { Interval = showDelay };
            _timer.Tick += (sender, args) =>
            {
                _label.Hide();
                _timer.Stop();
            };
            InitializeUi();
        }

        private void InitializeUi()
        {

            _label.AutoSize = true;
            _label.BackColor = Color.LimeGreen;
            _label.Font = new Font("Comic Sans MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _label.ForeColor = Color.White;
            _label.Location = _startPoint;
            _label.Name = "lblToaster";
            _label.Padding = new Padding(10);
            _label.Size = new Size(77, 44);
            _label.TabIndex = 5;
            _label.Text = "";

        }

        public void Show(string message, int showDelay, Point startPoint, Point endPoint)
        {
            _timer.Stop();
            _timer.Interval = showDelay;
            _label.Location = startPoint;
            _label.Text = message;
            _container.Controls.Add(_label);
            _label.Visible = true;
            _label.BringToFront();
            Car.Drive(_label, endPoint, 16, 0);
            _timer.Start();
        }

        public void Show(string message, int showDelay, Point startPoint)
        {
            Show(message, showDelay, startPoint, _endPoint);
        }

        public void Show(string message, int showDelay)
        {
            Show(message, showDelay, _startPoint, _endPoint);
        }

        public void Show(string message)
        {
            Show(message, _showDelay, _startPoint, _endPoint);
        }

    }
}
