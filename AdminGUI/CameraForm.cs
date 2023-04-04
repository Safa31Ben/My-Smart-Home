using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace AdminGUI
{
    public partial class CameraForm : Form
    {
        FilterInfoCollection filterInfoCollection;
        static VideoCaptureDevice videoCaptureDevice;
        public CameraForm()
        {
            InitializeComponent();
           /* CameraInterface o = (CameraInterface)Activator.GetObject(typeof(CameraInterface),
                "tcp://localhost:8088/Camera");
            * */
            //this.ceremaBox.Text = o.getLive().ToString();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();
            
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            liveBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public static void colseCamera() {
            if (videoCaptureDevice != null)
                if (videoCaptureDevice.IsRunning == true)
                    videoCaptureDevice.Stop();
        }
    }
}