namespace android.view.accessibility
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessibilityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccessibilityManager()
		{
			InitJNI();
		}
		internal AccessibilityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _interrupt10430;
		public void interrupt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager._interrupt10430);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._interrupt10430);
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled10431;
		public bool isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager._isEnabled10431);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._isEnabled10431);
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEvent10432;
		public void sendAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent10432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent10432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List AccessibilityServiceList
		{
			get
			{
				return getAccessibilityServiceList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAccessibilityServiceList10433;
		public global::java.util.List getAccessibilityServiceList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList10433)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList10433)) as java.util.List;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.accessibility.AccessibilityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/accessibility/AccessibilityManager"));
			global::android.view.accessibility.AccessibilityManager._interrupt10430 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "interrupt", "()V");
			global::android.view.accessibility.AccessibilityManager._isEnabled10431 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "isEnabled", "()Z");
			global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent10432 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList10433 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "getAccessibilityServiceList", "()Ljava/util/List;");
		}
	}
}
