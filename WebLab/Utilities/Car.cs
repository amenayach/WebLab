using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebLab.Utilities
{
    public class Car
    {
        readonly Action _dlg = null;
        readonly Control _ctrl = null;
        int _sp = 10;
        readonly int _frotement = 1;

        Point _target;

        private void ShellSpeed()
        {
            try
            {
                Timer tm = new Timer
                {
                    Interval = 1,
                    Enabled = true
                };
                tm.Tick += tm_Tick;
            }
            catch
            {
            }
        }

        private void tm_Tick(object sender, System.EventArgs e)
        {
            if (_sp <= 0)
            {
                ((Timer)sender).Enabled = false;
                ((Timer)sender).Tick -= tm_Tick;
            }
            else
            {
                if (_ctrl.Left != _target.X)
                    _ctrl.Left += Math.Min(_sp, Math.Abs(_ctrl.Left - _target.X)) * (_ctrl.Left < _target.X ? 1 : -1);
                if (_ctrl.Top != _target.Y)
                    _ctrl.Top += Math.Min(_sp, Math.Abs(_ctrl.Top - _target.Y)) * (_ctrl.Top < _target.Y ? 1 : -1);
                //If lmt <= 0 Or _ctrl.Top + _sp <= lmt Then _ctrl.Top += _sp
                if (_sp > 1)
                    _sp -= _frotement;

                if (_ctrl.Left == _target.X && _ctrl.Top == _target.Y)
                {
                    ((Timer)sender).Enabled = false;
                    ((Timer)sender).Tick -= tm_Tick;
                    ((Timer)sender).Dispose();
                    sender = null;
                    if (_dlg != null)
                        _dlg.DynamicInvoke();
                }
                _ctrl.BringToFront();
                //_ctrl.FindForm.Text = _ctrl.Location.ToString
            }
        }

        public Car(Control ctl, Point _target, int speed, int Frotement = 1, Action EndDelegate = null)
        {
            _ctrl = ctl;
            _sp = speed;
            this._target = _target;
            _frotement = Frotement;
            _dlg = EndDelegate;
            ShellSpeed();
        }

        public static void Drive(Control ctl, Point _target, int speed, int Frotement = 1)
        {
            Car cl = new Car(ctl, _target, speed, Frotement);
        }

        public static void Drive(Control ctl, Point SourcePoint, Point TargetPoint, int speed, int Frotement = 1)
        {
            ctl.Location = SourcePoint;
            Car cl = new Car(ctl, TargetPoint, speed, Frotement);
        }

        public static void DriveToEnd(Control ctl, Point _target, int speed, int Frotement = 1, Action EndDelegate = null)
        {
            Car cl = new Car(ctl, _target, speed, Frotement, EndDelegate);
        }
    }
}
