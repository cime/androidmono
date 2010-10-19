namespace android.view
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.WindowManager_))]
	public interface WindowManager : ViewManager
	{
		global::android.view.Display getDefaultDisplay();
		void removeViewImmediate(android.view.View arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.WindowManager))]
	public sealed partial class WindowManager_ : java.lang.Object, WindowManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WindowManager_()
		{
			InitJNI();
		}
		internal WindowManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultDisplay10382;
		 global::android.view.Display android.view.WindowManager.getDefaultDisplay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.WindowManager_._getDefaultDisplay10382)) as android.view.Display;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.WindowManager_.staticClass, global::android.view.WindowManager_._getDefaultDisplay10382)) as android.view.Display;
		}
		internal static global::MonoJavaBridge.MethodId _removeViewImmediate10383;
		 void android.view.WindowManager.removeViewImmediate(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.WindowManager_._removeViewImmediate10383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.WindowManager_.staticClass, global::android.view.WindowManager_._removeViewImmediate10383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView10384;
		 void android.view.ViewManager.addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.WindowManager_._addView10384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.WindowManager_.staticClass, global::android.view.WindowManager_._addView10384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateViewLayout10385;
		 void android.view.ViewManager.updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.WindowManager_._updateViewLayout10385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.WindowManager_.staticClass, global::android.view.WindowManager_._updateViewLayout10385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeView10386;
		 void android.view.ViewManager.removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.WindowManager_._removeView10386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.WindowManager_.staticClass, global::android.view.WindowManager_._removeView10386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.WindowManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/WindowManager"));
			global::android.view.WindowManager_._getDefaultDisplay10382 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_.staticClass, "getDefaultDisplay", "()Landroid/view/Display;");
			global::android.view.WindowManager_._removeViewImmediate10383 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_.staticClass, "removeViewImmediate", "(Landroid/view/View;)V");
			global::android.view.WindowManager_._addView10384 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.WindowManager_._updateViewLayout10385 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.WindowManager_._removeView10386 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_.staticClass, "removeView", "(Landroid/view/View;)V");
		}
	}
}
