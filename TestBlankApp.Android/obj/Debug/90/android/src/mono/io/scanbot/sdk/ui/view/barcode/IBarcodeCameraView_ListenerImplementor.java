package mono.io.scanbot.sdk.ui.view.barcode;


public class IBarcodeCameraView_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		io.scanbot.sdk.ui.view.barcode.IBarcodeCameraView.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_barcodeScanned:(Lio/scanbot/sdk/camera/FrameHandlerResult;)V:GetBarcodeScanned_Lio_scanbot_sdk_camera_FrameHandlerResult_Handler:IO.Scanbot.Sdk.UI.View.Barcode.IBarcodeCameraViewListenerInvoker, SDK.UI.Barcode\n" +
			"n_cameraPermissionDenied:()V:GetCameraPermissionDeniedHandler:IO.Scanbot.Sdk.UI.View.Barcode.IBarcodeCameraViewListenerInvoker, SDK.UI.Barcode\n" +
			"n_cameraPermissionGranted:()V:GetCameraPermissionGrantedHandler:IO.Scanbot.Sdk.UI.View.Barcode.IBarcodeCameraViewListenerInvoker, SDK.UI.Barcode\n" +
			"n_onActivateCameraPermission:()V:GetOnActivateCameraPermissionHandler:IO.Scanbot.Sdk.UI.View.Barcode.IBarcodeCameraViewListenerInvoker, SDK.UI.Barcode\n" +
			"n_onCameraOpened:()V:GetOnCameraOpenedHandler:IO.Scanbot.Sdk.UI.View.Barcode.IBarcodeCameraViewListenerInvoker, SDK.UI.Barcode\n" +
			"n_onCancelClicked:()V:GetOnCancelClickedHandler:IO.Scanbot.Sdk.UI.View.Barcode.IBarcodeCameraViewListenerInvoker, SDK.UI.Barcode\n" +
			"n_onFlashClicked:()V:GetOnFlashClickedHandler:IO.Scanbot.Sdk.UI.View.Barcode.IBarcodeCameraViewListenerInvoker, SDK.UI.Barcode\n" +
			"n_pageSnapped:([BI)V:GetPageSnapped_arrayBIHandler:IO.Scanbot.Sdk.UI.View.Barcode.IBarcodeCameraViewListenerInvoker, SDK.UI.Barcode\n" +
			"";
		mono.android.Runtime.register ("IO.Scanbot.Sdk.UI.View.Barcode.IBarcodeCameraViewListenerImplementor, SDK.UI.Barcode", IBarcodeCameraView_ListenerImplementor.class, __md_methods);
	}


	public IBarcodeCameraView_ListenerImplementor ()
	{
		super ();
		if (getClass () == IBarcodeCameraView_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("IO.Scanbot.Sdk.UI.View.Barcode.IBarcodeCameraViewListenerImplementor, SDK.UI.Barcode", "", this, new java.lang.Object[] {  });
	}


	public void barcodeScanned (io.scanbot.sdk.camera.FrameHandlerResult p0)
	{
		n_barcodeScanned (p0);
	}

	private native void n_barcodeScanned (io.scanbot.sdk.camera.FrameHandlerResult p0);


	public void cameraPermissionDenied ()
	{
		n_cameraPermissionDenied ();
	}

	private native void n_cameraPermissionDenied ();


	public void cameraPermissionGranted ()
	{
		n_cameraPermissionGranted ();
	}

	private native void n_cameraPermissionGranted ();


	public void onActivateCameraPermission ()
	{
		n_onActivateCameraPermission ();
	}

	private native void n_onActivateCameraPermission ();


	public void onCameraOpened ()
	{
		n_onCameraOpened ();
	}

	private native void n_onCameraOpened ();


	public void onCancelClicked ()
	{
		n_onCancelClicked ();
	}

	private native void n_onCancelClicked ();


	public void onFlashClicked ()
	{
		n_onFlashClicked ();
	}

	private native void n_onFlashClicked ();


	public void pageSnapped (byte[] p0, int p1)
	{
		n_pageSnapped (p0, p1);
	}

	private native void n_pageSnapped (byte[] p0, int p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
