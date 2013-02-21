using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UI.Dialog
{
    public class MessageBox : qxDotNet.UI.Window.Window
    {

        private qxDotNet.UI.Basic.Label _label;
        private qxDotNet.UI.Basic.Image _img;
        private qxDotNet.UI.Container.Composite _panelButtons;
        private qxDotNet.UI.Form.Button _btn1;
        private qxDotNet.UI.Form.Button _btn2;
        private qxDotNet.UI.Form.Button _btn3;
        private qxDotNet.UI.Container.Composite _host;
        private MessageBoxCallback _callback;
        private MessageBoxIconEnum _icon = MessageBoxIconEnum.Information;
        private MessageBoxButtonsEnum _buttons = MessageBoxButtonsEnum.Ok;
        private MessageBoxDefaultButtonEnum _defaultButton = MessageBoxDefaultButtonEnum.Button1;
        private DialogResultEnum _result = DialogResultEnum.None;

        #region Localization

        private static string _caption = "Message";
        private static string _buttonOk = "OK";
        private static string _buttonCancel = "Cancel";
        private static string _buttonYes = "Yes";
        private static string _buttonNo = "No";
        private static string _buttonAbort = "Abort";
        private static string _buttonRetry = "Retry";
        private static string _buttonIgnore = "Ignore";

        public static void Localize(
            string defaultCaption,
            string buttonOk,
            string buttonCancel,
            string buttonYes,
            string buttonNo,
            string buttonAbort,
            string buttonRetry,
            string buttonIgnore)
        {
            _caption = defaultCaption;
            _buttonOk = buttonOk;
            _buttonCancel = buttonCancel;
            _buttonYes = buttonYes;
            _buttonNo = buttonNo;
            _buttonAbort = buttonAbort;
            _buttonRetry = buttonRetry;
            _buttonIgnore = buttonIgnore;
        }

        #endregion

        private void _btn1_Execute(object sender, EventArgs e)
        {
            _host.Remove(this);
            switch (_buttons)
            {
                case MessageBoxButtonsEnum.Ok:
                case MessageBoxButtonsEnum.OkCancel:
                    _result = DialogResultEnum.Ok;
                    break;
                case MessageBoxButtonsEnum.YesNo:
                case MessageBoxButtonsEnum.YesNoCancel:
                    _result = DialogResultEnum.Yes;
                    break;
                case MessageBoxButtonsEnum.AbortRetryIgnore:
                    _result = DialogResultEnum.Abort;
                    break;
                case MessageBoxButtonsEnum.RetryCancel:
                    _result = DialogResultEnum.Retry;
                    break;
            }
            if (_callback != null)
            {
                _callback(_result);
            }
        }

        private void _btn2_Execute(object sender, EventArgs e)
        {
            _host.Remove(this);
            switch (_buttons)
            {
                case MessageBoxButtonsEnum.Ok:
                case MessageBoxButtonsEnum.OkCancel:
                    _result = DialogResultEnum.Cancel;
                    break;
                case MessageBoxButtonsEnum.YesNo:
                case MessageBoxButtonsEnum.YesNoCancel:
                    _result = DialogResultEnum.No;
                    break;
                case MessageBoxButtonsEnum.AbortRetryIgnore:
                    _result = DialogResultEnum.Retry;
                    break;
                case MessageBoxButtonsEnum.RetryCancel:
                    _result = DialogResultEnum.Cancel;
                    break;
            }
            if (_callback != null)
            {
                _callback(_result);
            }
        }

        private void _btn3_Execute(object sender, EventArgs e)
        {
            _host.Remove(this);
            switch (_buttons)
            {
                case MessageBoxButtonsEnum.YesNoCancel:
                    _result = DialogResultEnum.Cancel;
                    break;
                case MessageBoxButtonsEnum.AbortRetryIgnore:
                    _result = DialogResultEnum.Ignore;
                    break;
            }
            if (_callback != null)
            {
                _callback(_result);
            }
        }

        public DialogResultEnum Result
        {
            get
            {
                return _result;
            }
        }

        public void Close()
        {
            _host.Remove(this);
        }

        private void Init()
        {
            Layout = new qxDotNet.UI.Layout.Dock();
            _img = new qxDotNet.UI.Basic.Image();
            
            _img.Width = 48;
            _img.Source = "resource/qx/icon/Oxygen/48/status/dialog-information.png";
            switch (_icon)
            {
                case MessageBoxIconEnum.Information:
                    _img.Source = "resource/qx/icon/Oxygen/48/status/dialog-information.png";
                    break;
                case MessageBoxIconEnum.Warning:
                    _img.Source = "resource/qx/icon/Oxygen/48/status/dialog-warning.png";
                    break;
                case MessageBoxIconEnum.Question:
                    _img.Source = "resource/qx/icon/Oxygen/48/status/dialog-warning.png";
                    break;
                case MessageBoxIconEnum.Error:
                    _img.Source = "resource/qx/icon/Oxygen/48/status/dialog-error.png";
                    break;
                default:
                    break;
            }

            _panelButtons = new qxDotNet.UI.Container.Composite();
            var layout = new qxDotNet.UI.Layout.Flow();
            layout.AlignX = AlignXEnum.center;
            layout.SpacingX = 5;
            layout.SpacingY = 15;
            _panelButtons.Layout = layout;
            Add(_panelButtons, new Map().Add("edge", "south"));
            Add(_img, new Map().Add("edge", "west"));
            switch (_buttons)
            {
                case MessageBoxButtonsEnum.Ok:
                    _btn1 = new qxDotNet.UI.Form.Button();
                    _btn1.Label = _buttonOk;
                    _btn1.MinWidth = 60;
                    _btn1.Execute += new EventHandler(_btn1_Execute);
                    _panelButtons.Add(_btn1);
                    break;
                case MessageBoxButtonsEnum.OkCancel:
                    _btn1 = new qxDotNet.UI.Form.Button();
                    _btn1.Label = _buttonOk;
                    _btn1.MinWidth = 60;
                    _btn1.Execute += new EventHandler(_btn1_Execute);
                    _panelButtons.Add(_btn1);

                    _btn2 = new qxDotNet.UI.Form.Button();
                    _btn2.Label = _buttonCancel;
                    _btn2.MinWidth = 60;
                    _btn2.Execute += new EventHandler(_btn2_Execute);
                    _panelButtons.Add(_btn2);
                    break;
                case MessageBoxButtonsEnum.YesNo:
                    _btn1 = new qxDotNet.UI.Form.Button();
                    _btn1.Label = _buttonYes;
                    _btn1.MinWidth = 60;
                    _btn1.Execute += new EventHandler(_btn1_Execute);
                    _panelButtons.Add(_btn1);

                    _btn2 = new qxDotNet.UI.Form.Button();
                    _btn2.Label = _buttonNo;
                    _btn2.MinWidth = 60;
                    _btn2.Execute += new EventHandler(_btn2_Execute);
                    _panelButtons.Add(_btn2);
                    break;
                case MessageBoxButtonsEnum.YesNoCancel:
                    _btn1 = new qxDotNet.UI.Form.Button();
                    _btn1.Label = _buttonYes;
                    _btn1.MinWidth = 60;
                    _btn1.Execute += new EventHandler(_btn1_Execute);
                    _panelButtons.Add(_btn1);

                    _btn2 = new qxDotNet.UI.Form.Button();
                    _btn2.Label = _buttonNo;
                    _btn2.MinWidth = 60;
                    _btn2.Execute += new EventHandler(_btn2_Execute);
                    _panelButtons.Add(_btn2);

                    _btn3 = new qxDotNet.UI.Form.Button();
                    _btn3.Label = _buttonCancel;
                    _btn3.MinWidth = 60;
                    _btn3.Execute += new EventHandler(_btn3_Execute);
                    _panelButtons.Add(_btn3);

                    break;
                case MessageBoxButtonsEnum.AbortRetryIgnore:
                    _btn1 = new qxDotNet.UI.Form.Button();
                    _btn1.Label = _buttonAbort;
                    _btn1.MinWidth = 60;
                    _btn1.Execute += new EventHandler(_btn1_Execute);
                    _panelButtons.Add(_btn1);

                    _btn2 = new qxDotNet.UI.Form.Button();
                    _btn2.Label = _buttonRetry;
                    _btn2.MinWidth = 60;
                    _btn2.Execute += new EventHandler(_btn2_Execute);
                    _panelButtons.Add(_btn2);

                    _btn3 = new qxDotNet.UI.Form.Button();
                    _btn3.Label = _buttonIgnore;
                    _btn3.MinWidth = 60;
                    _btn3.Execute += new EventHandler(_btn3_Execute);
                    _panelButtons.Add(_btn3);
                    break;
                case MessageBoxButtonsEnum.RetryCancel:
                    _btn1 = new qxDotNet.UI.Form.Button();
                    _btn1.Label = _buttonRetry;
                    _btn1.MinWidth = 60;
                    _btn1.Execute += new EventHandler(_btn1_Execute);
                    _panelButtons.Add(_btn1);

                    _btn2 = new qxDotNet.UI.Form.Button();
                    _btn2.Label = _buttonCancel;
                    _btn2.MinWidth = 60;
                    _btn2.Execute += new EventHandler(_btn2_Execute);
                    _panelButtons.Add(_btn2);
                    break;
            }

            switch (_defaultButton)
            {
                case MessageBoxDefaultButtonEnum.Button1:
                    if (_btn1 != null)
                    {
                        _btn1.Focus();
                    }
                    break;
                case MessageBoxDefaultButtonEnum.Button2:
                    if (_btn2 != null)
                    {
                        _btn2.Focus();
                    }
                    break;
                case MessageBoxDefaultButtonEnum.Button3:
                    if (_btn3 != null)
                    {
                        _btn3.Focus();
                    }
                    break;
                default:
                    break;
            }

            Width = 300;
            Height = 150;
            _label = new qxDotNet.UI.Basic.Label();
            _label.PaddingTop = 20;
            _label.PaddingLeft = 10;
            _label.TextAlign = TextAlignEnum.center;
            _label.AllowShrinkX = false;
            Add(_label, new Map().Add("edge", "center"));
            Modal = true;
        }

        public static MessageBox Show(string text, string caption, MessageBoxButtonsEnum buttons, MessageBoxIconEnum icon, MessageBoxDefaultButtonEnum defaultButton, MessageBoxCallback callback)
        {
            var r = new MessageBox();
            r.Centered = true;
            r.Caption = caption;
            r._buttons = buttons;
            r._icon = icon;
            r._defaultButton = defaultButton;
            r.Init();
            r._label.Value = text;
            r._callback = callback;
            var root = (qxDotNet.UI.Container.Composite)Common.ApplicationState.Instance.GUI.GetRoot();
            r._host = root;
            root.Add(r);
            r.Open();
            return r;
        }

        public static MessageBox Show(string text, string caption, MessageBoxButtonsEnum buttons, MessageBoxIconEnum icon, MessageBoxDefaultButtonEnum defaultButton)
        {
            return Show(text, caption, buttons, icon, defaultButton, null);
        }

        public static MessageBox Show(string text, string caption, MessageBoxButtonsEnum buttons, MessageBoxIconEnum icon, MessageBoxCallback callback)
        {
            return Show(text, caption, buttons, icon, MessageBoxDefaultButtonEnum.Button1, callback);
        }

        public static MessageBox Show(string text, string caption, MessageBoxButtonsEnum buttons, MessageBoxIconEnum icon)
        {
            return Show(text, caption, buttons, icon, MessageBoxDefaultButtonEnum.Button1, null);
        }

        public static MessageBox Show(string text, string caption, MessageBoxButtonsEnum buttons, MessageBoxCallback callback)
        {
            return Show(text, caption, buttons, MessageBoxIconEnum.Information, MessageBoxDefaultButtonEnum.Button1, callback);
        }

        public static MessageBox Show(string text, string caption, MessageBoxButtonsEnum buttons)
        {
            return Show(text, caption, buttons, MessageBoxIconEnum.Information, MessageBoxDefaultButtonEnum.Button1, null);
        }

        public static MessageBox Show(string text, string caption, MessageBoxCallback callback)
        {
            return Show(text, caption, MessageBoxButtonsEnum.Ok, MessageBoxIconEnum.Information, MessageBoxDefaultButtonEnum.Button1, callback);
        }

        public static MessageBox Show(string text, string caption)
        {
            return Show(text, caption, MessageBoxButtonsEnum.Ok, MessageBoxIconEnum.Information, MessageBoxDefaultButtonEnum.Button1, null);
        }

        public static MessageBox Show(string text, MessageBoxCallback callback)
        {
            return Show(text, _caption, MessageBoxButtonsEnum.Ok, MessageBoxIconEnum.Information, MessageBoxDefaultButtonEnum.Button1, callback);
        }

        public static MessageBox Show(string text)
        {
            return Show(text, _caption, MessageBoxButtonsEnum.Ok, MessageBoxIconEnum.Information, MessageBoxDefaultButtonEnum.Button1, null);
        }

        protected override void OnClose()
        {
            _host.Remove(this);
            switch (_buttons)
            {
                case MessageBoxButtonsEnum.Ok:
                    _result = DialogResultEnum.Ok;
                    break;
                case MessageBoxButtonsEnum.OkCancel:
                    _result = DialogResultEnum.Cancel;
                    break;
                case MessageBoxButtonsEnum.YesNo:
                    _result = DialogResultEnum.No;
                    break;
                case MessageBoxButtonsEnum.YesNoCancel:
                    _result = DialogResultEnum.Cancel;
                    break;
                case MessageBoxButtonsEnum.AbortRetryIgnore:
                    _result = DialogResultEnum.Ignore;
                    break;
                case MessageBoxButtonsEnum.RetryCancel:
                    _result = DialogResultEnum.Cancel;
                    break;
            }
            if (_callback != null)
            {
                _callback(_result);
            }
            base.OnClose();
        }

    }

    public enum MessageBoxIconEnum
    {
        Information,
        Warning,
        Question,
        Error
    }

    public enum MessageBoxButtonsEnum
    {
        Ok,
        OkCancel,
        YesNo,
        YesNoCancel,
        AbortRetryIgnore,
        RetryCancel
    }

    public enum MessageBoxDefaultButtonEnum
    {
        Button1,
        Button2,
        Button3,
    }

    public enum DialogResultEnum
    {
        None,
        Ok,
        Cancel,
        Abort,
        Retry,
        Ignore,
        Yes,
        No
    }

    public delegate void MessageBoxCallback(DialogResultEnum result);

}
