namespace android.text.method
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.method.MovementMethod_))]
	public interface MovementMethod  : global::MonoJavaBridge.IJavaObject 
	{
		void initialize(android.widget.TextView arg0, android.text.Spannable arg1);
		bool onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3);
		bool onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3);
		bool onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2);
		bool onTrackballEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2);
		bool onKeyOther(android.widget.TextView arg0, android.text.Spannable arg1, android.view.KeyEvent arg2);
		void onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2);
		bool canSelectArbitrarily();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.method.MovementMethod))]
	public sealed partial class MovementMethod_ : java.lang.Object, MovementMethod
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MovementMethod_()
		{
			InitJNI();
		}
		internal MovementMethod_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _initialize8656;
		 void android.text.method.MovementMethod.initialize(android.widget.TextView arg0, android.text.Spannable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.MovementMethod_._initialize8656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.MovementMethod_.staticClass, global::android.text.method.MovementMethod_._initialize8656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown8657;
		 bool android.text.method.MovementMethod.onKeyDown(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_._onKeyDown8657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_.staticClass, global::android.text.method.MovementMethod_._onKeyDown8657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp8658;
		 bool android.text.method.MovementMethod.onKeyUp(android.widget.TextView arg0, android.text.Spannable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_._onKeyUp8658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_.staticClass, global::android.text.method.MovementMethod_._onKeyUp8658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent8659;
		 bool android.text.method.MovementMethod.onTouchEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_._onTouchEvent8659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_.staticClass, global::android.text.method.MovementMethod_._onTouchEvent8659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent8660;
		 bool android.text.method.MovementMethod.onTrackballEvent(android.widget.TextView arg0, android.text.Spannable arg1, android.view.MotionEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_._onTrackballEvent8660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_.staticClass, global::android.text.method.MovementMethod_._onTrackballEvent8660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyOther8661;
		 bool android.text.method.MovementMethod.onKeyOther(android.widget.TextView arg0, android.text.Spannable arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_._onKeyOther8661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_.staticClass, global::android.text.method.MovementMethod_._onKeyOther8661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onTakeFocus8662;
		 void android.text.method.MovementMethod.onTakeFocus(android.widget.TextView arg0, android.text.Spannable arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.MovementMethod_._onTakeFocus8662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.MovementMethod_.staticClass, global::android.text.method.MovementMethod_._onTakeFocus8662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _canSelectArbitrarily8663;
		 bool android.text.method.MovementMethod.canSelectArbitrarily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_._canSelectArbitrarily8663);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.MovementMethod_.staticClass, global::android.text.method.MovementMethod_._canSelectArbitrarily8663);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.MovementMethod_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/MovementMethod"));
			global::android.text.method.MovementMethod_._initialize8656 = @__env.GetMethodIDNoThrow(global::android.text.method.MovementMethod_.staticClass, "initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V");
			global::android.text.method.MovementMethod_._onKeyDown8657 = @__env.GetMethodIDNoThrow(global::android.text.method.MovementMethod_.staticClass, "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.MovementMethod_._onKeyUp8658 = @__env.GetMethodIDNoThrow(global::android.text.method.MovementMethod_.staticClass, "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.MovementMethod_._onTouchEvent8659 = @__env.GetMethodIDNoThrow(global::android.text.method.MovementMethod_.staticClass, "onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			global::android.text.method.MovementMethod_._onTrackballEvent8660 = @__env.GetMethodIDNoThrow(global::android.text.method.MovementMethod_.staticClass, "onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z");
			global::android.text.method.MovementMethod_._onKeyOther8661 = @__env.GetMethodIDNoThrow(global::android.text.method.MovementMethod_.staticClass, "onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z");
			global::android.text.method.MovementMethod_._onTakeFocus8662 = @__env.GetMethodIDNoThrow(global::android.text.method.MovementMethod_.staticClass, "onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V");
			global::android.text.method.MovementMethod_._canSelectArbitrarily8663 = @__env.GetMethodIDNoThrow(global::android.text.method.MovementMethod_.staticClass, "canSelectArbitrarily", "()Z");
		}
	}
}
