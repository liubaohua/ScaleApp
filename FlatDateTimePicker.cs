using System;
 using System.Windows.Forms;
 using System.Drawing;
 using System.Drawing.Drawing2D;
 using System.Runtime.InteropServices;


namespace Print
{
     [ToolboxBitmap(typeof(System.Windows.Forms.DateTimePicker))]
     public class FlatDateTimePicker: DateTimePicker
     {
 
        [DllImport("user32.dll", EntryPoint="SendMessageA")]
         private static extern int SendMessage (IntPtr hwnd, int wMsg, IntPtr wParam, int lParam);
 
        [DllImport("user32")]
         private static extern IntPtr GetWindowDC (IntPtr hWnd );
 
        [DllImport("user32")]
         private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC );
 
        const int WM_ERASEBKGND = 0x14;
         const int WM_PAINT = 0xF;
         const int WM_NC_HITTEST = 0x84;
         const int WM_NC_PAINT = 0x85;
         const int WM_PRINTCLIENT = 0x318;
         const int WM_SETCURSOR = 0x20;
 

        private Pen BorderPen  = new Pen(Color.Black, 2);
         private Pen BorderPenControl  = new Pen(SystemColors.ControlDark, 2);
         private bool DroppedDown = false;
         private int InvalidateSince = 0;
         private static int DropDownButtonWidth = 17;
 
        static FlatDateTimePicker()
         {
             // 2 pixel extra is for the 3D border around the pulldown button on the left and right
             DropDownButtonWidth = 10;// ComboInfoHelper.GetComboDropDownWidth() + 2;    
         }
 
        public FlatDateTimePicker()
             : base()
         {
             this.SetStyle(ControlStyles.DoubleBuffer, true);
             //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
         }
         protected override void OnValueChanged(EventArgs eventargs)
         {
             base.OnValueChanged (eventargs);
             this.Invalidate();
         }
 
        protected override void WndProc(ref Message m)
         {
             IntPtr hDC = GetWindowDC(m.HWnd);
             Graphics gdc = Graphics.FromHdc(hDC);
             switch (m.Msg)
             {
                 case WM_NC_PAINT:
                     SendMessage(this.Handle, WM_ERASEBKGND, hDC, 0);
                     SendPrintClientMsg();
                     SendMessage(this.Handle, WM_PAINT, IntPtr.Zero, 0);
                     OverrideControlBorder(gdc);
 
                    m.Result = (IntPtr)1; // indicate msg has been processed
                     break;
                 case WM_PAINT: base.WndProc(ref m);
                     OverrideControlBorder(gdc);
                     OverrideDropDown(gdc);
                     break;
                 case WM_NC_HITTEST:
                     base.WndProc(ref m);
                     if (DroppedDown)
                         this.Invalidate(this.ClientRectangle, false);
                     break;
                 default:
                     base.WndProc(ref m);
                     break;
             }
             ReleaseDC(m.HWnd, hDC);
             gdc.Dispose();    
 
            
         }
         public static void PaintFlatDropDown(Control ctrl, Graphics g)
         {
             Rectangle rect = new Rectangle(ctrl.Width - DropDownButtonWidth, 0, DropDownButtonWidth, ctrl.Height);
             ControlPaint.DrawComboButton(g, rect, ButtonState.Flat);
         }
         private void SendPrintClientMsg()
         {
             // We send this message for the control to redraw the client area
             Graphics gClient = this.CreateGraphics();
             IntPtr ptrClientDC = gClient.GetHdc();
             SendMessage(this.Handle, WM_PRINTCLIENT, ptrClientDC, 0);
             gClient.ReleaseHdc(ptrClientDC);
             gClient.Dispose();
         }
         public void SetText(string text)
         {
             if (text != "")
             {
                 this.Format = DateTimePickerFormat.Long;
 
                this.Text = text;
             }
             else
             {
                 this.Format = DateTimePickerFormat.Custom;
             }
         }
         private void OverrideDropDown(Graphics g)
         {
             if (!this.ShowUpDown)
             {
                 Rectangle rect = new Rectangle(this.Width-DropDownButtonWidth, 0, DropDownButtonWidth, this.Height);
                 ControlPaint.DrawComboButton(g, rect, ButtonState.Flat);    
             }
         }
 
        private void OverrideControlBorder(Graphics g)
         {
             //this.Width = this.Width + 4;
 
            if (this.Focused == false || this.Enabled == false )
                 g.DrawRectangle(BorderPenControl, new Rectangle(0, 0, this.Width, this.Height));
             else
                 g.DrawRectangle(BorderPen, new Rectangle(0, 0, this.Width, this.Height));
         }
         protected override void OnKeyUp(KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
             {
                 this.Format = DateTimePickerFormat.Custom;
                 this.CustomFormat = " ";
                 // OnValueChanged(EventArgs.Empty);
             }
             base.OnKeyUp(e);
         }
         protected override void OnDropDown(EventArgs eventargs)
         {
             InvalidateSince = 0;
             DroppedDown = true;
             base.OnDropDown (eventargs);
         }
         protected override void OnCloseUp(EventArgs eventargs)
         {
             DroppedDown = false;
             this.Format = DateTimePickerFormat.Long;
             base.OnCloseUp (eventargs);
         }
     
         protected override void OnLostFocus(System.EventArgs e)
         {
             base.OnLostFocus(e);
             this.Invalidate();
         }
 
        protected override void OnGotFocus(System.EventArgs e)
         {
             base.OnGotFocus(e);
             this.Invalidate();
         }        
         protected override void OnResize(EventArgs e)
         {
             base.OnResize (e);
             this.Invalidate();
         }
    }
 }