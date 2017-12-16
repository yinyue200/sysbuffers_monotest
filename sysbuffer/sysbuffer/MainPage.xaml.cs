using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sysbuffer
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent(); ;
            if (System.Buffers.ArrayPool<byte>.Shared.Rent(10).Length < 10)
            {
                throw new Exception();
            }
		}
	}
}
